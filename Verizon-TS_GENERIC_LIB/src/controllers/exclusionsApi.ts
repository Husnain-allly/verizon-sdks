/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { ApiResponse, RequestOptions } from '../core';
import {
  AccountConsentCreate,
  accountConsentCreateSchema,
} from '../models/accountConsentCreate';
import {
  AccountConsentUpdate,
  accountConsentUpdateSchema,
} from '../models/accountConsentUpdate';
import { ConsentRequest, consentRequestSchema } from '../models/consentRequest';
import {
  ConsentTransactionId,
  consentTransactionIdSchema,
} from '../models/consentTransactionId';
import {
  DeviceLocationSuccessResult,
  deviceLocationSuccessResultSchema,
} from '../models/deviceLocationSuccessResult';
import {
  DevicesConsentResult,
  devicesConsentResultSchema,
} from '../models/devicesConsentResult';
import {
  GetAccountDeviceConsent,
  getAccountDeviceConsentSchema,
} from '../models/getAccountDeviceConsent';
import { optional, string } from '../schema';
import { BaseApi } from './baseApi';
import { DeviceLocationResultError } from '../errors/deviceLocationResultError';

export class ExclusionsApi extends BaseApi {
  /**
   * Get the consent settings for the entire account or device list in an account.
   *
   * @param accountName The numeric name of the account.
   * @param deviceId    The IMEI of the device being queried
   * @return Response from the API call
   */
  async devicesLocationGetConsentAsync(
    accountName: string,
    deviceId?: string,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<GetAccountDeviceConsent>> {
    const req = this.createRequest('GET', '/devicelocations/action/consents');
    req.baseUrl('Device Location');
    const mapped = req.prepareArgs({
      accountName: [accountName, string()],
      deviceId: [deviceId, optional(string())],
    });
    req.query('accountName', mapped.accountName);
    req.query('deviceId', mapped.deviceId);
    req.defaultToError(DeviceLocationResultError, 'Unexpected error.');
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(getAccountDeviceConsentSchema, requestOptions);
  }

  /**
   * Create a consent record to use location services as an asynchronous request.
   *
   * @param body         Account details to create a consent record.
   * @return Response from the API call
   */
  async devicesLocationGiveConsentAsync(
    body?: AccountConsentCreate,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<ConsentTransactionId>> {
    const req = this.createRequest('POST', '/devicelocations/action/consents');
    req.baseUrl('Device Location');
    const mapped = req.prepareArgs({
      body: [body, optional(accountConsentCreateSchema)],
    });
    req.header('Content-Type', 'application/json');
    req.json(mapped.body);
    req.defaultToError(DeviceLocationResultError, 'Unexpected error.');
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(consentTransactionIdSchema, requestOptions);
  }

  /**
   * Update the location services consent record for an entire account.
   *
   * @param body         Account details to update a consent record.
   * @return Response from the API call
   */
  async devicesLocationUpdateConsent(
    body?: AccountConsentUpdate,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<ConsentTransactionId>> {
    const req = this.createRequest('PUT', '/devicelocations/action/consents');
    req.baseUrl('Device Location');
    const mapped = req.prepareArgs({
      body: [body, optional(accountConsentUpdateSchema)],
    });
    req.header('Content-Type', 'application/json');
    req.json(mapped.body);
    req.defaultToError(DeviceLocationResultError, 'Unexpected error.');
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(consentTransactionIdSchema, requestOptions);
  }

  /**
   * This consents endpoint sets a new exclusion list.
   *
   * @param body         Request to update account consent exclusion list.
   * @return Response from the API call
   */
  async excludeDevices(
    body: ConsentRequest,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<DeviceLocationSuccessResult>> {
    const req = this.createRequest('POST', '/consents');
    req.baseUrl('Device Location');
    const mapped = req.prepareArgs({ body: [body, consentRequestSchema] });
    req.header('Content-Type', '*/*');
    req.json(mapped.body);
    req.throwOn(400, DeviceLocationResultError, 'Unexpected error.');
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(deviceLocationSuccessResultSchema, requestOptions);
  }

  /**
   * Removes devices from the exclusion list so that they can be located with Device Location Services
   * requests.
   *
   * @param accountName The numeric name of the account.
   * @param deviceList  A list of the device IDs to remove from the exclusion list.
   * @return Response from the API call
   */
  async removeDevicesFromExclusionList(
    accountName: string,
    deviceList: string,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<DeviceLocationSuccessResult>> {
    const req = this.createRequest('DELETE', '/consents');
    req.baseUrl('Device Location');
    const mapped = req.prepareArgs({
      accountName: [accountName, string()],
      deviceList: [deviceList, string()],
    });
    req.query('accountName', mapped.accountName);
    req.query('deviceList', mapped.deviceList);
    req.throwOn(400, DeviceLocationResultError, 'Unexpected error.');
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(deviceLocationSuccessResultSchema, requestOptions);
  }

  /**
   * This consents endpoint retrieves a list of excluded devices in an account.
   *
   * @param accountName Account identifier in "##########-#####".
   * @param startIndex  Zero-based number of the first record to return.
   * @return Response from the API call
   */
  async listExcludedDevices(
    accountName: string,
    startIndex: string,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<DevicesConsentResult>> {
    const req = this.createRequest('GET');
    req.baseUrl('Device Location');
    const mapped = req.prepareArgs({
      accountName: [accountName, string()],
      startIndex: [startIndex, string()],
    });
    req.appendTemplatePath`/consents/${mapped.accountName}/index/${mapped.startIndex}`;
    req.throwOn(400, DeviceLocationResultError, 'Unexpected error.');
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(devicesConsentResultSchema, requestOptions);
  }
}
