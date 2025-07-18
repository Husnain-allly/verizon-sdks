// <copyright file="ServiceProfilesApi.cs" company="APIMatic">
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
    /// ServiceProfilesApi.
    /// </summary>
    public class ServiceProfilesApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProfilesApi"/> class.
        /// </summary>
        internal ServiceProfilesApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates a service profile that describes the resource requirements of a service.
        /// </summary>
        /// <param name="body">Required parameter: The request body passes all of the needed parameters to create a service profile. Parameters will be edited here rather than the **Parameters** section above. The `maxLatencyMs` and `clientType` parameters are both required in the request body. **Note:** The `maxLatencyMs` value must be submitted in multiples of 5. Additionally, "GPU" is future functionality and the values are not captured..</param>
        /// <returns>Returns the ApiResponse of Models.CreateServiceProfileResult response from the API call.</returns>
        public ApiResponse<Models.CreateServiceProfileResult> CreateServiceProfile(
                Models.ResourcesServiceProfile body)
            => CoreHelper.RunTask(CreateServiceProfileAsync(body));

        /// <summary>
        /// Creates a service profile that describes the resource requirements of a service.
        /// </summary>
        /// <param name="body">Required parameter: The request body passes all of the needed parameters to create a service profile. Parameters will be edited here rather than the **Parameters** section above. The `maxLatencyMs` and `clientType` parameters are both required in the request body. **Note:** The `maxLatencyMs` value must be submitted in multiples of 5. Additionally, "GPU" is future functionality and the values are not captured..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CreateServiceProfileResult response from the API call.</returns>
        public async Task<ApiResponse<Models.CreateServiceProfileResult>> CreateServiceProfileAsync(
                Models.ResourcesServiceProfile body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CreateServiceProfileResult>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/serviceprofiles")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("HTTP 500 Internal Server Error.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// List all service profiles registered under your API key.
        /// </summary>
        /// <returns>Returns the ApiResponse of Models.ListServiceProfilesResult response from the API call.</returns>
        public ApiResponse<Models.ListServiceProfilesResult> ListServiceProfiles()
            => CoreHelper.RunTask(ListServiceProfilesAsync());

        /// <summary>
        /// List all service profiles registered under your API key.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ListServiceProfilesResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ListServiceProfilesResult>> ListServiceProfilesAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListServiceProfilesResult>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/serviceprofiles")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  ))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("HTTP 500 Internal Server Error.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a specified service profile.
        /// </summary>
        /// <param name="serviceProfileId">Required parameter: .</param>
        /// <returns>Returns the ApiResponse of Models.ResourcesServiceProfileWithId response from the API call.</returns>
        public ApiResponse<Models.ResourcesServiceProfileWithId> GetServiceProfile(
                string serviceProfileId)
            => CoreHelper.RunTask(GetServiceProfileAsync(serviceProfileId));

        /// <summary>
        /// Returns a specified service profile.
        /// </summary>
        /// <param name="serviceProfileId">Required parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ResourcesServiceProfileWithId response from the API call.</returns>
        public async Task<ApiResponse<Models.ResourcesServiceProfileWithId>> GetServiceProfileAsync(
                string serviceProfileId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ResourcesServiceProfileWithId>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/serviceprofiles/{serviceProfileId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("serviceProfileId", serviceProfileId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("HTTP 500 Internal Server Error.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update the definition of a Service Profile.
        /// </summary>
        /// <param name="serviceProfileId">Required parameter: .</param>
        /// <param name="body">Required parameter: The request body passes the rest of the needed parameters to create a service profile. The `maxLatencyMs` and `clientType` parameters are both required in the request body. **Note:** The `maxLatencyMs` value must be submitted in multiples of 5. Additionally, "GPU" is future functionality and the values are not captured. Default values to use are shown..</param>
        /// <returns>Returns the ApiResponse of Models.UpdateServiceProfileResult response from the API call.</returns>
        public ApiResponse<Models.UpdateServiceProfileResult> UpdateServiceProfile(
                string serviceProfileId,
                Models.ResourcesServiceProfile body)
            => CoreHelper.RunTask(UpdateServiceProfileAsync(serviceProfileId, body));

        /// <summary>
        /// Update the definition of a Service Profile.
        /// </summary>
        /// <param name="serviceProfileId">Required parameter: .</param>
        /// <param name="body">Required parameter: The request body passes the rest of the needed parameters to create a service profile. The `maxLatencyMs` and `clientType` parameters are both required in the request body. **Note:** The `maxLatencyMs` value must be submitted in multiples of 5. Additionally, "GPU" is future functionality and the values are not captured. Default values to use are shown..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.UpdateServiceProfileResult response from the API call.</returns>
        public async Task<ApiResponse<Models.UpdateServiceProfileResult>> UpdateServiceProfileAsync(
                string serviceProfileId,
                Models.ResourcesServiceProfile body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UpdateServiceProfileResult>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/serviceprofiles/{serviceProfileId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Template(_template => _template.Setup("serviceProfileId", serviceProfileId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("HTTP 500 Internal Server Error.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Delete Service Profile based on unique service profile ID.
        /// </summary>
        /// <param name="serviceProfileId">Required parameter: .</param>
        /// <returns>Returns the ApiResponse of Models.DeleteServiceProfileResult response from the API call.</returns>
        public ApiResponse<Models.DeleteServiceProfileResult> DeleteServiceProfile(
                string serviceProfileId)
            => CoreHelper.RunTask(DeleteServiceProfileAsync(serviceProfileId));

        /// <summary>
        /// Delete Service Profile based on unique service profile ID.
        /// </summary>
        /// <param name="serviceProfileId">Required parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeleteServiceProfileResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeleteServiceProfileResult>> DeleteServiceProfileAsync(
                string serviceProfileId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeleteServiceProfileResult>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/serviceprofiles/{serviceProfileId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("serviceProfileId", serviceProfileId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("HTTP 500 Internal Server Error.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}