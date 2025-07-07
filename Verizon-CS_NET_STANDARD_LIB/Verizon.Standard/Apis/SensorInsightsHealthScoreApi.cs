// <copyright file="SensorInsightsHealthScoreApi.cs" company="APIMatic">
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
    /// SensorInsightsHealthScoreApi.
    /// </summary>
    public class SensorInsightsHealthScoreApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SensorInsightsHealthScoreApi"/> class.
        /// </summary>
        internal SensorInsightsHealthScoreApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// SensorInsightsHealthScoreSummary EndPoint.
        /// </summary>
        /// <returns>Returns the ApiResponse of Models.DtoHealthScoreSummary response from the API call.</returns>
        public ApiResponse<Models.DtoHealthScoreSummary> SensorInsightsHealthScoreSummary()
            => CoreHelper.RunTask(SensorInsightsHealthScoreSummaryAsync());

        /// <summary>
        /// SensorInsightsHealthScoreSummary EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DtoHealthScoreSummary response from the API call.</returns>
        public async Task<ApiResponse<Models.DtoHealthScoreSummary>> SensorInsightsHealthScoreSummaryAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DtoHealthScoreSummary>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/healthscore/summary")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  ))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new M400ManagementErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("UnAuthorized", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new M403ManagementErrorException(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Not Acceptable", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("415", CreateErrorCase("Unsupported media type", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal server error.", (_reason, _context) => new M500ManagementErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error", (_reason, _context) => new ManagementErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// SensorInsightsGetNetworkHealthScoreResponse EndPoint.
        /// </summary>
        /// <returns>Returns the ApiResponse of Models.DtoGetNetworkHealthScoreResponse response from the API call.</returns>
        public ApiResponse<Models.DtoGetNetworkHealthScoreResponse> SensorInsightsGetNetworkHealthScoreResponse()
            => CoreHelper.RunTask(SensorInsightsGetNetworkHealthScoreResponseAsync());

        /// <summary>
        /// SensorInsightsGetNetworkHealthScoreResponse EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DtoGetNetworkHealthScoreResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.DtoGetNetworkHealthScoreResponse>> SensorInsightsGetNetworkHealthScoreResponseAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DtoGetNetworkHealthScoreResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/healthscore/network")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  ))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new M400ManagementErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("UnAuthorized", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new M403ManagementErrorException(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Not Acceptable", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("415", CreateErrorCase("Unsupported media type", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal server error.", (_reason, _context) => new M500ManagementErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error", (_reason, _context) => new ManagementErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}