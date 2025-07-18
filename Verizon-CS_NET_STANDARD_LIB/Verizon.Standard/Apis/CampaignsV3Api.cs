// <copyright file="CampaignsV3Api.cs" company="APIMatic">
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
    /// CampaignsV3Api.
    /// </summary>
    public class CampaignsV3Api : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignsV3Api"/> class.
        /// </summary>
        internal CampaignsV3Api(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint allows a user to schedule a firmware upgrade for a list of devices.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: Firmware upgrade information..</param>
        /// <returns>Returns the ApiResponse of Models.FirmwareCampaign response from the API call.</returns>
        public ApiResponse<Models.FirmwareCampaign> ScheduleCampaignFirmwareUpgrade(
                string accountName,
                Models.CampaignFirmwareUpgrade body)
            => CoreHelper.RunTask(ScheduleCampaignFirmwareUpgradeAsync(accountName, body));

        /// <summary>
        /// This endpoint allows a user to schedule a firmware upgrade for a list of devices.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier..</param>
        /// <param name="body">Required parameter: Firmware upgrade information..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FirmwareCampaign response from the API call.</returns>
        public async Task<ApiResponse<Models.FirmwareCampaign>> ScheduleCampaignFirmwareUpgradeAsync(
                string accountName,
                Models.CampaignFirmwareUpgrade body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FirmwareCampaign>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/campaigns/firmware/{accountName}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Template(_template => _template.Setup("accountName", accountName).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user to Add or Remove devices to an existing campaign.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="campaignId">Required parameter: Unique identifier of a campaign..</param>
        /// <param name="body">Required parameter: Add or remove device to existing upgrade information..</param>
        /// <returns>Returns the ApiResponse of Models.V3AddOrRemoveDeviceResult response from the API call.</returns>
        public ApiResponse<Models.V3AddOrRemoveDeviceResult> UpdateCampaignFirmwareDevices(
                string acc,
                string campaignId,
                Models.V3AddOrRemoveDeviceRequest body)
            => CoreHelper.RunTask(UpdateCampaignFirmwareDevicesAsync(acc, campaignId, body));

        /// <summary>
        /// This endpoint allows user to Add or Remove devices to an existing campaign.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="campaignId">Required parameter: Unique identifier of a campaign..</param>
        /// <param name="body">Required parameter: Add or remove device to existing upgrade information..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.V3AddOrRemoveDeviceResult response from the API call.</returns>
        public async Task<ApiResponse<Models.V3AddOrRemoveDeviceResult>> UpdateCampaignFirmwareDevicesAsync(
                string acc,
                string campaignId,
                Models.V3AddOrRemoveDeviceRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V3AddOrRemoveDeviceResult>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/campaigns/firmware/{acc}/{campaignId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Template(_template => _template.Setup("acc", acc).Required())
                      .Template(_template => _template.Setup("campaignId", campaignId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user to change campaign dates and time windows. Fields which need to remain unchanged should be also provided.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="campaignId">Required parameter: Firmware upgrade information..</param>
        /// <param name="body">Required parameter: New dates and time windows..</param>
        /// <returns>Returns the ApiResponse of Models.FirmwareCampaign response from the API call.</returns>
        public ApiResponse<Models.FirmwareCampaign> UpdateCampaignDates(
                string acc,
                string campaignId,
                Models.V3ChangeCampaignDatesRequest body)
            => CoreHelper.RunTask(UpdateCampaignDatesAsync(acc, campaignId, body));

        /// <summary>
        /// This endpoint allows user to change campaign dates and time windows. Fields which need to remain unchanged should be also provided.
        /// </summary>
        /// <param name="acc">Required parameter: Account identifier..</param>
        /// <param name="campaignId">Required parameter: Firmware upgrade information..</param>
        /// <param name="body">Required parameter: New dates and time windows..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FirmwareCampaign response from the API call.</returns>
        public async Task<ApiResponse<Models.FirmwareCampaign>> UpdateCampaignDatesAsync(
                string acc,
                string campaignId,
                Models.V3ChangeCampaignDatesRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FirmwareCampaign>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/campaigns/firmware/{acc}/{campaignId}/dates")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Template(_template => _template.Setup("acc", acc).Required())
                      .Template(_template => _template.Setup("campaignId", campaignId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows the user to retrieve campaign level information for a specified campaign.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier..</param>
        /// <param name="campaignId">Required parameter: Firmware upgrade identifier..</param>
        /// <returns>Returns the ApiResponse of Models.Campaign response from the API call.</returns>
        public ApiResponse<Models.Campaign> GetCampaignInformation(
                string accountName,
                string campaignId)
            => CoreHelper.RunTask(GetCampaignInformationAsync(accountName, campaignId));

        /// <summary>
        /// This endpoint allows the user to retrieve campaign level information for a specified campaign.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier..</param>
        /// <param name="campaignId">Required parameter: Firmware upgrade identifier..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.Campaign response from the API call.</returns>
        public async Task<ApiResponse<Models.Campaign>> GetCampaignInformationAsync(
                string accountName,
                string campaignId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.Campaign>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/campaigns/{accountName}/{campaignId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName).Required())
                      .Template(_template => _template.Setup("campaignId", campaignId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user to cancel a firmware campaign. A firmware campaign already started can not be cancelled.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier..</param>
        /// <param name="campaignId">Required parameter: Firmware upgrade information..</param>
        /// <returns>Returns the ApiResponse of Models.FotaV3SuccessResult response from the API call.</returns>
        public ApiResponse<Models.FotaV3SuccessResult> CancelCampaign(
                string accountName,
                string campaignId)
            => CoreHelper.RunTask(CancelCampaignAsync(accountName, campaignId));

        /// <summary>
        /// This endpoint allows user to cancel a firmware campaign. A firmware campaign already started can not be cancelled.
        /// </summary>
        /// <param name="accountName">Required parameter: Account identifier..</param>
        /// <param name="campaignId">Required parameter: Firmware upgrade information..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.FotaV3SuccessResult response from the API call.</returns>
        public async Task<ApiResponse<Models.FotaV3SuccessResult>> CancelCampaignAsync(
                string accountName,
                string campaignId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FotaV3SuccessResult>()
              .Server(Server.SoftwareManagementV3)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/campaigns/{accountName}/{campaignId}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName).Required())
                      .Template(_template => _template.Setup("campaignId", campaignId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error.", (_reason, _context) => new FotaV3ResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}