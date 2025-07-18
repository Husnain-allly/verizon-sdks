// <copyright file="ServerLoggingApi.cs" company="APIMatic">
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
    /// ServerLoggingApi.
    /// </summary>
    public class ServerLoggingApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerLoggingApi"/> class.
        /// </summary>
        internal ServerLoggingApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Check-in history can be retrieved for any device belonging to the account, not necessarily with logging enabled.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="deviceId">Required parameter: Device IMEI identifier..</param>
        /// <returns>Returns the ApiResponse of List of Models.CheckInHistoryItem response from the API call.</returns>
        public ApiResponse<List<Models.CheckInHistoryItem>> GetDeviceCheckInHistory(
                string account,
                string deviceId)
            => CoreHelper.RunTask(GetDeviceCheckInHistoryAsync(account, deviceId));

        /// <summary>
        /// Check-in history can be retrieved for any device belonging to the account, not necessarily with logging enabled.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier..</param>
        /// <param name="deviceId">Required parameter: Device IMEI identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List of Models.CheckInHistoryItem response from the API call.</returns>
        public async Task<ApiResponse<List<Models.CheckInHistoryItem>>> GetDeviceCheckInHistoryAsync(
                string account,
                string deviceId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.CheckInHistoryItem>>()
              .Server(Server.SoftwareManagementV2)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/logging/{account}/devices/{deviceId}/checkInHistory")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("account", account).Required())
                      .Template(_template => _template.Setup("deviceId", deviceId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV2ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}