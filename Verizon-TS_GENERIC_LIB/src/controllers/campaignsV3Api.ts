/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { ApiResponse, RequestOptions } from '../core';
import { Campaign, campaignSchema } from '../models/campaign';
import {
  CampaignFirmwareUpgrade,
  campaignFirmwareUpgradeSchema,
} from '../models/campaignFirmwareUpgrade';
import {
  FirmwareCampaign,
  firmwareCampaignSchema,
} from '../models/firmwareCampaign';
import {
  FotaV3SuccessResult,
  fotaV3SuccessResultSchema,
} from '../models/fotaV3SuccessResult';
import {
  V3AddOrRemoveDeviceRequest,
  v3AddOrRemoveDeviceRequestSchema,
} from '../models/v3AddOrRemoveDeviceRequest';
import {
  V3AddOrRemoveDeviceResult,
  v3AddOrRemoveDeviceResultSchema,
} from '../models/v3AddOrRemoveDeviceResult';
import {
  V3ChangeCampaignDatesRequest,
  v3ChangeCampaignDatesRequestSchema,
} from '../models/v3ChangeCampaignDatesRequest';
import { string } from '../schema';
import { BaseApi } from './baseApi';
import { FotaV3ResultError } from '../errors/fotaV3ResultError';

export class CampaignsV3Api extends BaseApi {
  /**
   * This endpoint allows a user to schedule a firmware upgrade for a list of devices.
   *
   * @param accountName  Account identifier.
   * @param body         Firmware upgrade information.
   * @return Response from the API call
   */
  async scheduleCampaignFirmwareUpgrade(
    accountName: string,
    body: CampaignFirmwareUpgrade,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<FirmwareCampaign>> {
    const req = this.createRequest('POST');
    req.baseUrl('Software Management V3');
    const mapped = req.prepareArgs({
      accountName: [accountName, string()],
      body: [body, campaignFirmwareUpgradeSchema],
    });
    req.header('Content-Type', 'application/json');
    req.json(mapped.body);
    req.appendTemplatePath`/campaigns/firmware/${mapped.accountName}`;
    req.throwOn(400, FotaV3ResultError, 'Unexpected error.');
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(firmwareCampaignSchema, requestOptions);
  }

  /**
   * This endpoint allows user to Add or Remove devices to an existing campaign.
   *
   * @param acc          Account identifier.
   * @param campaignId   Unique identifier of a campaign.
   * @param body         Add or remove device to existing upgrade information.
   * @return Response from the API call
   */
  async updateCampaignFirmwareDevices(
    acc: string,
    campaignId: string,
    body: V3AddOrRemoveDeviceRequest,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<V3AddOrRemoveDeviceResult>> {
    const req = this.createRequest('PUT');
    req.baseUrl('Software Management V3');
    const mapped = req.prepareArgs({
      acc: [acc, string()],
      campaignId: [campaignId, string()],
      body: [body, v3AddOrRemoveDeviceRequestSchema],
    });
    req.header('Content-Type', 'application/json');
    req.json(mapped.body);
    req.appendTemplatePath`/campaigns/firmware/${mapped.acc}/${mapped.campaignId}`;
    req.throwOn(400, FotaV3ResultError, 'Unexpected error.');
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(v3AddOrRemoveDeviceResultSchema, requestOptions);
  }

  /**
   * This endpoint allows user to change campaign dates and time windows. Fields which need to remain
   * unchanged should be also provided.
   *
   * @param acc          Account identifier.
   * @param campaignId   Firmware upgrade information.
   * @param body         New dates and time windows.
   * @return Response from the API call
   */
  async updateCampaignDates(
    acc: string,
    campaignId: string,
    body: V3ChangeCampaignDatesRequest,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<FirmwareCampaign>> {
    const req = this.createRequest('PUT');
    req.baseUrl('Software Management V3');
    const mapped = req.prepareArgs({
      acc: [acc, string()],
      campaignId: [campaignId, string()],
      body: [body, v3ChangeCampaignDatesRequestSchema],
    });
    req.header('Content-Type', 'application/json');
    req.json(mapped.body);
    req.appendTemplatePath`/campaigns/firmware/${mapped.acc}/${mapped.campaignId}/dates`;
    req.throwOn(400, FotaV3ResultError, 'Unexpected error.');
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(firmwareCampaignSchema, requestOptions);
  }

  /**
   * This endpoint allows the user to retrieve campaign level information for a specified campaign.
   *
   * @param accountName Account identifier.
   * @param campaignId  Firmware upgrade identifier.
   * @return Response from the API call
   */
  async getCampaignInformation(
    accountName: string,
    campaignId: string,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<Campaign>> {
    const req = this.createRequest('GET');
    req.baseUrl('Software Management V3');
    const mapped = req.prepareArgs({
      accountName: [accountName, string()],
      campaignId: [campaignId, string()],
    });
    req.appendTemplatePath`/campaigns/${mapped.accountName}/${mapped.campaignId}`;
    req.throwOn(400, FotaV3ResultError, 'Unexpected error.');
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(campaignSchema, requestOptions);
  }

  /**
   * This endpoint allows user to cancel a firmware campaign. A firmware campaign already started can not
   * be cancelled.
   *
   * @param accountName Account identifier.
   * @param campaignId  Firmware upgrade information.
   * @return Response from the API call
   */
  async cancelCampaign(
    accountName: string,
    campaignId: string,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<FotaV3SuccessResult>> {
    const req = this.createRequest('DELETE');
    req.baseUrl('Software Management V3');
    const mapped = req.prepareArgs({
      accountName: [accountName, string()],
      campaignId: [campaignId, string()],
    });
    req.appendTemplatePath`/campaigns/${mapped.accountName}/${mapped.campaignId}`;
    req.throwOn(400, FotaV3ResultError, 'Unexpected error.');
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(fotaV3SuccessResultSchema, requestOptions);
  }
}
