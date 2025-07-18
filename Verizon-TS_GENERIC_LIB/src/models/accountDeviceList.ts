/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import {
  array,
  lazy,
  optional,
  Schema,
  string,
  typedExpandoObject,
  unknown,
} from '../schema';
import { DeviceId, deviceIdSchema } from './deviceId';

/** A list of deviceId objects to use when requesting information from multiple devices. */
export interface AccountDeviceList {
  /** All identifiers for the device. */
  deviceIds: DeviceId[];
  ipaddress?: string;
  additionalProperties?: Record<string, unknown>;
}

export const accountDeviceListSchema: Schema<AccountDeviceList> = typedExpandoObject(
  {
    deviceIds: ['deviceIds', array(lazy(() => deviceIdSchema))],
    ipaddress: ['ipAddress', optional(string())],
  },
  'additionalProperties',
  optional(unknown())
);
