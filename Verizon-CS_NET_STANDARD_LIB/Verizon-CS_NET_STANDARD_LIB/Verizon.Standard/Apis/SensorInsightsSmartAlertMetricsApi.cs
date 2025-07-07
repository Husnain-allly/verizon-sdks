// <copyright file="SensorInsightsSmartAlertMetricsApi.cs" company="APIMatic">
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
    /// SensorInsightsSmartAlertMetricsApi.
    /// </summary>
    public class SensorInsightsSmartAlertMetricsApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SensorInsightsSmartAlertMetricsApi"/> class.
        /// </summary>
        internal SensorInsightsSmartAlertMetricsApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Get Device Alerts for the most recent daily period, up to 30 days.
        /// </summary>
        /// <param name="body">Required parameter: Daily period requested, up to 30 days..</param>
        /// <returns>Returns the ApiResponse of Models.DtoQueryMetricsResponse response from the API call.</returns>
        public ApiResponse<Models.DtoQueryMetricsResponse> Sensorinsightsmetricsquery(
                Models.DtoQueryMetrics body)
            => CoreHelper.RunTask(SensorinsightsmetricsqueryAsync(body));

        /// <summary>
        /// Get Device Alerts for the most recent daily period, up to 30 days.
        /// </summary>
        /// <param name="body">Required parameter: Daily period requested, up to 30 days..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DtoQueryMetricsResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.DtoQueryMetricsResponse>> SensorinsightsmetricsqueryAsync(
                Models.DtoQueryMetrics body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DtoQueryMetricsResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/smartAlerts/actions/metrics")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new M400ManagementErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("UnAuthorized", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new M403ManagementErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal server error.", (_reason, _context) => new M500ManagementErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}