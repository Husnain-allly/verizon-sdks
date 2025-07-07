// <copyright file="AppConfigServiceApi.cs" company="APIMatic">
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
    /// AppConfigServiceApi.
    /// </summary>
    public class AppConfigServiceApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppConfigServiceApi"/> class.
        /// </summary>
        internal AppConfigServiceApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint fetches and returns the list of configurations defined by the Vendor. The list contains the configurations' identifier, name, description, and active flag. The vendor ID is provided when the configuration is created through the POST request.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="vendorId">Required parameter: The vendor's identifier.</param>
        /// <returns>Returns the ApiResponse of List of Models.ConfigurationListItem response from the API call.</returns>
        public ApiResponse<List<Models.ConfigurationListItem>> GetConfigurationList(
                string vendorId)
            => CoreHelper.RunTask(GetConfigurationListAsync(vendorId));

        /// <summary>
        /// This endpoint fetches and returns the list of configurations defined by the Vendor. The list contains the configurations' identifier, name, description, and active flag. The vendor ID is provided when the configuration is created through the POST request.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="vendorId">Required parameter: The vendor's identifier.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List of Models.ConfigurationListItem response from the API call.</returns>
        public async Task<ApiResponse<List<Models.ConfigurationListItem>>> GetConfigurationListAsync(
                string vendorId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.ConfigurationListItem>>()
              .Server(Server.ImpServer)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api/v1/application/configurations/geofence/ids")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("SessionToken")
                  )
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("VendorID", vendorId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new AppConfigResponseErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Configuration not found", (_reason, _context) => new AppConfigResponseErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new AppConfigResponseErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("unexpected error", (_reason, _context) => new AppConfigResponseErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint fetches and returns a specific configuration's details. The configuration ID parameter, which was provided when the configuration was created through the POST request, is need to retrieve the configuration details.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="id">Required parameter: The configuration identifier.</param>
        /// <param name="vendorId">Required parameter: The vendor's identifier.</param>
        /// <returns>Returns the ApiResponse of Models.GeoFenceConfigurationResponse response from the API call.</returns>
        public ApiResponse<Models.GeoFenceConfigurationResponse> GetConfiguration(
                string id,
                string vendorId)
            => CoreHelper.RunTask(GetConfigurationAsync(id, vendorId));

        /// <summary>
        /// This endpoint fetches and returns a specific configuration's details. The configuration ID parameter, which was provided when the configuration was created through the POST request, is need to retrieve the configuration details.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="id">Required parameter: The configuration identifier.</param>
        /// <param name="vendorId">Required parameter: The vendor's identifier.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GeoFenceConfigurationResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GeoFenceConfigurationResponse>> GetConfigurationAsync(
                string id,
                string vendorId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GeoFenceConfigurationResponse>()
              .Server(Server.ImpServer)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api/v1/application/configurations/geofence")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("SessionToken")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("id", id).Required())
                      .Header(_header => _header.Setup("VendorID", vendorId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new AppConfigResponseErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Configuration not found", (_reason, _context) => new AppConfigResponseErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new AppConfigResponseErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("unexpected error", (_reason, _context) => new AppConfigResponseErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint creates a new configuration in the system. The data for the new configuration should be provided as JSON in the body of the POST request. The system will return with a unique ID for the configuration, which is needed for any further manipulation (update or delete) of the configuration.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="vendorId">Required parameter: The vendor's identifier.</param>
        /// <param name="body">Required parameter: .</param>
        /// <returns>Returns the ApiResponse of Models.GeoFenceConfigurationResponse response from the API call.</returns>
        public ApiResponse<Models.GeoFenceConfigurationResponse> CreateConfiguration(
                string vendorId,
                Models.GeoFenceConfigurationRequest body)
            => CoreHelper.RunTask(CreateConfigurationAsync(vendorId, body));

        /// <summary>
        /// This endpoint creates a new configuration in the system. The data for the new configuration should be provided as JSON in the body of the POST request. The system will return with a unique ID for the configuration, which is needed for any further manipulation (update or delete) of the configuration.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="vendorId">Required parameter: The vendor's identifier.</param>
        /// <param name="body">Required parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GeoFenceConfigurationResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GeoFenceConfigurationResponse>> CreateConfigurationAsync(
                string vendorId,
                Models.GeoFenceConfigurationRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GeoFenceConfigurationResponse>()
              .Server(Server.ImpServer)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api/v1/application/configurations/geofence")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("SessionToken")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("VendorID", vendorId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid configuration", (_reason, _context) => new AppConfigResponseErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new AppConfigResponseErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new AppConfigResponseErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("unexpected error", (_reason, _context) => new AppConfigResponseErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint updates an existing configuration. Similar to POST, the updated data for the configuration should be provided as JSON in the body of the PUT request. The configuration ID parameter, which was provided by the POST (create) operation, is required to do any updates on the configuration.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="vendorId">Required parameter: The vendor's identifier.</param>
        /// <param name="id">Required parameter: The configuration identifier.</param>
        /// <param name="body">Required parameter: .</param>
        public void UpdateConfiguration(
                string vendorId,
                string id,
                Models.GeoFenceConfigurationUpdateRequest body)
            => CoreHelper.RunVoidTask(UpdateConfigurationAsync(vendorId, id, body));

        /// <summary>
        /// This endpoint updates an existing configuration. Similar to POST, the updated data for the configuration should be provided as JSON in the body of the PUT request. The configuration ID parameter, which was provided by the POST (create) operation, is required to do any updates on the configuration.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="vendorId">Required parameter: The vendor's identifier.</param>
        /// <param name="id">Required parameter: The configuration identifier.</param>
        /// <param name="body">Required parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task UpdateConfigurationAsync(
                string vendorId,
                string id,
                Models.GeoFenceConfigurationUpdateRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.ImpServer)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/api/v1/application/configurations/geofence")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("SessionToken")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("VendorID", vendorId).Required())
                      .Query(_query => _query.Setup("id", id).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid configuration", (_reason, _context) => new AppConfigResponseErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new AppConfigResponseErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Configuration not found", (_reason, _context) => new AppConfigResponseErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new AppConfigResponseErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("unexpected error", (_reason, _context) => new AppConfigResponseErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint deletes a specific configuration from the system. It requires the configuration ID parameter, which was provided by the POST (create) operation.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="vendorId">Required parameter: The vendor's identifier.</param>
        /// <param name="id">Required parameter: The configuration identifier.</param>
        public void DeleteConfiguration(
                string vendorId,
                string id)
            => CoreHelper.RunVoidTask(DeleteConfigurationAsync(vendorId, id));

        /// <summary>
        /// This endpoint deletes a specific configuration from the system. It requires the configuration ID parameter, which was provided by the POST (create) operation.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="vendorId">Required parameter: The vendor's identifier.</param>
        /// <param name="id">Required parameter: The configuration identifier.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task DeleteConfigurationAsync(
                string vendorId,
                string id,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.ImpServer)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/api/v1/application/configurations/geofence")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("SessionToken")
                  )
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("VendorID", vendorId).Required())
                      .Query(_query => _query.Setup("id", id).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new AppConfigResponseErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new AppConfigResponseErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("unexpected error", (_reason, _context) => new AppConfigResponseErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}