/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { ApiResponse, RequestOptions } from '../core';
import {
  DtoCreateUserRequest,
  dtoCreateUserRequestSchema,
} from '../models/dtoCreateUserRequest';
import {
  DtoDeleteUserRequest,
  dtoDeleteUserRequestSchema,
} from '../models/dtoDeleteUserRequest';
import {
  DtoListUserRequest,
  dtoListUserRequestSchema,
} from '../models/dtoListUserRequest';
import {
  DtoUpdateUserRequest,
  dtoUpdateUserRequestSchema,
} from '../models/dtoUpdateUserRequest';
import { ResourceUser, resourceUserSchema } from '../models/resourceUser';
import { array } from '../schema';
import { BaseApi } from './baseApi';
import { M400ManagementError } from '../errors/m400ManagementError';
import { M403ManagementError } from '../errors/m403ManagementError';
import { M404ManagementError } from '../errors/m404ManagementError';
import { M500ManagementError } from '../errors/m500ManagementError';
import { ManagementError } from '../errors/managementError';

export class SensorInsightsUsersApi extends BaseApi {
  /**
   * @param body         Create a user profile
   * @return Response from the API call
   */
  async sensorInsightsCreateUserRequest(
    body: DtoCreateUserRequest,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<ResourceUser>> {
    const req = this.createRequest('POST', '/dm/v1/users');
    req.baseUrl('Thingspace');
    const mapped = req.prepareArgs({
      body: [body, dtoCreateUserRequestSchema],
    });
    req.header('Content-Type', 'application/json');
    req.json(mapped.body);
    req.throwOn(400, M400ManagementError, 'Bad Request');
    req.throwOn(401, ManagementError, 'UnAuthorized');
    req.throwOn(403, M403ManagementError, 'Forbidden');
    req.throwOn(406, ManagementError, 'Not Acceptable');
    req.throwOn(415, ManagementError, 'Unsupported media type');
    req.throwOn(429, ManagementError, 'Too many requests');
    req.throwOn(500, M500ManagementError, 'Internal server error.');
    req.defaultToError(ManagementError, 'Unexpected error');
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(resourceUserSchema, requestOptions);
  }

  /**
   * @param deleterequestpayload Payload for the delete user request.
   * @return Response from the API call
   */
  async sensorInsightsDeleteUser(
    deleterequestpayload: DtoDeleteUserRequest,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<void>> {
    const req = this.createRequest('DELETE', '/dm/v1/users');
    req.baseUrl('Thingspace');
    const mapped = req.prepareArgs({
      deleterequestpayload: [deleterequestpayload, dtoDeleteUserRequestSchema],
    });
    req.query('deleterequestpayload', mapped.deleterequestpayload);
    req.throwOn(400, M400ManagementError, 'Bad Request');
    req.throwOn(401, ManagementError, 'UnAuthorized');
    req.throwOn(403, M403ManagementError, 'Forbidden');
    req.throwOn(404, M404ManagementError, 'Not Found');
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.call(requestOptions);
  }

  /**
   * @param body         Partially update a user profile
   * @return Response from the API call
   */
  async sensorInsightsUpdateUserRequest(
    body: DtoUpdateUserRequest,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<ResourceUser>> {
    const req = this.createRequest('PATCH', '/dm/v1/users');
    req.baseUrl('Thingspace');
    const mapped = req.prepareArgs({
      body: [body, dtoUpdateUserRequestSchema],
    });
    req.header('Content-Type', 'application/json');
    req.json(mapped.body);
    req.throwOn(400, M400ManagementError, 'Bad Request');
    req.throwOn(401, ManagementError, 'UnAuthorized');
    req.throwOn(403, M403ManagementError, 'Forbidden');
    req.throwOn(404, M404ManagementError, 'Not Found');
    req.throwOn(406, ManagementError, 'Not Acceptable');
    req.throwOn(415, ManagementError, 'Unsupported media type');
    req.throwOn(429, ManagementError, 'Too many requests');
    req.throwOn(500, M500ManagementError, 'Internal server error.');
    req.defaultToError(ManagementError, 'Unexpected error');
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(resourceUserSchema, requestOptions);
  }

  /**
   * @param body         A summary of user profile records on an account
   * @return Response from the API call
   */
  async sensorInsightsListUserRequest(
    body: DtoListUserRequest,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<ResourceUser[]>> {
    const req = this.createRequest('POST', '/dm/v1/users/actions/query');
    req.baseUrl('Thingspace');
    const mapped = req.prepareArgs({ body: [body, dtoListUserRequestSchema] });
    req.header('Content-Type', 'application/json');
    req.json(mapped.body);
    req.throwOn(400, M400ManagementError, 'Bad Request');
    req.throwOn(401, ManagementError, 'UnAuthorized');
    req.throwOn(403, M403ManagementError, 'Forbidden');
    req.throwOn(404, M404ManagementError, 'Not Found');
    req.throwOn(406, ManagementError, 'Not Acceptable');
    req.throwOn(415, ManagementError, 'Unsupported media type');
    req.throwOn(429, ManagementError, 'Too many requests');
    req.throwOn(500, M500ManagementError, 'Internal server error.');
    req.defaultToError(ManagementError, 'Unexpected error');
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(array(resourceUserSchema), requestOptions);
  }
}
