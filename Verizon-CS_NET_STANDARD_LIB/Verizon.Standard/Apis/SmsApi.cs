// <copyright file="SmsApi.cs" company="APIMatic">
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
    /// SmsApi.
    /// </summary>
    public class SmsApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsApi"/> class.
        /// </summary>
        internal SmsApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// The messages are queued on the ThingSpace Platform and sent as soon as possible, but they may be delayed due to traffic and routing considerations.
        /// </summary>
        /// <param name="body">Required parameter: Request to send SMS..</param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public ApiResponse<Models.DeviceManagementResult> SendSmsToDevice(
                Models.SmsSendRequest body)
            => CoreHelper.RunTask(SendSmsToDeviceAsync(body));

        /// <summary>
        /// The messages are queued on the ThingSpace Platform and sent as soon as possible, but they may be delayed due to traffic and routing considerations.
        /// </summary>
        /// <param name="body">Required parameter: Request to send SMS..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceManagementResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceManagementResult>> SendSmsToDeviceAsync(
                Models.SmsSendRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceManagementResult>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/sms")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// When HTTP status is 202, a URL will be returned in the Location header of the form /sms/{aname}/history?next={token}. This URL can be used to request the next set of messages.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="next">Optional parameter: Continue the previous query from the URL in Location Header..</param>
        /// <returns>Returns the ApiResponse of Models.SmsMessagesQueryResult response from the API call.</returns>
        public ApiResponse<Models.SmsMessagesQueryResult> ListDevicesSmsMessages(
                string aname,
                long? next = null)
            => CoreHelper.RunTask(ListDevicesSmsMessagesAsync(aname, next));

        /// <summary>
        /// When HTTP status is 202, a URL will be returned in the Location header of the form /sms/{aname}/history?next={token}. This URL can be used to request the next set of messages.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="next">Optional parameter: Continue the previous query from the URL in Location Header..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.SmsMessagesQueryResult response from the API call.</returns>
        public async Task<ApiResponse<Models.SmsMessagesQueryResult>> ListDevicesSmsMessagesAsync(
                string aname,
                long? next = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SmsMessagesQueryResult>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/sms/{aname}/history")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname).Required())
                      .Query(_query => _query.Setup("next", next))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Tells the ThingSpace Platform to start sending mobile-originated SMS messages through the EnhancedConnectivityService callback service. SMS messages from devices are queued until they are retrieved by your application, either by callback or synchronously with GET /sms/{accountName}/history.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <returns>Returns the ApiResponse of Models.ConnectivityManagementSuccessResult response from the API call.</returns>
        public ApiResponse<Models.ConnectivityManagementSuccessResult> StartQueuedSmsDelivery(
                string aname)
            => CoreHelper.RunTask(StartQueuedSmsDeliveryAsync(aname));

        /// <summary>
        /// Tells the ThingSpace Platform to start sending mobile-originated SMS messages through the EnhancedConnectivityService callback service. SMS messages from devices are queued until they are retrieved by your application, either by callback or synchronously with GET /sms/{accountName}/history.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ConnectivityManagementSuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.ConnectivityManagementSuccessResult>> StartQueuedSmsDeliveryAsync(
                string aname,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ConnectivityManagementSuccessResult>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/m2m/v1/sms/{aname}/startCallbacks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}