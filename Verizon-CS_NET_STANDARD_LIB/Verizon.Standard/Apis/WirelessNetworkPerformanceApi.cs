// <copyright file="WirelessNetworkPerformanceApi.cs" company="APIMatic">
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
    /// WirelessNetworkPerformanceApi.
    /// </summary>
    public class WirelessNetworkPerformanceApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WirelessNetworkPerformanceApi"/> class.
        /// </summary>
        internal WirelessNetworkPerformanceApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// WNP Query for current network condition.
        /// </summary>
        /// <param name="body">Required parameter: Request for current network health..</param>
        /// <returns>Returns the ApiResponse of Models.WnpRequestResponse response from the API call.</returns>
        public ApiResponse<Models.WnpRequestResponse> NearRealTimeNetworkConditions(
                Models.GetNetworkConditionsRequest body)
            => CoreHelper.RunTask(NearRealTimeNetworkConditionsAsync(body));

        /// <summary>
        /// WNP Query for current network condition.
        /// </summary>
        /// <param name="body">Required parameter: Request for current network health..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.WnpRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.WnpRequestResponse>> NearRealTimeNetworkConditionsAsync(
                Models.GetNetworkConditionsRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WnpRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/intelligence/network-conditions")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new WnpRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Run a report for FWA Address qualification or to determine network types available and available coverage. Network types covered include: CAT-M, NB-IOT, LTE, LTE-AWS, 5GNW, MMWAVE and C-BAND.
        /// </summary>
        /// <param name="body">Required parameter: Request for network coverage details..</param>
        /// <returns>Returns the ApiResponse of Models.WnpRequestResponse response from the API call.</returns>
        public ApiResponse<Models.WnpRequestResponse> Domestic4GAnd5GNationwideNetworkCoverage(
                Models.M2MV1IntelligenceWirelessCoverageRequest body)
            => CoreHelper.RunTask(Domestic4GAnd5GNationwideNetworkCoverageAsync(body));

        /// <summary>
        /// Run a report for FWA Address qualification or to determine network types available and available coverage. Network types covered include: CAT-M, NB-IOT, LTE, LTE-AWS, 5GNW, MMWAVE and C-BAND.
        /// </summary>
        /// <param name="body">Required parameter: Request for network coverage details..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.WnpRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.WnpRequestResponse>> Domestic4GAnd5GNationwideNetworkCoverageAsync(
                Models.M2MV1IntelligenceWirelessCoverageRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WnpRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/intelligence/wireless-coverage")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new WnpRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Identify the direction and general distance of nearby cell sites and the technology supported by the equipment.
        /// </summary>
        /// <param name="body">Required parameter: Request for cell site proximity..</param>
        /// <returns>Returns the ApiResponse of Models.WnpRequestResponse response from the API call.</returns>
        public ApiResponse<Models.WnpRequestResponse> SiteProximity(
                Models.GetNetworkConditionsRequest body)
            => CoreHelper.RunTask(SiteProximityAsync(body));

        /// <summary>
        /// Identify the direction and general distance of nearby cell sites and the technology supported by the equipment.
        /// </summary>
        /// <param name="body">Required parameter: Request for cell site proximity..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.WnpRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.WnpRequestResponse>> SiteProximityAsync(
                Models.GetNetworkConditionsRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WnpRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/intelligence/site-proximity/action/list")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new WnpRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// A report of a specific device's service scores over a 30 day period.
        /// </summary>
        /// <param name="body">Required parameter: Request for a device's 30 day experience..</param>
        /// <returns>Returns the ApiResponse of Models.WnpRequestResponse response from the API call.</returns>
        public ApiResponse<Models.WnpRequestResponse> DeviceExperience30DaysHistory(
                Models.GetDeviceExperienceScoreHistoryRequest body)
            => CoreHelper.RunTask(DeviceExperience30DaysHistoryAsync(body));

        /// <summary>
        /// A report of a specific device's service scores over a 30 day period.
        /// </summary>
        /// <param name="body">Required parameter: Request for a device's 30 day experience..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.WnpRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.WnpRequestResponse>> DeviceExperience30DaysHistoryAsync(
                Models.GetDeviceExperienceScoreHistoryRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WnpRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/intelligence/device-experience/history/30-days")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new WnpRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Run a report to view the latest device experience score for specific devices.
        /// </summary>
        /// <param name="body">Required parameter: Request for bulk latest history details..</param>
        /// <returns>Returns the ApiResponse of Models.WnpRequestResponse response from the API call.</returns>
        public ApiResponse<Models.WnpRequestResponse> DeviceExperienceBulkLatest(
                Models.GetDeviceExperienceScoreBulkRequest body)
            => CoreHelper.RunTask(DeviceExperienceBulkLatestAsync(body));

        /// <summary>
        /// Run a report to view the latest device experience score for specific devices.
        /// </summary>
        /// <param name="body">Required parameter: Request for bulk latest history details..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.WnpRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.WnpRequestResponse>> DeviceExperienceBulkLatestAsync(
                Models.GetDeviceExperienceScoreBulkRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WnpRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/intelligence/device-experience/bulk/latest")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new WnpRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}