/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { ApiResponse, RequestOptions } from '../core';
import { Firmware, firmwareSchema } from '../models/firmware';
import {
  FirmwareUpgrade,
  firmwareUpgradeSchema,
} from '../models/firmwareUpgrade';
import {
  FirmwareUpgradeChangeRequest,
  firmwareUpgradeChangeRequestSchema,
} from '../models/firmwareUpgradeChangeRequest';
import {
  FirmwareUpgradeChangeResult,
  firmwareUpgradeChangeResultSchema,
} from '../models/firmwareUpgradeChangeResult';
import {
  FirmwareUpgradeRequest,
  firmwareUpgradeRequestSchema,
} from '../models/firmwareUpgradeRequest';
import {
  FotaV1SuccessResult,
  fotaV1SuccessResultSchema,
} from '../models/fotaV1SuccessResult';
import { array, string } from '../schema';
import { BaseApi } from './baseApi';
import { FotaV1ResultError } from '../errors/fotaV1ResultError';

export class FirmwareV1Api extends BaseApi {
  /**
   * Lists all device firmware images available for an account, based on the devices registered to that
   * account.
   *
   * @param account Account identifier in "##########-#####".
   * @return Response from the API call
   */
  async listAvailableFirmware(
    account: string,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<Firmware[]>> {
    const req = this.createRequest('GET');
    req.baseUrl('Software Management V1');
    const mapped = req.prepareArgs({ account: [account, string()] });
    req.appendTemplatePath`/firmware/${mapped.account}`;
    req.throwOn(400, FotaV1ResultError, 'Unexpected error.');
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(array(firmwareSchema), requestOptions);
  }

  /**
   * Schedules a firmware upgrade for devices.
   *
   * @param body         Details of the firmware upgrade request.
   * @return Response from the API call
   */
  async scheduleFirmwareUpgrade(
    body: FirmwareUpgradeRequest,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<FirmwareUpgrade>> {
    const req = this.createRequest('POST', '/upgrades');
    req.baseUrl('Software Management V1');
    const mapped = req.prepareArgs({
      body: [body, firmwareUpgradeRequestSchema],
    });
    req.header('Content-Type', 'application/json');
    req.json(mapped.body);
    req.throwOn(400, FotaV1ResultError, 'Unexpected error.');
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(firmwareUpgradeSchema, requestOptions);
  }

  /**
   * Returns information about a specified upgrade, include the target date of the upgrade, the list of
   * devices in the upgrade, and the status of the upgrade for each device.
   *
   * @param accountName Account identifier in "##########-#####".
   * @param upgradeId   The UUID of the upgrade, returned by POST /upgrades when the upgrade was scheduled.
   * @return Response from the API call
   */
  async listFirmwareUpgradeDetails(
    accountName: string,
    upgradeId: string,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<FirmwareUpgrade>> {
    const req = this.createRequest('GET');
    req.baseUrl('Software Management V1');
    const mapped = req.prepareArgs({
      accountName: [accountName, string()],
      upgradeId: [upgradeId, string()],
    });
    req.appendTemplatePath`/upgrades/${mapped.accountName}/upgrade/${mapped.upgradeId}`;
    req.throwOn(400, FotaV1ResultError, 'Unexpected error.');
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(firmwareUpgradeSchema, requestOptions);
  }

  /**
   * Add or remove devices from a scheduled upgrade.
   *
   * @param accountName  Account identifier in "##########-#####".
   * @param upgradeId    The UUID of the upgrade, returned by POST /upgrades
   *                                                            when the upgrade was scheduled.
   * @param body         List of devices to add or remove.
   * @return Response from the API call
   */
  async updateFirmwareUpgradeDevices(
    accountName: string,
    upgradeId: string,
    body: FirmwareUpgradeChangeRequest,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<FirmwareUpgradeChangeResult>> {
    const req = this.createRequest('PUT');
    req.baseUrl('Software Management V1');
    const mapped = req.prepareArgs({
      accountName: [accountName, string()],
      upgradeId: [upgradeId, string()],
      body: [body, firmwareUpgradeChangeRequestSchema],
    });
    req.header('Content-Type', '*/*');
    req.json(mapped.body);
    req.appendTemplatePath`/upgrades/${mapped.accountName}/upgrade/${mapped.upgradeId}`;
    req.throwOn(400, FotaV1ResultError, 'Unexpected error.');
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(firmwareUpgradeChangeResultSchema, requestOptions);
  }

  /**
   * Cancel a scheduled firmware upgrade.
   *
   * @param accountName Account identifier in "##########-#####".
   * @param upgradeId   The UUID of the scheduled upgrade that you want to cancel.
   * @return Response from the API call
   */
  async cancelScheduledFirmwareUpgrade(
    accountName: string,
    upgradeId: string,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<FotaV1SuccessResult>> {
    const req = this.createRequest('DELETE');
    req.baseUrl('Software Management V1');
    const mapped = req.prepareArgs({
      accountName: [accountName, string()],
      upgradeId: [upgradeId, string()],
    });
    req.appendTemplatePath`/upgrades/${mapped.accountName}/upgrade/${mapped.upgradeId}`;
    req.throwOn(400, FotaV1ResultError, 'Unexpected error.');
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(fotaV1SuccessResultSchema, requestOptions);
  }
}
