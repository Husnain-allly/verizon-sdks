// <copyright file="GlobalReportingApi.cs" company="APIMatic">
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
    /// GlobalReportingApi.
    /// </summary>
    public class GlobalReportingApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalReportingApi"/> class.
        /// </summary>
        internal GlobalReportingApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve the provisioning history of a specific device or devices.
        /// </summary>
        /// <param name="body">Required parameter: Device Provisioning History.</param>
        /// <returns>Returns the ApiResponse of Models.EsimRequestResponse response from the API call.</returns>
        public ApiResponse<Models.EsimRequestResponse> DeviceprovhistoryUsingPost(
                Models.EsimProvhistoryRequest body)
            => CoreHelper.RunTask(DeviceprovhistoryUsingPostAsync(body));

        /// <summary>
        /// Retrieve the provisioning history of a specific device or devices.
        /// </summary>
        /// <param name="body">Required parameter: Device Provisioning History.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.EsimRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.EsimRequestResponse>> DeviceprovhistoryUsingPostAsync(
                Models.EsimProvhistoryRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EsimRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v2/devices/history/actions/list")
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
        /// Retrieve a list of all devices associated with an account.
        /// </summary>
        /// <param name="body">Required parameter: Device List.</param>
        /// <returns>Returns the ApiResponse of Models.EsimRequestResponse response from the API call.</returns>
        public ApiResponse<Models.EsimRequestResponse> RetrieveGlobalList(
                Models.EsimGlobalDeviceList body)
            => CoreHelper.RunTask(RetrieveGlobalListAsync(body));

        /// <summary>
        /// Retrieve a list of all devices associated with an account.
        /// </summary>
        /// <param name="body">Required parameter: Device List.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.EsimRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.EsimRequestResponse>> RetrieveGlobalListAsync(
                Models.EsimGlobalDeviceList body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EsimRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v2/devices/actions/list")
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