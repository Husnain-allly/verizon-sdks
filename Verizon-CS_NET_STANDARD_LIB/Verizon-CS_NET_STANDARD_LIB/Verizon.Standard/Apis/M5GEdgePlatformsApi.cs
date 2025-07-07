// <copyright file="M5GEdgePlatformsApi.cs" company="APIMatic">
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
    /// M5GEdgePlatformsApi.
    /// </summary>
    public class M5GEdgePlatformsApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="M5GEdgePlatformsApi"/> class.
        /// </summary>
        internal M5GEdgePlatformsApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns a list of optimal MEC Platforms where you can register your deployed application. **Note:** If a query is sent with all of the parameters, it will fail with a "400" error. You can search based on the following parameter combinations - region plus Service Profile ID and subscriber density (density is optional but recommended), region plus UEIdentity(Including UEIdentity Type) or Service Profile ID plus UEIdentity(Including UEIdentity Type).
        /// </summary>
        /// <param name="region">Optional parameter: MEC region name. Current valid values are US_WEST_2 and US_EAST_1..</param>
        /// <param name="serviceProfileId">Optional parameter: Unique identifier of the service profile..</param>
        /// <param name="subscriberDensity">Optional parameter: Minimum number of 4G/5G subscribers per square kilometer..</param>
        /// <param name="ueIdentityType">Optional parameter: Type of User Equipment identifier used in `UEIdentity`..</param>
        /// <param name="ueIdentity">Optional parameter: The identifier value for User Equipment. The type of identifier is defined by the 'UEIdentityType' parameter. The`IPAddress`format can be IPv4 or IPv6..</param>
        /// <returns>Returns the ApiResponse of Models.ListMecPlatformsResult response from the API call.</returns>
        public ApiResponse<Models.ListMecPlatformsResult> ListMecPlatforms(
                string region = null,
                string serviceProfileId = null,
                int? subscriberDensity = null,
                Models.UserEquipmentIdentityType? ueIdentityType = null,
                string ueIdentity = null)
            => CoreHelper.RunTask(ListMecPlatformsAsync(region, serviceProfileId, subscriberDensity, ueIdentityType, ueIdentity));

        /// <summary>
        /// Returns a list of optimal MEC Platforms where you can register your deployed application. **Note:** If a query is sent with all of the parameters, it will fail with a "400" error. You can search based on the following parameter combinations - region plus Service Profile ID and subscriber density (density is optional but recommended), region plus UEIdentity(Including UEIdentity Type) or Service Profile ID plus UEIdentity(Including UEIdentity Type).
        /// </summary>
        /// <param name="region">Optional parameter: MEC region name. Current valid values are US_WEST_2 and US_EAST_1..</param>
        /// <param name="serviceProfileId">Optional parameter: Unique identifier of the service profile..</param>
        /// <param name="subscriberDensity">Optional parameter: Minimum number of 4G/5G subscribers per square kilometer..</param>
        /// <param name="ueIdentityType">Optional parameter: Type of User Equipment identifier used in `UEIdentity`..</param>
        /// <param name="ueIdentity">Optional parameter: The identifier value for User Equipment. The type of identifier is defined by the 'UEIdentityType' parameter. The`IPAddress`format can be IPv4 or IPv6..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ListMecPlatformsResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ListMecPlatformsResult>> ListMecPlatformsAsync(
                string region = null,
                string serviceProfileId = null,
                int? subscriberDensity = null,
                Models.UserEquipmentIdentityType? ueIdentityType = null,
                string ueIdentity = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListMecPlatformsResult>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/mecplatforms")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("region", region))
                      .Query(_query => _query.Setup("serviceProfileId", serviceProfileId))
                      .Query(_query => _query.Setup("subscriberDensity", subscriberDensity))
                      .Query(_query => _query.Setup("UEIdentityType", (ueIdentityType.HasValue) ? ApiHelper.JsonSerialize(ueIdentityType.Value).Trim('\"') : null))
                      .Query(_query => _query.Setup("UEIdentity", ueIdentity))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("HTTP 500 Internal Server Error.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// List the geographical regions available, based on the user's bearer token. **Note:** Country code, Metropolitan area, Area and Zone are future functionality and will currently return a "null" value.
        /// </summary>
        /// <returns>Returns the ApiResponse of Models.ListRegionsResult response from the API call.</returns>
        public ApiResponse<Models.ListRegionsResult> ListRegions()
            => CoreHelper.RunTask(ListRegionsAsync());

        /// <summary>
        /// List the geographical regions available, based on the user's bearer token. **Note:** Country code, Metropolitan area, Area and Zone are future functionality and will currently return a "null" value.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ListRegionsResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ListRegionsResult>> ListRegionsAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListRegionsResult>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/regions")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  ))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("HTTP 400 Bad Request.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("HTTP 401 Unauthorized.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("HTTP 500 Internal Server Error.", (_reason, _context) => new EdgeDiscoveryResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}