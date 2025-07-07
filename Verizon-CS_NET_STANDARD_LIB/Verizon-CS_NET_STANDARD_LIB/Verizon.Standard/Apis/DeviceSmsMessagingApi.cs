// <copyright file="DeviceSmsMessagingApi.cs" company="APIMatic">
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
    /// DeviceSmsMessagingApi.
    /// </summary>
    public class DeviceSmsMessagingApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceSmsMessagingApi"/> class.
        /// </summary>
        internal DeviceSmsMessagingApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Sends an SMS message to one device. Messages are queued on the M2M MC Platform and sent as soon as possible, but they may be delayed due to traffic and routing considerations.
        /// </summary>
        /// <param name="body">Required parameter: SMS message to an indiividual device..</param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public ApiResponse<Models.GioRequestResponse> SendAnSmsMessage(
                Models.GiosmsSendRequest body)
            => CoreHelper.RunTask(SendAnSmsMessageAsync(body));

        /// <summary>
        /// Sends an SMS message to one device. Messages are queued on the M2M MC Platform and sent as soon as possible, but they may be delayed due to traffic and routing considerations.
        /// </summary>
        /// <param name="body">Required parameter: SMS message to an indiividual device..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GioRequestResponse>> SendAnSmsMessageAsync(
                Models.GiosmsSendRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GioRequestResponse>()
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
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GioRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Retrieves queued SMS messages sent by all M2M MC devices associated with an account.
        /// </summary>
        /// <param name="accountName">Required parameter: Numeric account name.</param>
        /// <param name="next">Optional parameter: Continue the previous query from the pageUrl in Location Header.</param>
        /// <returns>Returns the ApiResponse of Models.SmsMessagesResponse response from the API call.</returns>
        public ApiResponse<Models.SmsMessagesResponse> GetSmsMessages(
                string accountName,
                string next = null)
            => CoreHelper.RunTask(GetSmsMessagesAsync(accountName, next));

        /// <summary>
        /// Retrieves queued SMS messages sent by all M2M MC devices associated with an account.
        /// </summary>
        /// <param name="accountName">Required parameter: Numeric account name.</param>
        /// <param name="next">Optional parameter: Continue the previous query from the pageUrl in Location Header.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.SmsMessagesResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.SmsMessagesResponse>> GetSmsMessagesAsync(
                string accountName,
                string next = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SmsMessagesResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/sms/{accountName}/history")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName).Required())
                      .Query(_query => _query.Setup("next", next))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GioRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Starts delivery of SMS messages for the specified account.
        /// </summary>
        /// <param name="accountName">Required parameter: Numeric account name.</param>
        /// <returns>Returns the ApiResponse of Models.SuccessResponse response from the API call.</returns>
        public ApiResponse<Models.SuccessResponse> StartSmsMessageDelivery(
                string accountName)
            => CoreHelper.RunTask(StartSmsMessageDeliveryAsync(accountName));

        /// <summary>
        /// Starts delivery of SMS messages for the specified account.
        /// </summary>
        /// <param name="accountName">Required parameter: Numeric account name.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.SuccessResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.SuccessResponse>> StartSmsMessageDeliveryAsync(
                string accountName,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SuccessResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/m2m/v1/sms/{accountName}/startCallbacks")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GioRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a list of sms history for a given device during a specified time frame.
        /// </summary>
        /// <param name="body">Required parameter: Device Query.</param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public ApiResponse<Models.GioRequestResponse> ListSmsMessageHistory(
                Models.SmsEventHistoryRequest body)
            => CoreHelper.RunTask(ListSmsMessageHistoryAsync(body));

        /// <summary>
        /// Returns a list of sms history for a given device during a specified time frame.
        /// </summary>
        /// <param name="body">Required parameter: Device Query.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.GioRequestResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.GioRequestResponse>> ListSmsMessageHistoryAsync(
                Models.SmsEventHistoryRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GioRequestResponse>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/m2m/v1/devices/sms/history/actions/list")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response", (_reason, _context) => new GioRestErrorResponseException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}