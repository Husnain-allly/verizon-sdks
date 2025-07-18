// <copyright file="PerformanceMetricsApi.cs" company="APIMatic">
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
    /// PerformanceMetricsApi.
    /// </summary>
    public class PerformanceMetricsApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceMetricsApi"/> class.
        /// </summary>
        internal PerformanceMetricsApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Query the most recent data for Key Performance Indicators (KPIs) like network availability, MEC hostnames and more.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the ApiResponse of Models.MecPerformanceMetrics response from the API call.</returns>
        public ApiResponse<Models.MecPerformanceMetrics> QueryMecPerformanceMetrics(
                Models.QueryMecPerformanceMetricsRequest body = null)
            => CoreHelper.RunTask(QueryMecPerformanceMetricsAsync(body));

        /// <summary>
        /// Query the most recent data for Key Performance Indicators (KPIs) like network availability, MEC hostnames and more.
        /// </summary>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.MecPerformanceMetrics response from the API call.</returns>
        public async Task<ApiResponse<Models.MecPerformanceMetrics>> QueryMecPerformanceMetricsAsync(
                Models.QueryMecPerformanceMetricsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MecPerformanceMetrics>()
              .Server(Server.Performance)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/performance/device/network/metrics")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request.", (_reason, _context) => new EdgePerformanceResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized request.", (_reason, _context) => new EdgePerformanceResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Request forbidden.", (_reason, _context) => new EdgePerformanceResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Resource Not Found.", (_reason, _context) => new EdgePerformanceResultException(_reason, _context)))
                  .ErrorCase("405", CreateErrorCase("Method Not Allowed.", (_reason, _context) => new EdgePerformanceResultException(_reason, _context)))
                  .ErrorCase("503", CreateErrorCase("Service Unavailable.", (_reason, _context) => new EdgePerformanceResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}