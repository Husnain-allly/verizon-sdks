// <copyright file="DevicesLocationsApi.cs" company="APIMatic">
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
    /// DevicesLocationsApi.
    /// </summary>
    public class DevicesLocationsApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DevicesLocationsApi"/> class.
        /// </summary>
        internal DevicesLocationsApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This locations endpoint retrieves the locations for a list of devices.
        /// </summary>
        /// <param name="body">Required parameter: Request to obtain location of devices..</param>
        /// <returns>Returns the ApiResponse of List of Models.Location response from the API call.</returns>
        public ApiResponse<List<Models.Location>> ListDevicesLocationsSynchronous(
                Models.LocationRequest body)
            => CoreHelper.RunTask(ListDevicesLocationsSynchronousAsync(body));

        /// <summary>
        /// This locations endpoint retrieves the locations for a list of devices.
        /// </summary>
        /// <param name="body">Required parameter: Request to obtain location of devices..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List of Models.Location response from the API call.</returns>
        public async Task<ApiResponse<List<Models.Location>>> ListDevicesLocationsSynchronousAsync(
                Models.LocationRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Location>>()
              .Server(Server.DeviceLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/locations")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Requests the current or cached location of up to 10,000 IoT or consumer devices (phones, tablets. etc.). This request returns a synchronous transaction ID, and the location information for each device is returned asynchronously as a DeviceLocation callback message.
        /// </summary>
        /// <param name="body">Required parameter: An asynchronous request to obtain locations of devices..</param>
        /// <returns>Returns the ApiResponse of Models.SynchronousLocationRequestResult response from the API call.</returns>
        public ApiResponse<Models.SynchronousLocationRequestResult> ListDevicesLocationsAsynchronous(
                Models.LocationRequest body)
            => CoreHelper.RunTask(ListDevicesLocationsAsynchronousAsync(body));

        /// <summary>
        /// Requests the current or cached location of up to 10,000 IoT or consumer devices (phones, tablets. etc.). This request returns a synchronous transaction ID, and the location information for each device is returned asynchronously as a DeviceLocation callback message.
        /// </summary>
        /// <param name="body">Required parameter: An asynchronous request to obtain locations of devices..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.SynchronousLocationRequestResult response from the API call.</returns>
        public async Task<ApiResponse<Models.SynchronousLocationRequestResult>> ListDevicesLocationsAsynchronousAsync(
                Models.LocationRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SynchronousLocationRequestResult>()
              .Server(Server.DeviceLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/devicelocations")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "*/*"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Request an asynchronous device location report.
        /// </summary>
        /// <param name="body">Required parameter: Request for device location report..</param>
        /// <returns>Returns the ApiResponse of Models.AsynchronousLocationRequestResult response from the API call.</returns>
        public ApiResponse<Models.AsynchronousLocationRequestResult> CreateLocationReport(
                Models.LocationRequest body)
            => CoreHelper.RunTask(CreateLocationReportAsync(body));

        /// <summary>
        /// Request an asynchronous device location report.
        /// </summary>
        /// <param name="body">Required parameter: Request for device location report..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AsynchronousLocationRequestResult response from the API call.</returns>
        public async Task<ApiResponse<Models.AsynchronousLocationRequestResult>> CreateLocationReportAsync(
                Models.LocationRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AsynchronousLocationRequestResult>()
              .Server(Server.DeviceLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/locationreports")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "*/*"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Download a completed asynchronous device location report.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="txid">Required parameter: Transaction ID from POST /locationreports response..</param>
        /// <param name="startindex">Required parameter: Zero-based number of the first record to return..</param>
        /// <returns>Returns the ApiResponse of Models.LocationReport response from the API call.</returns>
        public ApiResponse<Models.LocationReport> RetrieveLocationReport(
                string accountName,
                string txid,
                int startindex)
            => CoreHelper.RunTask(RetrieveLocationReportAsync(accountName, txid, startindex));

        /// <summary>
        /// Download a completed asynchronous device location report.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="txid">Required parameter: Transaction ID from POST /locationreports response..</param>
        /// <param name="startindex">Required parameter: Zero-based number of the first record to return..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.LocationReport response from the API call.</returns>
        public async Task<ApiResponse<Models.LocationReport>> RetrieveLocationReportAsync(
                string accountName,
                string txid,
                int startindex,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LocationReport>()
              .Server(Server.DeviceLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/locationreports/{accountName}/report/{txid}/index/{startindex}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName).Required())
                      .Template(_template => _template.Setup("txid", txid).Required())
                      .Template(_template => _template.Setup("startindex", startindex))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns the current status of a requested device location report.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="txid">Required parameter: Transaction ID of the report..</param>
        /// <returns>Returns the ApiResponse of Models.LocationReportStatus response from the API call.</returns>
        public ApiResponse<Models.LocationReportStatus> GetLocationReportStatus(
                string accountName,
                string txid)
            => CoreHelper.RunTask(GetLocationReportStatusAsync(accountName, txid));

        /// <summary>
        /// Returns the current status of a requested device location report.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="txid">Required parameter: Transaction ID of the report..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.LocationReportStatus response from the API call.</returns>
        public async Task<ApiResponse<Models.LocationReportStatus>> GetLocationReportStatusAsync(
                string accountName,
                string txid,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LocationReportStatus>()
              .Server(Server.DeviceLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/locationreports/{accountName}/report/{txid}/status")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName).Required())
                      .Template(_template => _template.Setup("txid", txid).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Cancel a queued device location report.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="txid">Required parameter: Transaction ID of the report to cancel..</param>
        /// <returns>Returns the ApiResponse of Models.TransactionId response from the API call.</returns>
        public ApiResponse<Models.TransactionId> CancelQueuedLocationReportGeneration(
                string accountName,
                string txid)
            => CoreHelper.RunTask(CancelQueuedLocationReportGenerationAsync(accountName, txid));

        /// <summary>
        /// Cancel a queued device location report.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="txid">Required parameter: Transaction ID of the report to cancel..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TransactionId response from the API call.</returns>
        public async Task<ApiResponse<Models.TransactionId>> CancelQueuedLocationReportGenerationAsync(
                string accountName,
                string txid,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransactionId>()
              .Server(Server.DeviceLocation)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/locationreports/{accountName}/report/{txid}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName).Required())
                      .Template(_template => _template.Setup("txid", txid).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Unexpected error.", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}