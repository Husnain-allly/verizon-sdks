// <copyright file="ThingSpaceQualityOfServiceApiActionsApi.cs" company="APIMatic">
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
    /// ThingSpaceQualityOfServiceApiActionsApi.
    /// </summary>
    public class ThingSpaceQualityOfServiceApiActionsApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThingSpaceQualityOfServiceApiActionsApi"/> class.
        /// </summary>
        internal ThingSpaceQualityOfServiceApiActionsApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Creates a QoS elevation subscription ID and activates the subscription.
        /// </summary>
        /// <param name="body">Required parameter: The request details to create a ThingSpace Quality of Service API subscription..</param>
        /// <returns>Returns the ApiResponse of Models.M201Success response from the API call.</returns>
        public ApiResponse<Models.M201Success> CreateAThingSpaceQualityOfServiceApiSubscription(
                Models.SubscribeRequest body)
            => CoreHelper.RunTask(CreateAThingSpaceQualityOfServiceApiSubscriptionAsync(body));

        /// <summary>
        /// Creates a QoS elevation subscription ID and activates the subscription.
        /// </summary>
        /// <param name="body">Required parameter: The request details to create a ThingSpace Quality of Service API subscription..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.M201Success response from the API call.</returns>
        public async Task<ApiResponse<Models.M201Success>> CreateAThingSpaceQualityOfServiceApiSubscriptionAsync(
                Models.SubscribeRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.M201Success>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/actions/enhanceQoS")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error Response", (_reason, _context) => new DefaultResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Stops an active ThingSpace Quality of Service API subscription using the account name and the subscription ID.
        /// </summary>
        /// <param name="accountName">Required parameter: .</param>
        /// <param name="qosSubscriptionId">Required parameter: .</param>
        /// <returns>Returns the ApiResponse of Models.M201Success response from the API call.</returns>
        public ApiResponse<Models.M201Success> StopAThingSpaceQualityOfServiceApiSubscription(
                string accountName,
                string qosSubscriptionId)
            => CoreHelper.RunTask(StopAThingSpaceQualityOfServiceApiSubscriptionAsync(accountName, qosSubscriptionId));

        /// <summary>
        /// Stops an active ThingSpace Quality of Service API subscription using the account name and the subscription ID.
        /// </summary>
        /// <param name="accountName">Required parameter: .</param>
        /// <param name="qosSubscriptionId">Required parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.M201Success response from the API call.</returns>
        public async Task<ApiResponse<Models.M201Success>> StopAThingSpaceQualityOfServiceApiSubscriptionAsync(
                string accountName,
                string qosSubscriptionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.M201Success>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/m2m/v1/devices/actions/enhanceQoS")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("accountName", accountName).Required())
                      .Query(_query => _query.Setup("qosSubscriptionId", qosSubscriptionId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error Response", (_reason, _context) => new DefaultResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}