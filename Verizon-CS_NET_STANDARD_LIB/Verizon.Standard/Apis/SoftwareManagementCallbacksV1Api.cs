// <copyright file="SoftwareManagementCallbacksV1Api.cs" company="APIMatic">
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
    /// SoftwareManagementCallbacksV1Api.
    /// </summary>
    public class SoftwareManagementCallbacksV1Api : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoftwareManagementCallbacksV1Api"/> class.
        /// </summary>
        internal SoftwareManagementCallbacksV1Api(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns the name and endpoint URL of the callback listening services registered for a given account.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <returns>Returns the ApiResponse of List of Models.RegisteredCallbacks response from the API call.</returns>
        public ApiResponse<List<Models.RegisteredCallbacks>> ListRegisteredCallbacks(
                string account)
            => CoreHelper.RunTask(ListRegisteredCallbacksAsync(account));

        /// <summary>
        /// Returns the name and endpoint URL of the callback listening services registered for a given account.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List of Models.RegisteredCallbacks response from the API call.</returns>
        public async Task<ApiResponse<List<Models.RegisteredCallbacks>>> ListRegisteredCallbacksAsync(
                string account,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.RegisteredCallbacks>>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/callbacks/{account}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Registers a URL to receive RESTful messages from a callback service when new firmware versions are available and when upgrades start and finish.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="body">Required parameter: Callback details..</param>
        /// <returns>Returns the ApiResponse of Models.FotaV1CallbackRegistrationResult response from the API call.</returns>
        public ApiResponse<Models.FotaV1CallbackRegistrationResult> RegisterCallback(
                string account,
                Models.FotaV1CallbackRegistrationRequest body)
            => CoreHelper.RunTask(RegisterCallbackAsync(account, body));

        /// <summary>
        /// Registers a URL to receive RESTful messages from a callback service when new firmware versions are available and when upgrades start and finish.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="body">Required parameter: Callback details..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FotaV1CallbackRegistrationResult response from the API call.</returns>
        public async Task<ApiResponse<Models.FotaV1CallbackRegistrationResult>> RegisterCallbackAsync(
                string account,
                Models.FotaV1CallbackRegistrationRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FotaV1CallbackRegistrationResult>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/callbacks/{account}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Template(_template => _template.Setup("account", account).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deregisters the callback endpoint and stops ThingSpace from sending FOTA callback messages for the specified account.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="service">Required parameter: Callback type. Must be 'Fota' for Software Management Services API..</param>
        /// <returns>Returns the ApiResponse of Models.FotaV1SuccessResult response from the API call.</returns>
        public ApiResponse<Models.FotaV1SuccessResult> DeregisterCallback(
                string account,
                Models.CallbackService service)
            => CoreHelper.RunTask(DeregisterCallbackAsync(account, service));

        /// <summary>
        /// Deregisters the callback endpoint and stops ThingSpace from sending FOTA callback messages for the specified account.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="service">Required parameter: Callback type. Must be 'Fota' for Software Management Services API..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FotaV1SuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.FotaV1SuccessResult>> DeregisterCallbackAsync(
                string account,
                Models.CallbackService service,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FotaV1SuccessResult>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/callbacks/{account}/name/{service}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account).Required())
                      .Template(_template => _template.Setup("service", ApiHelper.JsonSerialize(service).Trim('\"')))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}