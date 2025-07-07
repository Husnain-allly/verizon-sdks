// <copyright file="SimSecureForIoTLicensesApi.cs" company="APIMatic">
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
    /// SimSecureForIoTLicensesApi.
    /// </summary>
    public class SimSecureForIoTLicensesApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimSecureForIoTLicensesApi"/> class.
        /// </summary>
        internal SimSecureForIoTLicensesApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Assigns SIM-Secure for IoT licenses to SIMs.
        /// </summary>
        /// <param name="body">Required parameter: Request to assign license to devices..</param>
        /// <param name="xRequestId">Optional parameter: Transaction Id..</param>
        /// <returns>Returns the ApiResponse of Models.SecuritySuccessResult response from the API call.</returns>
        public ApiResponse<Models.SecuritySuccessResult> AssignLicenseToDevices(
                Models.AssignLicenseRequest body,
                string xRequestId = null)
            => CoreHelper.RunTask(AssignLicenseToDevicesAsync(body, xRequestId));

        /// <summary>
        /// Assigns SIM-Secure for IoT licenses to SIMs.
        /// </summary>
        /// <param name="body">Required parameter: Request to assign license to devices..</param>
        /// <param name="xRequestId">Optional parameter: Transaction Id..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.SecuritySuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.SecuritySuccessResult>> AssignLicenseToDevicesAsync(
                Models.AssignLicenseRequest body,
                string xRequestId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SecuritySuccessResult>()
              .Server(Server.M2M)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/devices/license/actions/assign")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("X-Request-ID", xRequestId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request.", (_reason, _context) => new SecurityResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized request.", (_reason, _context) => new SecurityResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Request Forbidden.", (_reason, _context) => new SecurityResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found / Does not exist.", (_reason, _context) => new SecurityResultException(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Format / Request Unacceptable.", (_reason, _context) => new SecurityResultException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests.", (_reason, _context) => new SecurityResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Error response.", (_reason, _context) => new SecurityResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Unassigns SIM-Secure for IoT Flexible and Flexible Bundle license from SIMs.
        /// </summary>
        /// <param name="xRequestId">Required parameter: Transaction Id..</param>
        /// <returns>Returns the ApiResponse of Models.SecuritySuccessResult response from the API call.</returns>
        public ApiResponse<Models.SecuritySuccessResult> UnassignLicenseToDevices(
                string xRequestId)
            => CoreHelper.RunTask(UnassignLicenseToDevicesAsync(xRequestId));

        /// <summary>
        /// Unassigns SIM-Secure for IoT Flexible and Flexible Bundle license from SIMs.
        /// </summary>
        /// <param name="xRequestId">Required parameter: Transaction Id..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.SecuritySuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.SecuritySuccessResult>> UnassignLicenseToDevicesAsync(
                string xRequestId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SecuritySuccessResult>()
              .Server(Server.M2M)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/devices/license/actions/assign")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("X-Request-ID", xRequestId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad request.", (_reason, _context) => new SecurityResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized request.", (_reason, _context) => new SecurityResultException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Request forbidden.", (_reason, _context) => new SecurityResultException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found / Does not exist.", (_reason, _context) => new SecurityResultException(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Format / Request Unacceptable.", (_reason, _context) => new SecurityResultException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests.", (_reason, _context) => new SecurityResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Error response.", (_reason, _context) => new SecurityResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}