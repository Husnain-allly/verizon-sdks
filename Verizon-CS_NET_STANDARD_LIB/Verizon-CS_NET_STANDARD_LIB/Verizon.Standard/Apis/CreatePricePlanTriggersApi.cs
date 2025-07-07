// <copyright file="CreatePricePlanTriggersApi.cs" company="APIMatic">
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
    /// CreatePricePlanTriggersApi.
    /// </summary>
    public class CreatePricePlanTriggersApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePricePlanTriggersApi"/> class.
        /// </summary>
        internal CreatePricePlanTriggersApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Create a usage trigger at the account level, device level or a price plan trigger for all devices on the account.
        /// </summary>
        /// <param name="body">Required parameter: Create a trigger.</param>
        /// <returns>Returns the ApiResponse of Models.TriggerResponse response from the API call.</returns>
        public ApiResponse<Models.TriggerResponse> CreateTriggerRules(
                CreateTriggerRulesBody body)
            => CoreHelper.RunTask(CreateTriggerRulesAsync(body));

        /// <summary>
        /// Create a usage trigger at the account level, device level or a price plan trigger for all devices on the account.
        /// </summary>
        /// <param name="body">Required parameter: Create a trigger.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TriggerResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.TriggerResponse>> CreateTriggerRulesAsync(
                CreateTriggerRulesBody body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TriggerResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v2/triggers")
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