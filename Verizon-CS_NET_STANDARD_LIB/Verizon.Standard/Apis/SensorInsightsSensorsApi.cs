// <copyright file="SensorInsightsSensorsApi.cs" company="APIMatic">
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
    /// SensorInsightsSensorsApi.
    /// </summary>
    public class SensorInsightsSensorsApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SensorInsightsSensorsApi"/> class.
        /// </summary>
        internal SensorInsightsSensorsApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// SensorInsightsListSensorDevicesRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: List details of the sensors.</param>
        /// <returns>Returns the ApiResponse of List of Models.ResourceDevice response from the API call.</returns>
        public ApiResponse<List<Models.ResourceDevice>> SensorInsightsListSensorDevicesRequest(
                Models.DtoListSensorDevicesRequest body)
            => CoreHelper.RunTask(SensorInsightsListSensorDevicesRequestAsync(body));

        /// <summary>
        /// SensorInsightsListSensorDevicesRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: List details of the sensors.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List of Models.ResourceDevice response from the API call.</returns>
        public async Task<ApiResponse<List<Models.ResourceDevice>>> SensorInsightsListSensorDevicesRequestAsync(
                Models.DtoListSensorDevicesRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.ResourceDevice>>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/devices/sensors/actions/query")
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
        /// SensorInsightsOnBoardSensorRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Onboarding a sensor.</param>
        public void SensorInsightsOnBoardSensorRequest(
                Models.DtoOnBoardSensorRequest body)
            => CoreHelper.RunVoidTask(SensorInsightsOnBoardSensorRequestAsync(body));

        /// <summary>
        /// SensorInsightsOnBoardSensorRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Onboarding a sensor.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task SensorInsightsOnBoardSensorRequestAsync(
                Models.DtoOnBoardSensorRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/devices/sensors/onboard")
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
                  .ErrorCase("406", CreateErrorCase("Not Acceptable", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("415", CreateErrorCase("Unsupported media type", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal server error.", (_reason, _context) => new M500ManagementErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error", (_reason, _context) => new ManagementErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// SensorInsightsSensorOnBoardStatusRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Get the sensor's onboarding status.</param>
        /// <returns>Returns the ApiResponse of Models.DtoSensorOnBoardingStatusResponse response from the API call.</returns>
        public ApiResponse<Models.DtoSensorOnBoardingStatusResponse> SensorInsightsSensorOnBoardStatusRequest(
                Models.DtoSensorOnBoardStatusRequest body)
            => CoreHelper.RunTask(SensorInsightsSensorOnBoardStatusRequestAsync(body));

        /// <summary>
        /// SensorInsightsSensorOnBoardStatusRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Get the sensor's onboarding status.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DtoSensorOnBoardingStatusResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.DtoSensorOnBoardingStatusResponse>> SensorInsightsSensorOnBoardStatusRequestAsync(
                Models.DtoSensorOnBoardStatusRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DtoSensorOnBoardingStatusResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/devices/sensors/onboard/status/actions/query")
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
        /// SensorInsightsOffBoardSensorRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Offboard a sensor.</param>
        public void SensorInsightsOffBoardSensorRequest(
                Models.DtoOffBoardSensorRequest body)
            => CoreHelper.RunVoidTask(SensorInsightsOffBoardSensorRequestAsync(body));

        /// <summary>
        /// SensorInsightsOffBoardSensorRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Offboard a sensor.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task SensorInsightsOffBoardSensorRequestAsync(
                Models.DtoOffBoardSensorRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/devices/sensors/offboard")
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
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new M403ManagementErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// SensorInsightsSensorOffBoardingStatusRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Get a sensor's offboarding status.</param>
        /// <returns>Returns the ApiResponse of Models.DtoSensorOffBoardingStatusResponse response from the API call.</returns>
        public ApiResponse<Models.DtoSensorOffBoardingStatusResponse> SensorInsightsSensorOffBoardingStatusRequest(
                Models.DtoSensorOffBoardStatusRequest body)
            => CoreHelper.RunTask(SensorInsightsSensorOffBoardingStatusRequestAsync(body));

        /// <summary>
        /// SensorInsightsSensorOffBoardingStatusRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Get a sensor's offboarding status.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DtoSensorOffBoardingStatusResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.DtoSensorOffBoardingStatusResponse>> SensorInsightsSensorOffBoardingStatusRequestAsync(
                Models.DtoSensorOffBoardStatusRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DtoSensorOffBoardingStatusResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/devices/sensors/offboard/status/actions/query")
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