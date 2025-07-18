// <copyright file="FirmwareV1Api.cs" company="APIMatic">
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
    /// FirmwareV1Api.
    /// </summary>
    public class FirmwareV1Api : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareV1Api"/> class.
        /// </summary>
        internal FirmwareV1Api(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Lists all device firmware images available for an account, based on the devices registered to that account.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <returns>Returns the ApiResponse of List of Models.Firmware response from the API call.</returns>
        public ApiResponse<List<Models.Firmware>> ListAvailableFirmware(
                string account)
            => CoreHelper.RunTask(ListAvailableFirmwareAsync(account));

        /// <summary>
        /// Lists all device firmware images available for an account, based on the devices registered to that account.
        /// </summary>
        /// <param name="account">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List of Models.Firmware response from the API call.</returns>
        public async Task<ApiResponse<List<Models.Firmware>>> ListAvailableFirmwareAsync(
                string account,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.Firmware>>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/firmware/{account}")
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
        /// Schedules a firmware upgrade for devices.
        /// </summary>
        /// <param name="body">Required parameter: Details of the firmware upgrade request..</param>
        /// <returns>Returns the ApiResponse of Models.FirmwareUpgrade response from the API call.</returns>
        public ApiResponse<Models.FirmwareUpgrade> ScheduleFirmwareUpgrade(
                Models.FirmwareUpgradeRequest body)
            => CoreHelper.RunTask(ScheduleFirmwareUpgradeAsync(body));

        /// <summary>
        /// Schedules a firmware upgrade for devices.
        /// </summary>
        /// <param name="body">Required parameter: Details of the firmware upgrade request..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FirmwareUpgrade response from the API call.</returns>
        public async Task<ApiResponse<Models.FirmwareUpgrade>> ScheduleFirmwareUpgradeAsync(
                Models.FirmwareUpgradeRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FirmwareUpgrade>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/upgrades")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns information about a specified upgrade, include the target date of the upgrade, the list of devices in the upgrade, and the status of the upgrade for each device.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="upgradeId">Required parameter: The UUID of the upgrade, returned by POST /upgrades when the upgrade was scheduled..</param>
        /// <returns>Returns the ApiResponse of Models.FirmwareUpgrade response from the API call.</returns>
        public ApiResponse<Models.FirmwareUpgrade> ListFirmwareUpgradeDetails(
                string accountName,
                string upgradeId)
            => CoreHelper.RunTask(ListFirmwareUpgradeDetailsAsync(accountName, upgradeId));

        /// <summary>
        /// Returns information about a specified upgrade, include the target date of the upgrade, the list of devices in the upgrade, and the status of the upgrade for each device.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="upgradeId">Required parameter: The UUID of the upgrade, returned by POST /upgrades when the upgrade was scheduled..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FirmwareUpgrade response from the API call.</returns>
        public async Task<ApiResponse<Models.FirmwareUpgrade>> ListFirmwareUpgradeDetailsAsync(
                string accountName,
                string upgradeId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FirmwareUpgrade>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/upgrades/{accountName}/upgrade/{upgradeId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName).Required())
                      .Template(_template => _template.Setup("upgradeId", upgradeId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Add or remove devices from a scheduled upgrade.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="upgradeId">Required parameter: The UUID of the upgrade, returned by POST /upgrades when the upgrade was scheduled..</param>
        /// <param name="body">Required parameter: List of devices to add or remove..</param>
        /// <returns>Returns the ApiResponse of Models.FirmwareUpgradeChangeResult response from the API call.</returns>
        public ApiResponse<Models.FirmwareUpgradeChangeResult> UpdateFirmwareUpgradeDevices(
                string accountName,
                string upgradeId,
                Models.FirmwareUpgradeChangeRequest body)
            => CoreHelper.RunTask(UpdateFirmwareUpgradeDevicesAsync(accountName, upgradeId, body));

        /// <summary>
        /// Add or remove devices from a scheduled upgrade.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="upgradeId">Required parameter: The UUID of the upgrade, returned by POST /upgrades when the upgrade was scheduled..</param>
        /// <param name="body">Required parameter: List of devices to add or remove..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FirmwareUpgradeChangeResult response from the API call.</returns>
        public async Task<ApiResponse<Models.FirmwareUpgradeChangeResult>> UpdateFirmwareUpgradeDevicesAsync(
                string accountName,
                string upgradeId,
                Models.FirmwareUpgradeChangeRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FirmwareUpgradeChangeResult>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/upgrades/{accountName}/upgrade/{upgradeId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Template(_template => _template.Setup("accountName", accountName).Required())
                      .Template(_template => _template.Setup("upgradeId", upgradeId).Required())
                      .Header(_header => _header.Setup("Content-Type", "*/*"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Cancel a scheduled firmware upgrade.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="upgradeId">Required parameter: The UUID of the scheduled upgrade that you want to cancel..</param>
        /// <returns>Returns the ApiResponse of Models.FotaV1SuccessResult response from the API call.</returns>
        public ApiResponse<Models.FotaV1SuccessResult> CancelScheduledFirmwareUpgrade(
                string accountName,
                string upgradeId)
            => CoreHelper.RunTask(CancelScheduledFirmwareUpgradeAsync(accountName, upgradeId));

        /// <summary>
        /// Cancel a scheduled firmware upgrade.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier in "##########-#####"..</param>
        /// <param name="upgradeId">Required parameter: The UUID of the scheduled upgrade that you want to cancel..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FotaV1SuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.FotaV1SuccessResult>> CancelScheduledFirmwareUpgradeAsync(
                string accountName,
                string upgradeId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FotaV1SuccessResult>()
              .Server(Server.SoftwareManagementV1)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/upgrades/{accountName}/upgrade/{upgradeId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName).Required())
                      .Template(_template => _template.Setup("upgradeId", upgradeId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV1ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}