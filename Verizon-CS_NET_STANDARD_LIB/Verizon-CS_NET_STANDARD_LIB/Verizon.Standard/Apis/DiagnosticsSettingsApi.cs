// <copyright file="DiagnosticsSettingsApi.cs" company="APIMatic">
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
    /// DiagnosticsSettingsApi.
    /// </summary>
    public class DiagnosticsSettingsApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsSettingsApi"/> class.
        /// </summary>
        internal DiagnosticsSettingsApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint retrieves diagnostics settings synchronously.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier..</param>
        /// <param name="devices">Required parameter: Devices list formatted as "id, kind".</param>
        /// <returns>Returns the ApiResponse of List of Models.DiagnosticObservationSetting response from the API call.</returns>
        public ApiResponse<List<Models.DiagnosticObservationSetting>> ListDiagnosticsSettings(
                string accountName,
                string devices)
            => CoreHelper.RunTask(ListDiagnosticsSettingsAsync(accountName, devices));

        /// <summary>
        /// This endpoint retrieves diagnostics settings synchronously.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier..</param>
        /// <param name="devices">Required parameter: Devices list formatted as "id, kind".</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List of Models.DiagnosticObservationSetting response from the API call.</returns>
        public async Task<ApiResponse<List<Models.DiagnosticObservationSetting>>> ListDiagnosticsSettingsAsync(
                string accountName,
                string devices,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.DiagnosticObservationSetting>>()
              .Server(Server.DeviceDiagnostics)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/devices/settings")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("accountName", accountName).Required())
                      .Query(_query => _query.Setup("devices", devices).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("Error response.", (_reason, _context) => new DeviceDiagnosticsResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}