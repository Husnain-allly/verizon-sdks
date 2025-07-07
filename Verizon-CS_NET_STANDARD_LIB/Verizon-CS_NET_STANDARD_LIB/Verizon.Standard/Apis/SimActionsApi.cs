// <copyright file="SimActionsApi.cs" company="APIMatic">
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
    /// SimActionsApi.
    /// </summary>
    public class SimActionsApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimActionsApi"/> class.
        /// </summary>
        internal SimActionsApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// System assign a new activation code to reactivate a deactivated device. **Note:** the previously assigned ICCID must be used to request a new activation code.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.EsimRequestResponse response from the API call.</returns>
        public ApiResponse<Models.EsimRequestResponse> Newactivatecode(
                Models.EsimProfileRequest2 body)
            => CoreHelper.RunTask(NewactivatecodeAsync(body));

        /// <summary>
        /// System assign a new activation code to reactivate a deactivated device. **Note:** the previously assigned ICCID must be used to request a new activation code.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.EsimRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.EsimRequestResponse>> NewactivatecodeAsync(
                Models.EsimProfileRequest2 body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EsimRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/renew_activation_code")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found / Does not exist", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Format / Request Unacceptable", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Uses the profile to activate the SIM.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.EsimRequestResponse response from the API call.</returns>
        public ApiResponse<Models.EsimRequestResponse> SetactivateUsingPost(
                Models.EsimProfileRequest body)
            => CoreHelper.RunTask(SetactivateUsingPostAsync(body));

        /// <summary>
        /// Uses the profile to activate the SIM.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.EsimRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.EsimRequestResponse>> SetactivateUsingPostAsync(
                Models.EsimProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EsimRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/activate")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found / Does not exist", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Format / Request Unacceptable", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Uses the profile to deactivate the SIM.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.EsimRequestResponse response from the API call.</returns>
        public ApiResponse<Models.EsimRequestResponse> SetdeactivateUsingPost(
                Models.ProfileRequest2 body)
            => CoreHelper.RunTask(SetdeactivateUsingPostAsync(body));

        /// <summary>
        /// Uses the profile to deactivate the SIM.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.EsimRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.EsimRequestResponse>> SetdeactivateUsingPostAsync(
                Models.ProfileRequest2 body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EsimRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/deactivate")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found / Does not exist", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Format / Request Unacceptable", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new EsimRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}