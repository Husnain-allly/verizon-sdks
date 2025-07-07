// <copyright file="ManagingEsimProfilesApi.cs" company="APIMatic">
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
    /// ManagingEsimProfilesApi.
    /// </summary>
    public class ManagingEsimProfilesApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagingEsimProfilesApi"/> class.
        /// </summary>
        internal ManagingEsimProfilesApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Resume service to a device with either a lead or local profile.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public ApiResponse<Models.GioRequestResponse> ResumeProfile(
                Models.GioProfileRequest body)
            => CoreHelper.RunTask(ResumeProfileAsync(body));

        /// <summary>
        /// Resume service to a device with either a lead or local profile.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GioRequestResponse>> ResumeProfileAsync(
                Models.GioProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GioRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/profile_resume")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GioRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Suspend a device's Global profile.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public ApiResponse<Models.GioRequestResponse> ProfileSuspend(
                Models.GioProfileRequest body)
            => CoreHelper.RunTask(ProfileSuspendAsync(body));

        /// <summary>
        /// Suspend a device's Global profile.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GioRequestResponse>> ProfileSuspendAsync(
                Models.GioProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GioRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/profile_suspend")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GioRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Suspend all service to an eUICC device, including the lead and local profile.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public ApiResponse<Models.GioRequestResponse> DeviceSuspend(
                Models.GioProfileRequest body)
            => CoreHelper.RunTask(DeviceSuspendAsync(body));

        /// <summary>
        /// Suspend all service to an eUICC device, including the lead and local profile.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GioRequestResponse>> DeviceSuspendAsync(
                Models.GioProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GioRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/device_suspend")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GioRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Enable a fallback profile to be set.
        /// </summary>
        /// <param name="body">Required parameter: Set the fallback attributes to allow a fallback profile to be activated..</param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public ApiResponse<Models.GioRequestResponse> SetFallback(
                Models.FallBack body)
            => CoreHelper.RunTask(SetFallbackAsync(body));

        /// <summary>
        /// Enable a fallback profile to be set.
        /// </summary>
        /// <param name="body">Required parameter: Set the fallback attributes to allow a fallback profile to be activated..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GioRequestResponse>> SetFallbackAsync(
                Models.FallBack body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GioRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/profile/actions/setfallbackattribute")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GioRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Activate a device with either a lead or local profile.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public ApiResponse<Models.GioRequestResponse> ActivateADeviceProfile(
                Models.GioProfileRequest body)
            => CoreHelper.RunTask(ActivateADeviceProfileAsync(body));

        /// <summary>
        /// Activate a device with either a lead or local profile.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GioRequestResponse>> ActivateADeviceProfileAsync(
                Models.GioProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GioRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/activate")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GioRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Enable a device lead or local profile.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public ApiResponse<Models.GioRequestResponse> EnableADeviceProfile(
                Models.DeviceProfileRequest body)
            => CoreHelper.RunTask(EnableADeviceProfileAsync(body));

        /// <summary>
        /// Enable a device lead or local profile.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GioRequestResponse>> EnableADeviceProfileAsync(
                Models.DeviceProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GioRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/enable")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GioRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deactivate the lead or local profile. **Note:** to reactivate the profile, use the **Activate** endpoint above.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public ApiResponse<Models.GioRequestResponse> DeactivateADeviceProfile(
                Models.GioDeactivateDeviceProfileRequest body)
            => CoreHelper.RunTask(DeactivateADeviceProfileAsync(body));

        /// <summary>
        /// Deactivate the lead or local profile. **Note:** to reactivate the profile, use the **Activate** endpoint above.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GioRequestResponse>> DeactivateADeviceProfileAsync(
                Models.GioDeactivateDeviceProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GioRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/deactivate")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GioRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Enable the Global IoT Orchestration device profile for download.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public ApiResponse<Models.GioRequestResponse> EnableADeviceProfileForDownload(
                Models.DeviceProfileRequest body)
            => CoreHelper.RunTask(EnableADeviceProfileForDownloadAsync(body));

        /// <summary>
        /// Enable the Global IoT Orchestration device profile for download.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GioRequestResponse>> EnableADeviceProfileForDownloadAsync(
                Models.DeviceProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GioRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/download_enable")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GioRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Download a Global IoT Orchestration device profile.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public ApiResponse<Models.GioRequestResponse> DownloadADeviceProfile(
                Models.DeviceProfileRequest body)
            => CoreHelper.RunTask(DownloadADeviceProfileAsync(body));

        /// <summary>
        /// Download a Global IoT Orchestration device profile.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GioRequestResponse>> DownloadADeviceProfileAsync(
                Models.DeviceProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GioRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/download")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GioRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete a device profile for Global IoT Orchestration. **Note:** the profile must be deactivated first!.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public ApiResponse<Models.GioRequestResponse> DeleteADeviceProfile(
                Models.DeviceProfileRequest body)
            => CoreHelper.RunTask(DeleteADeviceProfileAsync(body));

        /// <summary>
        /// Delete a device profile for Global IoT Orchestration. **Note:** the profile must be deactivated first!.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GioRequestResponse>> DeleteADeviceProfileAsync(
                Models.DeviceProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GioRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/profile/actions/delete")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GioRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}