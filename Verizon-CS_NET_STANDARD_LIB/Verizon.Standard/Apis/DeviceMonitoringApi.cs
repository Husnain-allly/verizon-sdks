// <copyright file="DeviceMonitoringApi.cs" company="APIMatic">
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
    /// DeviceMonitoringApi.
    /// </summary>
    public class DeviceMonitoringApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceMonitoringApi"/> class.
        /// </summary>
        internal DeviceMonitoringApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// DeviceReachability EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Create Reachability Report Request.</param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public ApiResponse<Models.RequestResponse> DeviceReachability(
                Models.NotificationReportRequest body)
            => CoreHelper.RunTask(DeviceReachabilityAsync(body));

        /// <summary>
        /// DeviceReachability EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Create Reachability Report Request.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.RequestResponse>> DeviceReachabilityAsync(
                Models.NotificationReportRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/diagnostics/basic/devicereachability")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error Response", (_reason, _context) => new RestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// StopDeviceReachability EndPoint.
        /// </summary>
        /// <param name="stopreachabilitypayload">Required parameter: Payload for the Stop Device Reachability monitors request..</param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public ApiResponse<Models.RequestResponse> StopDeviceReachability(
                Models.StopMonitorRequest stopreachabilitypayload)
            => CoreHelper.RunTask(StopDeviceReachabilityAsync(stopreachabilitypayload));

        /// <summary>
        /// StopDeviceReachability EndPoint.
        /// </summary>
        /// <param name="stopreachabilitypayload">Required parameter: Payload for the Stop Device Reachability monitors request..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.RequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.RequestResponse>> StopDeviceReachabilityAsync(
                Models.StopMonitorRequest stopreachabilitypayload,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/m2m/v1/diagnostics/basic/devicereachability")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("stopreachabilitypayload", stopreachabilitypayload).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error Response", (_reason, _context) => new RestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}