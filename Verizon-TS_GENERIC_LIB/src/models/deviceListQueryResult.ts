/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import {
  array,
  bigint,
  boolean,
  lazy,
  optional,
  Schema,
  string,
  typedExpandoObject,
  unknown,
} from '../schema';
import {
  DeviceListQueryItem,
  deviceListQueryItemSchema,
} from './deviceListQueryItem';

/** List of devices. */
export interface DeviceListQueryResult {
  /** Account identifier in "##########-#####". */
  accountName?: string;
  /** True if there are more devices to retrieve. */
  hasMoreData?: boolean;
  /** If hasMoreData=true, the startIndex to use for the next request. 0 if hasMoreData=false. */
  lastSeenDeviceId?: bigint;
  /** The list of devices in the account. */
  deviceList?: DeviceListQueryItem[];
  additionalProperties?: Record<string, unknown>;
}

export const deviceListQueryResultSchema: Schema<DeviceListQueryResult> = typedExpandoObject(
  {
    accountName: ['accountName', optional(string())],
    hasMoreData: ['hasMoreData', optional(boolean())],
    lastSeenDeviceId: ['lastSeenDeviceId', optional(bigint())],
    deviceList: [
      'deviceList',
      optional(array(lazy(() => deviceListQueryItemSchema))),
    ],
  },
  'additionalProperties',
  optional(unknown())
);
