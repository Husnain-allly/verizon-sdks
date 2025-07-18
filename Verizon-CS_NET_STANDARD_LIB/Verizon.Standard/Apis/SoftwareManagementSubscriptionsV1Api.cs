// <copyright file="SoftwareManagementSubscriptionsV1Api.cs" company="APIMatic">
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
    /// SoftwareManagementSubscriptionsV1Api.
    /// </summary>
    public class SoftwareManagementSubscriptionsV1Api : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoftwareManagementSubscriptionsV1Api"/> class.
        /// </summary>
        internal SoftwareManagementSubscriptionsV1Api(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This subscriptions endpoint retrieves an account's current Software Management Service subscription status.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <returns>Returns the ApiResponse of Models.V1AccountSubscription response from the API call.</returns>
        public ApiResponse<Models.V1AccountSubscription> GetAccountSubscriptionStatus(
                string account)
            => CoreHelper.RunTask(GetAccountSubscriptionStatusAsync(account));

        /// <summary>
        /// This subscriptions endpoint retrieves an account's current Software Management Service subscription status.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V1AccountSubscription response from the API call.</returns>
        public async Task<ApiResponse<Models.V1AccountSubscription>> GetAccountSubscriptionStatusAsync(
                string account,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1AccountSubscription>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{account}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns information about an account's Software Management Services licenses and a list of licensed devices.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="startIndex">Required parameter: The zero-based number of the first record to return. Set startIndex=0 for the first request. If there are more than 1,000 devices in the response, set startIndex=1000 for the second request, 2000 for the third request, etc..</param>
        /// <returns>Returns the ApiResponse of Models.AccountLicenseInfo response from the API call.</returns>
        public ApiResponse<Models.AccountLicenseInfo> GetAccountLicenseStatus(
                string account,
                string startIndex)
            => CoreHelper.RunTask(GetAccountLicenseStatusAsync(account, startIndex));

        /// <summary>
        /// Returns information about an account's Software Management Services licenses and a list of licensed devices.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="startIndex">Required parameter: The zero-based number of the first record to return. Set startIndex=0 for the first request. If there are more than 1,000 devices in the response, set startIndex=1000 for the second request, 2000 for the third request, etc..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AccountLicenseInfo response from the API call.</returns>
        public async Task<ApiResponse<Models.AccountLicenseInfo>> GetAccountLicenseStatusAsync(
                string account,
                string startIndex,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountLicenseInfo>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/licenses/{account}/index/{startIndex}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account).Required())
                      .Template(_template => _template.Setup("startIndex", startIndex).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}