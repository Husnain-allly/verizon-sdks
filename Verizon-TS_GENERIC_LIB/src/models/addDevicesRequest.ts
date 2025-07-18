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

/** Request to add the devices. */
export interface AddDevicesRequest {
  /** The initial service state for the devices. The only valid state is “Preactive.” */
  state: string;
  /** The devices that you want to add. */
  devicesToAdd: AccountDeviceList[];
  /** The billing account to which the devices are added. */
  accountName?: string;
  /** The names and values for any custom fields that you want set for the devices as they are added to the account. */
  customFields?: CustomFields[];
  /** The name of a device group to add the devices to. They are added to the default device group if you don't include this parameter. */
  groupName?: string;
  /** The Stock Keeping Unit (SKU) number of a 4G device type with an embedded SIM. */
  skuNumber?: string;
  smsrOid?: string;
  additionalProperties?: Record<string, unknown>;
}

export const addDevicesRequestSchema: Schema<AddDevicesRequest> = typedExpandoObject(
  {
    state: ['state', string()],
    devicesToAdd: ['devicesToAdd', array(lazy(() => accountDeviceListSchema))],
    accountName: ['accountName', optional(string())],
    customFields: [
      'customFields',
      optional(array(lazy(() => customFieldsSchema))),
    ],
    groupName: ['groupName', optional(string())],
    skuNumber: ['skuNumber', optional(string())],
    smsrOid: ['smsrOid', optional(string())],
  },
  'additionalProperties',
  optional(unknown())
);
