/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { ApiResponse, RequestOptions } from '../core';
import {
  ListMecPlatformsResult,
  listMecPlatformsResultSchema,
} from '../models/listMecPlatformsResult';
import {
  ListRegionsResult,
  listRegionsResultSchema,
} from '../models/listRegionsResult';
import {
  UserEquipmentIdentityType,
  userEquipmentIdentityTypeSchema,
} from '../models/userEquipmentIdentityType';
import { number, optional, string } from '../schema';
import { BaseApi } from './baseApi';
import { EdgeDiscoveryResultError } from '../errors/edgeDiscoveryResultError';

export class M5GEdgePlatformsApi extends BaseApi {
  /**
   * Returns a list of optimal MEC Platforms where you can register your deployed application. **Note:**
   * If a query is sent with all of the parameters, it will fail with a "400" error. You can search based
   * on the following parameter combinations - region plus Service Profile ID and subscriber density
   * (density is optional but recommended), region plus UEIdentity(Including UEIdentity Type) or Service
   * Profile ID plus UEIdentity(Including UEIdentity Type).
   *
   * @param region            MEC region name. Current valid values are US_WEST_2 and
   *                                                       US_EAST_1.
   * @param serviceProfileId  Unique identifier of the service profile.
   * @param subscriberDensity Minimum number of 4G/5G subscribers per square kilometer.
   * @param ueIdentityType    Type of User Equipment identifier used in `UEIdentity`.
   * @param ueIdentity        The identifier value for User Equipment. The type of
   *                                                       identifier is defined by the 'UEIdentityType' parameter.
   *                                                       The`IPAddress`format can be IPv4 or IPv6.
   * @return Response from the API call
   */
  async listMecPlatforms(
    region?: string,
    serviceProfileId?: string,
    subscriberDensity?: number,
    ueIdentityType?: UserEquipmentIdentityType,
    ueIdentity?: string,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<ListMecPlatformsResult>> {
    const req = this.createRequest('GET', '/mecplatforms');
    const mapped = req.prepareArgs({
      region: [region, optional(string())],
      serviceProfileId: [serviceProfileId, optional(string())],
      subscriberDensity: [subscriberDensity, optional(number())],
      ueIdentityType: [
        ueIdentityType,
        optional(userEquipmentIdentityTypeSchema),
      ],
      ueIdentity: [ueIdentity, optional(string())],
    });
    req.query('region', mapped.region);
    req.query('serviceProfileId', mapped.serviceProfileId);
    req.query('subscriberDensity', mapped.subscriberDensity);
    req.query('UEIdentityType', mapped.ueIdentityType);
    req.query('UEIdentity', mapped.ueIdentity);
    req.throwOn(400, EdgeDiscoveryResultError, 'HTTP 400 Bad Request.');
    req.throwOn(401, EdgeDiscoveryResultError, 'HTTP 401 Unauthorized.');
    req.defaultToError(
      EdgeDiscoveryResultError,
      'HTTP 500 Internal Server Error.'
    );
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(listMecPlatformsResultSchema, requestOptions);
  }

  /**
   * List the geographical regions available, based on the user's bearer token. **Note:** Country code,
   * Metropolitan area, Area and Zone are future functionality and will currently return a "null" value.
   *
   * @return Response from the API call
   */
  async listRegions(
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<ListRegionsResult>> {
    const req = this.createRequest('GET', '/regions');
    req.throwOn(400, EdgeDiscoveryResultError, 'HTTP 400 Bad Request.');
    req.throwOn(401, EdgeDiscoveryResultError, 'HTTP 401 Unauthorized.');
    req.defaultToError(
      EdgeDiscoveryResultError,
      'HTTP 500 Internal Server Error.'
    );
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(listRegionsResultSchema, requestOptions);
  }
}
