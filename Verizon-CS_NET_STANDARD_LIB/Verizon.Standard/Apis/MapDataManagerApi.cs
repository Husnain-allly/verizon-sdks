// <copyright file="MapDataManagerApi.cs" company="APIMatic">
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
    /// MapDataManagerApi.
    /// </summary>
    public class MapDataManagerApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapDataManagerApi"/> class.
        /// </summary>
        internal MapDataManagerApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint allows the user to upload map messages in SAE J2735 MAP messages in ASN.1 UPER or JER (JSON) formats. The MAP data message can have more than one intersections in it.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="vendorId">Required parameter: The VendorID set during the Vendor registration call..</param>
        /// <param name="body">Required parameter: .</param>
        /// <returns>Returns the ApiResponse of string response from the API call.</returns>
        public ApiResponse<string> UploadMapDataMessage(
                string vendorId,
                string body)
            => CoreHelper.RunTask(UploadMapDataMessageAsync(vendorId, body));

        /// <summary>
        /// This endpoint allows the user to upload map messages in SAE J2735 MAP messages in ASN.1 UPER or JER (JSON) formats. The MAP data message can have more than one intersections in it.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="vendorId">Required parameter: The VendorID set during the Vendor registration call..</param>
        /// <param name="body">Required parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of string response from the API call.</returns>
        public async Task<ApiResponse<string>> UploadMapDataMessageAsync(
                string vendorId,
                string body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<string>()
              .Server(Server.ImpServer)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api/v2/mapdata")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("SessionToken")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("VendorID", vendorId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid request", (_reason, _context) => new MapDataResponseErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new MapDataResponseErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden Request", (_reason, _context) => new MapDataResponseErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Requests", (_reason, _context) => new MapDataResponseErrorException(_reason, _context)))
                  .ErrorCase("503", CreateErrorCase("Internal server Error", (_reason, _context) => new MapDataResponseErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected Error", (_reason, _context) => new MapDataResponseErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user to download SAE J2735 MAP messages in ASN.1 UPER format. The area for the MAP messages is needed to be defined in the query.
        /// </summary>
        /// <param name="vendorId">Required parameter: The VendorID set during the Vendor registration call..</param>
        /// <param name="geofence">Required parameter: The area where the user wants to receive MAP data from..</param>
        /// <returns>Returns the ApiResponse of string response from the API call.</returns>
        public ApiResponse<string> DownloadMapDataMessage(
                string vendorId,
                Models.Geofence geofence)
            => CoreHelper.RunTask(DownloadMapDataMessageAsync(vendorId, geofence));

        /// <summary>
        /// This endpoint allows user to download SAE J2735 MAP messages in ASN.1 UPER format. The area for the MAP messages is needed to be defined in the query.
        /// </summary>
        /// <param name="vendorId">Required parameter: The VendorID set during the Vendor registration call..</param>
        /// <param name="geofence">Required parameter: The area where the user wants to receive MAP data from..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of string response from the API call.</returns>
        public async Task<ApiResponse<string>> DownloadMapDataMessageAsync(
                string vendorId,
                Models.Geofence geofence,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<string>()
              .Server(Server.ImpServer)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api/v2/mapdata")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("SessionToken")
                  )
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("VendorID", vendorId).Required())
                      .Query(_query => _query.Setup("Geofence", geofence).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid request", (_reason, _context) => new MapDataResponseErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new MapDataResponseErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden Request", (_reason, _context) => new MapDataResponseErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Requests", (_reason, _context) => new MapDataResponseErrorException(_reason, _context)))
                  .ErrorCase("503", CreateErrorCase("Internal server Error", (_reason, _context) => new MapDataResponseErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected Error", (_reason, _context) => new MapDataResponseErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}