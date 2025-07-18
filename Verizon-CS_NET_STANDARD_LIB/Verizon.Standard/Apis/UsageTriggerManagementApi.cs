// <copyright file="UsageTriggerManagementApi.cs" company="APIMatic">
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
    /// UsageTriggerManagementApi.
    /// </summary>
    public class UsageTriggerManagementApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTriggerManagementApi"/> class.
        /// </summary>
        internal UsageTriggerManagementApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Create a new usage trigger, which will send an alert when the number of device location service transactions reaches a specified percentage of the monthly subscription amount.
        /// </summary>
        /// <param name="body">Optional parameter: License assignment..</param>
        /// <returns>Returns the ApiResponse of Models.UsageTriggerResponse response from the API call.</returns>
        public ApiResponse<Models.UsageTriggerResponse> CreateNewTrigger(
                Models.UsageTriggerAddRequest body = null)
            => CoreHelper.RunTask(CreateNewTriggerAsync(body));

        /// <summary>
        /// Create a new usage trigger, which will send an alert when the number of device location service transactions reaches a specified percentage of the monthly subscription amount.
        /// </summary>
        /// <param name="body">Optional parameter: License assignment..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.UsageTriggerResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.UsageTriggerResponse>> CreateNewTriggerAsync(
                Models.UsageTriggerAddRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UsageTriggerResponse>()
              .Server(Server.SubscriptionServer)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/usage/triggers")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Update an existing usage trigger.
        /// </summary>
        /// <param name="triggerId">Required parameter: Usage trigger ID.</param>
        /// <param name="body">Optional parameter: New trigger values.</param>
        /// <returns>Returns the ApiResponse of Models.UsageTriggerResponse response from the API call.</returns>
        public ApiResponse<Models.UsageTriggerResponse> UpdateTrigger(
                string triggerId,
                Models.UsageTriggerUpdateRequest body = null)
            => CoreHelper.RunTask(UpdateTriggerAsync(triggerId, body));

        /// <summary>
        /// Update an existing usage trigger.
        /// </summary>
        /// <param name="triggerId">Required parameter: Usage trigger ID.</param>
        /// <param name="body">Optional parameter: New trigger values.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.UsageTriggerResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.UsageTriggerResponse>> UpdateTriggerAsync(
                string triggerId,
                Models.UsageTriggerUpdateRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UsageTriggerResponse>()
              .Server(Server.SubscriptionServer)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/usage/triggers/{triggerId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("triggerId", triggerId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// eletes the specified usage trigger from the given account.
        /// </summary>
        /// <param name="accountName">Required parameter: Account name.</param>
        /// <param name="triggerId">Required parameter: Usage trigger ID.</param>
        /// <returns>Returns the ApiResponse of Models.DeviceLocationSuccessResult response from the API call.</returns>
        public ApiResponse<Models.DeviceLocationSuccessResult> DeleteTrigger(
                string accountName,
                string triggerId)
            => CoreHelper.RunTask(DeleteTriggerAsync(accountName, triggerId));

        /// <summary>
        /// eletes the specified usage trigger from the given account.
        /// </summary>
        /// <param name="accountName">Required parameter: Account name.</param>
        /// <param name="triggerId">Required parameter: Usage trigger ID.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DeviceLocationSuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.DeviceLocationSuccessResult>> DeleteTriggerAsync(
                string accountName,
                string triggerId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DeviceLocationSuccessResult>()
              .Server(Server.SubscriptionServer)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/usage/accounts/{accountName}/triggers/{triggerId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName).Required())
                      .Template(_template => _template.Setup("triggerId", triggerId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}