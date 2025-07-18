/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import {
  array,
  bigint,
  lazy,
  number,
  optional,
  Schema,
  string,
  typedExpandoObject,
  unknown,
} from '../schema';
import {
  AccountDeviceListFilter,
  accountDeviceListFilterSchema,
} from './accountDeviceListFilter';
import { CustomFields, customFieldsSchema } from './customFields';
import { DeviceId, deviceIdSchema } from './deviceId';

/** Request for listing account devices. */
export interface AccountDeviceListRequest {
  /** The billing account for which a list of devices is returned. If you don't specify an accountName, the list includes all devices to which you have access. */
  accountName?: string;
  /** An identifier for a single device. */
  deviceId?: DeviceId;
  /** Filter for a list of devices. */
  filter?: AccountDeviceListFilter;
  /** The name of a device state, to only include devices in that state. */
  currentState?: string;
  /** Custom field names and values, if you want to only include devices that have matching values. */
  customFields?: CustomFields[];
  /** Only include devices that were added after this date and time. */
  earliest?: string;
  /** Only include devices that are in this device group. */
  groupName?: string;
  /** Only include devices that were added before this date and time. */
  latest?: string;
  /** Only include devices that have this service plan. */
  servicePlan?: string;
  maxNumberOfDevices?: number;
  largestDeviceIdSeen?: bigint;
  additionalProperties?: Record<string, unknown>;
}

export const accountDeviceListRequestSchema: Schema<AccountDeviceListRequest> = typedExpandoObject(
  {
    accountName: ['accountName', optional(string())],
    deviceId: ['deviceId', optional(lazy(() => deviceIdSchema))],
    filter: ['filter', optional(lazy(() => accountDeviceListFilterSchema))],
    currentState: ['currentState', optional(string())],
    customFields: [
      'customFields',
      optional(array(lazy(() => customFieldsSchema))),
    ],
    earliest: ['earliest', optional(string())],
    groupName: ['groupName', optional(string())],
    latest: ['latest', optional(string())],
    servicePlan: ['servicePlan', optional(string())],
    maxNumberOfDevices: ['maxNumberOfDevices', optional(number())],
    largestDeviceIdSeen: ['largestDeviceIdSeen', optional(bigint())],
  },
  'additionalProperties',
  optional(unknown())
);
