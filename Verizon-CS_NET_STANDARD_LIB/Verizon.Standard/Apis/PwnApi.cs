// <copyright file="PwnApi.cs" company="APIMatic">
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
using Verizon.Standard.Http.Client;
using Verizon.Standard.Http.Response;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Apis
{
    /// <summary>
    /// PwnApi.
    /// </summary>
    public class PwnApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PwnApi"/> class.
        /// </summary>
        internal PwnApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// KPIList EndPoint.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <returns>Returns the ApiResponse of Models.KpiInfoList response from the API call.</returns>
        public ApiResponse<Models.KpiInfoList> KpiList(
                string aname)
            => CoreHelper.RunTask(KpiListAsync(aname));

        /// <summary>
        /// KPIList EndPoint.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.KpiInfoList response from the API call.</returns>
        public async Task<ApiResponse<Models.KpiInfoList>> KpiListAsync(
                string aname,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.KpiInfoList>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/devices/pwn/kpi/list/{aname}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname).Required())))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// GetProfileList EndPoint.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <returns>Returns the ApiResponse of Models.PwnProfileList response from the API call.</returns>
        public ApiResponse<Models.PwnProfileList> GetProfileList(
                string aname)
            => CoreHelper.RunTask(GetProfileListAsync(aname));

        /// <summary>
        /// GetProfileList EndPoint.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.PwnProfileList response from the API call.</returns>
        public async Task<ApiResponse<Models.PwnProfileList>> GetProfileListAsync(
                string aname,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PwnProfileList>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/devices/pwn/profiles/list/{aname}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname).Required())))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ChangePWNDeviceState-Activate EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: .</param>
        /// <returns>Returns the ApiResponse of Models.ChangePwnDeviceStateResponse response from the API call.</returns>
        public ApiResponse<Models.ChangePwnDeviceStateResponse> ChangePwnDeviceStateActivate(
                Models.ChangePwnDeviceStateActivateRequest body)
            => CoreHelper.RunTask(ChangePwnDeviceStateActivateAsync(body));

        /// <summary>
        /// ChangePWNDeviceState-Activate EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ChangePwnDeviceStateResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ChangePwnDeviceStateResponse>> ChangePwnDeviceStateActivateAsync(
                Models.ChangePwnDeviceStateActivateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ChangePwnDeviceStateResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/pwn/actions/state/activate")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ChangePWNDeviceState-Deactivate EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: .</param>
        /// <returns>Returns the ApiResponse of Models.ChangePwnDeviceStateResponse response from the API call.</returns>
        public ApiResponse<Models.ChangePwnDeviceStateResponse> ChangePwnDeviceStateDeactivate(
                Models.ChangePwnDeviceStateDeactivateRequest body)
            => CoreHelper.RunTask(ChangePwnDeviceStateDeactivateAsync(body));

        /// <summary>
        /// ChangePWNDeviceState-Deactivate EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ChangePwnDeviceStateResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ChangePwnDeviceStateResponse>> ChangePwnDeviceStateDeactivateAsync(
                Models.ChangePwnDeviceStateDeactivateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ChangePwnDeviceStateResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/pwn/actions/state/deactivate")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ChangePWNDeviceProfile EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: .</param>
        /// <returns>Returns the ApiResponse of Models.ChangePwnDeviceProfileResponse response from the API call.</returns>
        public ApiResponse<Models.ChangePwnDeviceProfileResponse> ChangePwnDeviceProfile(
                Models.ChangePwnDeviceProfileRequest body)
            => CoreHelper.RunTask(ChangePwnDeviceProfileAsync(body));

        /// <summary>
        /// ChangePWNDeviceProfile EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ChangePwnDeviceProfileResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ChangePwnDeviceProfileResponse>> ChangePwnDeviceProfileAsync(
                Models.ChangePwnDeviceProfileRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ChangePwnDeviceProfileResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/pwn/actions/profile")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// ChangePWNDeviceIPaddress EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: .</param>
        /// <returns>Returns the ApiResponse of Models.ChangePwnDeviceIpaddressResponse response from the API call.</returns>
        public ApiResponse<Models.ChangePwnDeviceIpaddressResponse> ChangePwnDeviceIpaddress(
                Models.ChangePwnDeviceIpaddressRequest body)
            => CoreHelper.RunTask(ChangePwnDeviceIpaddressAsync(body));

        /// <summary>
        /// ChangePWNDeviceIPaddress EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ChangePwnDeviceIpaddressResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ChangePwnDeviceIpaddressResponse>> ChangePwnDeviceIpaddressAsync(
                Models.ChangePwnDeviceIpaddressRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ChangePwnDeviceIpaddressResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/m2m/v1/devices/pwn/actions/ipaddress")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// GetPWNPerformanceConsent EndPoint.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <returns>Returns the ApiResponse of Models.GetPwnPerformanceConsentResponse response from the API call.</returns>
        public ApiResponse<Models.GetPwnPerformanceConsentResponse> GetPwnPerformanceConsent(
                string aname)
            => CoreHelper.RunTask(GetPwnPerformanceConsentAsync(aname));

        /// <summary>
        /// GetPWNPerformanceConsent EndPoint.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GetPwnPerformanceConsentResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GetPwnPerformanceConsentResponse>> GetPwnPerformanceConsentAsync(
                string aname,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetPwnPerformanceConsentResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/devices/pwn/performance/consent/{aname}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname).Required())))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}