// <copyright file="SensorInsightsDeviceProfileApi.cs" company="APIMatic">
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
    /// SensorInsightsDeviceProfileApi.
    /// </summary>
    public class SensorInsightsDeviceProfileApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SensorInsightsDeviceProfileApi"/> class.
        /// </summary>
        internal SensorInsightsDeviceProfileApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Create a device profile.
        /// </summary>
        /// <param name="body">Required parameter: .</param>
        /// <returns>Returns the ApiResponse of List of Models.DtoProfileResponse response from the API call.</returns>
        public ApiResponse<List<Models.DtoProfileResponse>> CreateAProfile(
                Models.DtoConfigurationProfile body)
            => CoreHelper.RunTask(CreateAProfileAsync(body));

        /// <summary>
        /// Create a device profile.
        /// </summary>
        /// <param name="body">Required parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List of Models.DtoProfileResponse response from the API call.</returns>
        public async Task<ApiResponse<List<Models.DtoProfileResponse>>> CreateAProfileAsync(
                Models.DtoConfigurationProfile body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.DtoProfileResponse>>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/deviceConfigurationProfiles")
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
                  .ErrorCase("500", CreateErrorCase("Internal server error.", (_reason, _context) => new M500ManagementErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete a device profile.
        /// </summary>
        /// <param name="deleterequest">Required parameter: payload for the delete request.</param>
        /// <returns>Returns the ApiResponse of List of Models.DtoProfileResponse response from the API call.</returns>
        public ApiResponse<List<Models.DtoProfileResponse>> DeleteAProfile(
                Models.DtoConfigurationProfileDelete deleterequest)
            => CoreHelper.RunTask(DeleteAProfileAsync(deleterequest));

        /// <summary>
        /// Delete a device profile.
        /// </summary>
        /// <param name="deleterequest">Required parameter: payload for the delete request.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List of Models.DtoProfileResponse response from the API call.</returns>
        public async Task<ApiResponse<List<Models.DtoProfileResponse>>> DeleteAProfileAsync(
                Models.DtoConfigurationProfileDelete deleterequest,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.DtoProfileResponse>>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/dm/v1/deviceConfigurationProfiles")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("deleterequest", deleterequest).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new M400ManagementErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("UnAuthorized", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new M403ManagementErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal server error.", (_reason, _context) => new M500ManagementErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Partially update a device profile.
        /// </summary>
        /// <param name="body">Required parameter: .</param>
        /// <returns>Returns the ApiResponse of List of Models.DtoProfileResponse response from the API call.</returns>
        public ApiResponse<List<Models.DtoProfileResponse>> UpdateAProfile(
                Models.DtoConfigurationProfilePath body)
            => CoreHelper.RunTask(UpdateAProfileAsync(body));

        /// <summary>
        /// Partially update a device profile.
        /// </summary>
        /// <param name="body">Required parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List of Models.DtoProfileResponse response from the API call.</returns>
        public async Task<ApiResponse<List<Models.DtoProfileResponse>>> UpdateAProfileAsync(
                Models.DtoConfigurationProfilePath body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.DtoProfileResponse>>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/dm/v1/deviceConfigurationProfiles")
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
                  .ErrorCase("500", CreateErrorCase("Internal server error.", (_reason, _context) => new M500ManagementErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Query a device profile for an individual device.
        /// </summary>
        /// <param name="body">Required parameter: body.</param>
        /// <returns>Returns the ApiResponse of List of Models.DtoProfileResponse response from the API call.</returns>
        public ApiResponse<List<Models.DtoProfileResponse>> QueryAProfile(
                Models.ResourceResourceQuery body)
            => CoreHelper.RunTask(QueryAProfileAsync(body));

        /// <summary>
        /// Query a device profile for an individual device.
        /// </summary>
        /// <param name="body">Required parameter: body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List of Models.DtoProfileResponse response from the API call.</returns>
        public async Task<ApiResponse<List<Models.DtoProfileResponse>>> QueryAProfileAsync(
                Models.ResourceResourceQuery body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.DtoProfileResponse>>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/deviceConfigurationProfiles/actions/query")
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
                  .ErrorCase("500", CreateErrorCase("Internal server error.", (_reason, _context) => new M500ManagementErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}