// <copyright file="ConnectivityCallbacksApi.cs" company="APIMatic">
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
    /// ConnectivityCallbacksApi.
    /// </summary>
    public class ConnectivityCallbacksApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectivityCallbacksApi"/> class.
        /// </summary>
        internal ConnectivityCallbacksApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns the name and endpoint URL of the callback listening services registered for a given account.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <returns>Returns the ApiResponse of List of Models.ConnectivityManagementCallback response from the API call.</returns>
        public ApiResponse<List<Models.ConnectivityManagementCallback>> ListRegisteredCallbacks(
                string aname)
            => CoreHelper.RunTask(ListRegisteredCallbacksAsync(aname));

        /// <summary>
        /// Returns the name and endpoint URL of the callback listening services registered for a given account.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List of Models.ConnectivityManagementCallback response from the API call.</returns>
        public async Task<ApiResponse<List<Models.ConnectivityManagementCallback>>> ListRegisteredCallbacksAsync(
                string aname,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.ConnectivityManagementCallback>>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/callbacks/{aname}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// You are responsible for creating and running a listening process on your server at that URL.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="body">Required parameter: Request to register a callback..</param>
        /// <returns>Returns the ApiResponse of Models.CallbackActionResult response from the API call.</returns>
        public ApiResponse<Models.CallbackActionResult> RegisterCallback(
                string aname,
                Models.RegisterCallbackRequest body)
            => CoreHelper.RunTask(RegisterCallbackAsync(aname, body));

        /// <summary>
        /// You are responsible for creating and running a listening process on your server at that URL.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="body">Required parameter: Request to register a callback..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CallbackActionResult response from the API call.</returns>
        public async Task<ApiResponse<Models.CallbackActionResult>> RegisterCallbackAsync(
                string aname,
                Models.RegisterCallbackRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CallbackActionResult>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/callbacks/{aname}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Template(_template => _template.Setup("aname", aname).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Stops ThingSpace from sending callback messages for the specified account and service.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="sname">Required parameter: Service name..</param>
        /// <returns>Returns the ApiResponse of Models.CallbackActionResult response from the API call.</returns>
        public ApiResponse<Models.CallbackActionResult> DeregisterCallback(
                string aname,
                string sname)
            => CoreHelper.RunTask(DeregisterCallbackAsync(aname, sname));

        /// <summary>
        /// Stops ThingSpace from sending callback messages for the specified account and service.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="sname">Required parameter: Service name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CallbackActionResult response from the API call.</returns>
        public async Task<ApiResponse<Models.CallbackActionResult>> DeregisterCallbackAsync(
                string aname,
                string sname,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CallbackActionResult>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/m2m/v1/callbacks/{aname}/name/{sname}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname).Required())
                      .Template(_template => _template.Setup("sname", sname).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}