// <copyright file="SensorInsightsDevicesApi.cs" company="APIMatic">
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
    /// SensorInsightsDevicesApi.
    /// </summary>
    public class SensorInsightsDevicesApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SensorInsightsDevicesApi"/> class.
        /// </summary>
        internal SensorInsightsDevicesApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// SensorInsightsListDevicesRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: List all device details on an account.</param>
        /// <returns>Returns the ApiResponse of List of Models.DtoExpandedDeviceResponse response from the API call.</returns>
        public ApiResponse<List<Models.DtoExpandedDeviceResponse>> SensorInsightsListDevicesRequest(
                Models.DtoListDevicesRequest body)
            => CoreHelper.RunTask(SensorInsightsListDevicesRequestAsync(body));

        /// <summary>
        /// SensorInsightsListDevicesRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: List all device details on an account.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List of Models.DtoExpandedDeviceResponse response from the API call.</returns>
        public async Task<ApiResponse<List<Models.DtoExpandedDeviceResponse>>> SensorInsightsListDevicesRequestAsync(
                Models.DtoListDevicesRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.DtoExpandedDeviceResponse>>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/devices/actions/query")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("UnAuthorized", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Not Acceptable", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("415", CreateErrorCase("Unsupported media type", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal server error.", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error", (_reason, _context) => new ManagementErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// SensorInsightsPatchDeviceRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Partially update a device's details.</param>
        /// <returns>Returns the ApiResponse of Models.ResourceDevice response from the API call.</returns>
        public ApiResponse<Models.ResourceDevice> SensorInsightsPatchDeviceRequest(
                Models.DtoPatchDeviceRequest body)
            => CoreHelper.RunTask(SensorInsightsPatchDeviceRequestAsync(body));

        /// <summary>
        /// SensorInsightsPatchDeviceRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Partially update a device's details.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ResourceDevice response from the API call.</returns>
        public async Task<ApiResponse<Models.ResourceDevice>> SensorInsightsPatchDeviceRequestAsync(
                Models.DtoPatchDeviceRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ResourceDevice>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/dm/v1/devices")
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
        /// SensorInsightsLastReportedTimeRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Get the last reported information for a device.</param>
        /// <returns>Returns the ApiResponse of Models.DtoLastReportedTimeResponse response from the API call.</returns>
        public ApiResponse<Models.DtoLastReportedTimeResponse> SensorInsightsLastReportedTimeRequest(
                Models.DtoLastReportedTimeRequest body)
            => CoreHelper.RunTask(SensorInsightsLastReportedTimeRequestAsync(body));

        /// <summary>
        /// SensorInsightsLastReportedTimeRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Get the last reported information for a device.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DtoLastReportedTimeResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.DtoLastReportedTimeResponse>> SensorInsightsLastReportedTimeRequestAsync(
                Models.DtoLastReportedTimeRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DtoLastReportedTimeResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/devices/lastreported")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new M400ManagementErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new M403ManagementErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new M404ManagementErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// SensorInsightsDeviceActionSetRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Set device configuration.</param>
        /// <returns>Returns the ApiResponse of Models.DtoDeviceActionSetResponse response from the API call.</returns>
        public ApiResponse<Models.DtoDeviceActionSetResponse> SensorInsightsDeviceActionSetRequest(
                Models.DmV1DevicesActionsSetRequest body)
            => CoreHelper.RunTask(SensorInsightsDeviceActionSetRequestAsync(body));

        /// <summary>
        /// SensorInsightsDeviceActionSetRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Set device configuration.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DtoDeviceActionSetResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.DtoDeviceActionSetResponse>> SensorInsightsDeviceActionSetRequestAsync(
                Models.DmV1DevicesActionsSetRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DtoDeviceActionSetResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/devices/actions/set")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new M400ManagementErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new M403ManagementErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new M404ManagementErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// SensorInsightsListDeviceExperienceHistoryRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: List the device experience.</param>
        /// <returns>Returns the ApiResponse of List of Models.UserDeviceExperienceHistory response from the API call.</returns>
        public ApiResponse<List<Models.UserDeviceExperienceHistory>> SensorInsightsListDeviceExperienceHistoryRequest(
                Models.DtoListDeviceExperienceHistoryRequest body)
            => CoreHelper.RunTask(SensorInsightsListDeviceExperienceHistoryRequestAsync(body));

        /// <summary>
        /// SensorInsightsListDeviceExperienceHistoryRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: List the device experience.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List of Models.UserDeviceExperienceHistory response from the API call.</returns>
        public async Task<ApiResponse<List<Models.UserDeviceExperienceHistory>>> SensorInsightsListDeviceExperienceHistoryRequestAsync(
                Models.DtoListDeviceExperienceHistoryRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.UserDeviceExperienceHistory>>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/devices/experience/actions/query")
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
        /// SensorInsightsListNetworkExperienceHistoryRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: List the network experience.</param>
        /// <returns>Returns the ApiResponse of List of Models.UserNetworkExperienceHistory response from the API call.</returns>
        public ApiResponse<List<Models.UserNetworkExperienceHistory>> SensorInsightsListNetworkExperienceHistoryRequest(
                Models.DtoListNetworkExperienceHistoryRequest body)
            => CoreHelper.RunTask(SensorInsightsListNetworkExperienceHistoryRequestAsync(body));

        /// <summary>
        /// SensorInsightsListNetworkExperienceHistoryRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: List the network experience.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List of Models.UserNetworkExperienceHistory response from the API call.</returns>
        public async Task<ApiResponse<List<Models.UserNetworkExperienceHistory>>> SensorInsightsListNetworkExperienceHistoryRequestAsync(
                Models.DtoListNetworkExperienceHistoryRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.UserNetworkExperienceHistory>>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/devices/networkexperience/actions/query")
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