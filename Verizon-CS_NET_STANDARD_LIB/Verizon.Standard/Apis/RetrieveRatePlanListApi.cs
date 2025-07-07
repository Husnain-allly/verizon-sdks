// <copyright file="RetrieveRatePlanListApi.cs" company="APIMatic">
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
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Apis
{
    /// <summary>
    /// RetrieveRatePlanListApi.
    /// </summary>
    public class RetrieveRatePlanListApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveRatePlanListApi"/> class.
        /// </summary>
        internal RetrieveRatePlanListApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieves the rate plans and rate plan details for a profile ID.
        /// </summary>
        /// <param name="ecpdId">Required parameter: The Enterprise Customer Profile Database ID. This is the same as the accountName value.</param>
        /// <returns>Returns the ApiResponse of Models.Rateplan response from the API call.</returns>
        public ApiResponse<Models.Rateplan> GetRatePlanList(
                string ecpdId)
            => CoreHelper.RunTask(GetRatePlanListAsync(ecpdId));

        /// <summary>
        /// Retrieves the rate plans and rate plan details for a profile ID.
        /// </summary>
        /// <param name="ecpdId">Required parameter: The Enterprise Customer Profile Database ID. This is the same as the accountName value.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Rateplan response from the API call.</returns>
        public async Task<ApiResponse<Models.Rateplan>> GetRatePlanListAsync(
                string ecpdId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Rateplan>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v2/triggers/rateplanlist/{ecpdId}")
                  .WithOrAuth(_orAuth => _orAuth
                      .Add("thingspace_oauth1")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("ecpdId", ecpdId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new RuleRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}