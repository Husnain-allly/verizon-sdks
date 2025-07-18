// <copyright file="M5GBiDeviceActionsApi.cs" company="APIMatic">
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
    /// M5GBiDeviceActionsApi.
    /// </summary>
    public class M5GBiDeviceActionsApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="M5GBiDeviceActionsApi"/> class.
        /// </summary>
        internal M5GBiDeviceActionsApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Uses the decive's Integrated Circuit Card Identification Number (ICCID) to retrive and display the device's properties.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <returns>Returns the ApiResponse of Models.M5GBideviceDetailsresponse response from the API call.</returns>
        public ApiResponse<Models.M5GBideviceDetailsresponse> BusinessInternetlistDeviceInformation(
                Models.M5GBideviceId body)
            => CoreHelper.RunTask(BusinessInternetlistDeviceInformationAsync(body));

        /// <summary>
        /// Uses the decive's Integrated Circuit Card Identification Number (ICCID) to retrive and display the device's properties.
        /// </summary>
        /// <param name="body">Required parameter: Device Profile Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.M5GBideviceDetailsresponse response from the API call.</returns>
        public async Task<ApiResponse<Models.M5GBideviceDetailsresponse>> BusinessInternetlistDeviceInformationAsync(
                Models.M5GBideviceId body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.M5GBideviceDetailsresponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/actions/list")
                  .WithOrAuth(_orAuth => _orAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new M5GBiRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Uses the device's ICCID and IMEI to activate service.
        /// </summary>
        /// <param name="body">Required parameter: Activate 5G BI service. Defining <code>publicIpRestriction</code> as "Unrestricted" or "Restricted" is required for activating as Public Static. Leave  <code>publicIpRestriction</code> undefined to activate as Public Dynamic. Removing <code>publicIpRestriction</code> from the request will activate as Mobile Private Network (MPN)..</param>
        /// <returns>Returns the ApiResponse of Models.M5GBiRequestResponse response from the API call.</returns>
        public ApiResponse<Models.M5GBiRequestResponse> BusinessInternetactivateUsingPost(
                Models.M5GBiactivateRequest body)
            => CoreHelper.RunTask(BusinessInternetactivateUsingPostAsync(body));

        /// <summary>
        /// Uses the device's ICCID and IMEI to activate service.
        /// </summary>
        /// <param name="body">Required parameter: Activate 5G BI service. Defining <code>publicIpRestriction</code> as "Unrestricted" or "Restricted" is required for activating as Public Static. Leave  <code>publicIpRestriction</code> undefined to activate as Public Dynamic. Removing <code>publicIpRestriction</code> from the request will activate as Mobile Private Network (MPN)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.M5GBiRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.M5GBiRequestResponse>> BusinessInternetactivateUsingPostAsync(
                Models.M5GBiactivateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.M5GBiRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/actions/activate")
                  .WithOrAuth(_orAuth => _orAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new M5GBiRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Change a device's service plan to use 5G BI.
        /// </summary>
        /// <param name="body">Required parameter: This endpoint is for use when changing a device's service plan to a 5G BI service plan. The service plan can change for an active device up to four times per month but will require address validation for each change. The service plan cannot be changed for a device while its service is suspended..</param>
        /// <returns>Returns the ApiResponse of Models.M5GBiRequestResponse response from the API call.</returns>
        public ApiResponse<Models.M5GBiRequestResponse> BusinessInternetServiceplanchange(
                Models.M5GBichangeRequest body)
            => CoreHelper.RunTask(BusinessInternetServiceplanchangeAsync(body));

        /// <summary>
        /// Change a device's service plan to use 5G BI.
        /// </summary>
        /// <param name="body">Required parameter: This endpoint is for use when changing a device's service plan to a 5G BI service plan. The service plan can change for an active device up to four times per month but will require address validation for each change. The service plan cannot be changed for a device while its service is suspended..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.M5GBiRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.M5GBiRequestResponse>> BusinessInternetServiceplanchangeAsync(
                Models.M5GBichangeRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.M5GBiRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/actions/plan")
                  .WithOrAuth(_orAuth => _orAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new M5GBiRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}