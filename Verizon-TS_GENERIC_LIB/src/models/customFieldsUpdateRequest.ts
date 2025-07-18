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
import {
  AccountDeviceList,
  accountDeviceListSchema,
} from './accountDeviceList';
import { CustomFields, customFieldsSchema } from './customFields';

/** Request to assign or change custom field values for one or more devices. */
export interface CustomFieldsUpdateRequest {
  /** The name of a billing account.This parameter is only required if the UWS account used for the current API session has access to multiple billing accounts.An account name is usually numeric, and must include any leading zeros. */
  accountName?: string;
  /** Custom field names and values, if you want to only include devices that have matching values. */
  customFields?: CustomFields[];
  /** The names and new values of any custom fields that you want to change. */
  customFieldsToUpdate?: CustomFields[];
  /** The devices that you want to change. */
  devices?: AccountDeviceList[];
  /** The name of a device group, if you want to only include devices in that group. */
  groupName?: string;
  /** The name of a service plan, if you want to only include devices that have that service plan. */
  servicePlan?: string;
  additionalProperties?: Record<string, unknown>;
}

export const customFieldsUpdateRequestSchema: Schema<CustomFieldsUpdateRequest> = typedExpandoObject(
  {
    accountName: ['accountName', optional(string())],
    customFields: [
      'customFields',
      optional(array(lazy(() => customFieldsSchema))),
    ],
    customFieldsToUpdate: [
      'customFieldsToUpdate',
      optional(array(lazy(() => customFieldsSchema))),
    ],
    devices: ['devices', optional(array(lazy(() => accountDeviceListSchema)))],
    groupName: ['groupName', optional(string())],
    servicePlan: ['servicePlan', optional(string())],
  },
  'additionalProperties',
  optional(unknown())
);
