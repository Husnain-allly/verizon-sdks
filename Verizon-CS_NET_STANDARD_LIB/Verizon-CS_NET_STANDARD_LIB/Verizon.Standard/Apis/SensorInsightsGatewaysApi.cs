// <copyright file="SensorInsightsGatewaysApi.cs" company="APIMatic">
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
    /// SensorInsightsGatewaysApi.
    /// </summary>
    public class SensorInsightsGatewaysApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SensorInsightsGatewaysApi"/> class.
        /// </summary>
        internal SensorInsightsGatewaysApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// SensorInsightsListGatewayDevicesRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Get gateway information.</param>
        /// <returns>Returns the ApiResponse of List of Models.ResourceDevice response from the API call.</returns>
        public ApiResponse<List<Models.ResourceDevice>> SensorInsightsListGatewayDevicesRequest(
                Models.DtoListDevicesRequest body)
            => CoreHelper.RunTask(SensorInsightsListGatewayDevicesRequestAsync(body));

        /// <summary>
        /// SensorInsightsListGatewayDevicesRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Get gateway information.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List of Models.ResourceDevice response from the API call.</returns>
        public async Task<ApiResponse<List<Models.ResourceDevice>>> SensorInsightsListGatewayDevicesRequestAsync(
                Models.DtoListDevicesRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.ResourceDevice>>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/devices/gateways/actions/query")
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
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new M404ManagementErrorException(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Not Acceptable", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("415", CreateErrorCase("Unsupported media type", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal server error.", (_reason, _context) => new M500ManagementErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error", (_reason, _context) => new ManagementErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}