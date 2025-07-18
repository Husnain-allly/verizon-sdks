// <copyright file="DiagnosticsCallbacksApi.cs" company="APIMatic">
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
    /// DiagnosticsCallbacksApi.
    /// </summary>
    public class DiagnosticsCallbacksApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsCallbacksApi"/> class.
        /// </summary>
        internal DiagnosticsCallbacksApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint allows user to get the registered callback information of an existing diagnostics subscription.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier..</param>
        /// <returns>Returns the ApiResponse of List of Models.DeviceDiagnosticsCallback response from the API call.</returns>
        public ApiResponse<List<Models.DeviceDiagnosticsCallback>> GetDiagnosticsSubscriptionCallbackInfo(
                string accountName)
            => CoreHelper.RunTask(GetDiagnosticsSubscriptionCallbackInfoAsync(accountName));

        /// <summary>
        /// This endpoint allows user to get the registered callback information of an existing diagnostics subscription.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List of Models.DeviceDiagnosticsCallback response from the API call.</returns>
        public async Task<ApiResponse<List<Models.DeviceDiagnosticsCallback>>> GetDiagnosticsSubscriptionCallbackInfoAsync(
                string accountName,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.DeviceDiagnosticsCallback>>()
              .Server(Server.DeviceDiagnostics)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/callbacks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("accountName", accountName).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceDiagnosticsResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user update the callback HTTPS address of an existing diagnostics subscription.
        /// </summary>
        /// <param name="body">Required parameter: Callback URL registration request..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceDiagnosticsCallback response from the API call.</returns>
        public ApiResponse<Models.DeviceDiagnosticsCallback> RegisterDiagnosticsCallbackUrl(
                Models.CallbackRegistrationRequest body)
            => CoreHelper.RunTask(RegisterDiagnosticsCallbackUrlAsync(body));

        /// <summary>
        /// This endpoint allows user update the callback HTTPS address of an existing diagnostics subscription.
        /// </summary>
        /// <param name="body">Required parameter: Callback URL registration request..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceDiagnosticsCallback response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceDiagnosticsCallback>> RegisterDiagnosticsCallbackUrlAsync(
                Models.CallbackRegistrationRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceDiagnosticsCallback>()
              .Server(Server.DeviceDiagnostics)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/callbacks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "*/*"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceDiagnosticsResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user to delete a registered callback URL and credential.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier..</param>
        /// <param name="serviceName">Required parameter: Service name for callback notification..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceDiagnosticsCallback response from the API call.</returns>
        public ApiResponse<Models.DeviceDiagnosticsCallback> UnregisterDiagnosticsCallback(
                string accountName,
                string serviceName)
            => CoreHelper.RunTask(UnregisterDiagnosticsCallbackAsync(accountName, serviceName));

        /// <summary>
        /// This endpoint allows user to delete a registered callback URL and credential.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier..</param>
        /// <param name="serviceName">Required parameter: Service name for callback notification..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceDiagnosticsCallback response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceDiagnosticsCallback>> UnregisterDiagnosticsCallbackAsync(
                string accountName,
                string serviceName,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceDiagnosticsCallback>()
              .Server(Server.DeviceDiagnostics)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/callbacks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("accountName", accountName).Required())
                      .Query(_query => _query.Setup("serviceName", serviceName).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceDiagnosticsResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}