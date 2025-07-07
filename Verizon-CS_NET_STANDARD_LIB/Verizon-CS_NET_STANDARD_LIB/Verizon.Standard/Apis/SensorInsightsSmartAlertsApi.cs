// <copyright file="SensorInsightsSmartAlertsApi.cs" company="APIMatic">
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
    /// SensorInsightsSmartAlertsApi.
    /// </summary>
    public class SensorInsightsSmartAlertsApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SensorInsightsSmartAlertsApi"/> class.
        /// </summary>
        internal SensorInsightsSmartAlertsApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// SensorInsightsListSmartAlertsRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Retrieve a smart alert.</param>
        /// <returns>Returns the ApiResponse of List of Models.UserSmartAlert response from the API call.</returns>
        public ApiResponse<List<Models.UserSmartAlert>> SensorInsightsListSmartAlertsRequest(
                Models.DtoListSmartAlertsRequest body)
            => CoreHelper.RunTask(SensorInsightsListSmartAlertsRequestAsync(body));

        /// <summary>
        /// SensorInsightsListSmartAlertsRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Retrieve a smart alert.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List of Models.UserSmartAlert response from the API call.</returns>
        public async Task<ApiResponse<List<Models.UserSmartAlert>>> SensorInsightsListSmartAlertsRequestAsync(
                Models.DtoListSmartAlertsRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.UserSmartAlert>>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/smartAlerts/actions/query")
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

        /// <summary>
        /// SensorInsightsPatchSmartAlertRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Partially update a smart alert.</param>
        /// <returns>Returns the ApiResponse of Models.UserSmartAlert response from the API call.</returns>
        public ApiResponse<Models.UserSmartAlert> SensorInsightsPatchSmartAlertRequest(
                Models.DtoPatchSmartAlertRequest body)
            => CoreHelper.RunTask(SensorInsightsPatchSmartAlertRequestAsync(body));

        /// <summary>
        /// SensorInsightsPatchSmartAlertRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Partially update a smart alert.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.UserSmartAlert response from the API call.</returns>
        public async Task<ApiResponse<Models.UserSmartAlert>> SensorInsightsPatchSmartAlertRequestAsync(
                Models.DtoPatchSmartAlertRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserSmartAlert>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/dm/v1/smartAlerts")
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

        /// <summary>
        /// SensorInsightsBulkUpdate EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Bulk update smart alerts.</param>
        /// <returns>Returns the ApiResponse of Models.UserSmartAlert response from the API call.</returns>
        public ApiResponse<Models.UserSmartAlert> SensorInsightsBulkUpdate(
                Models.DtoBulkUpdate body)
            => CoreHelper.RunTask(SensorInsightsBulkUpdateAsync(body));

        /// <summary>
        /// SensorInsightsBulkUpdate EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Bulk update smart alerts.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.UserSmartAlert response from the API call.</returns>
        public async Task<ApiResponse<Models.UserSmartAlert>> SensorInsightsBulkUpdateAsync(
                Models.DtoBulkUpdate body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UserSmartAlert>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/smartAlerts/actions/bulkupdate")
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