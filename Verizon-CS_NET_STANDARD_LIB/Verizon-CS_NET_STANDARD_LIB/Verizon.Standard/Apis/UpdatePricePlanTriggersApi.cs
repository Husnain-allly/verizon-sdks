// <copyright file="UpdatePricePlanTriggersApi.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Date.Xml;
using Newtonsoft.Json.Converters;
using System.Net.Http;
using Verizon.Standard;
using Verizon.Standard.Exceptions;
using Verizon.Standard.Http.Client;
using Verizon.Standard.Http.Response;
using Verizon.Standard.Models.Containers;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Apis
{
    /// <summary>
    /// UpdatePricePlanTriggersApi.
    /// </summary>
    public class UpdatePricePlanTriggersApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePricePlanTriggersApi"/> class.
        /// </summary>
        internal UpdatePricePlanTriggersApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Updates a usage trigger at the account level, device level or a price plan trigger for all devices on the account.
        /// </summary>
        /// <param name="body">Required parameter: Update a trigger.</param>
        /// <returns>Returns the ApiResponse of Models.TriggerResponse response from the API call.</returns>
        public ApiResponse<Models.TriggerResponse> UpdateTriggerRules(
                UpdateTriggerRulesBody body)
            => CoreHelper.RunTask(UpdateTriggerRulesAsync(body));

        /// <summary>
        /// Updates a usage trigger at the account level, device level or a price plan trigger for all devices on the account.
        /// </summary>
        /// <param name="body">Required parameter: Update a trigger.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TriggerResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.TriggerResponse>> UpdateTriggerRulesAsync(
                UpdateTriggerRulesBody body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TriggerResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/v2/triggers")
                  .WithOrAuth(_orAuth => _orAuth
                      .Add("thingspace_oauth1")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new RuleRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}