// <copyright file="SoftwareManagementSubscriptionsV3Api.cs" company="APIMatic">
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
    /// SoftwareManagementSubscriptionsV3Api.
    /// </summary>
    public class SoftwareManagementSubscriptionsV3Api : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoftwareManagementSubscriptionsV3Api"/> class.
        /// </summary>
        internal SoftwareManagementSubscriptionsV3Api(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint retrieves a FOTA subscription by account.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <returns>Returns the ApiResponse of Models.FotaV3Subscription response from the API call.</returns>
        public ApiResponse<Models.FotaV3Subscription> GetAccountSubscriptionStatus(
                string acc)
            => CoreHelper.RunTask(GetAccountSubscriptionStatusAsync(acc));

        /// <summary>
        /// This endpoint retrieves a FOTA subscription by account.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FotaV3Subscription response from the API call.</returns>
        public async Task<ApiResponse<Models.FotaV3Subscription>> GetAccountSubscriptionStatusAsync(
                string acc,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FotaV3Subscription>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/subscriptions/{acc}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("acc", acc).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}