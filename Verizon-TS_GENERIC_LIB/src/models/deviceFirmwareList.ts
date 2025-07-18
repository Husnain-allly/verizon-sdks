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
  DeviceFirmwareVersion,
  deviceFirmwareVersionSchema,
} from './deviceFirmwareVersion';

/** Device Firmware Information. */
export interface DeviceFirmwareList {
  /** Account name. */
  accountName: string;
  /** List of device & firmware. */
  deviceFirmwarVersionList?: DeviceFirmwareVersion[];
  additionalProperties?: Record<string, unknown>;
}

export const deviceFirmwareListSchema: Schema<DeviceFirmwareList> = typedExpandoObject(
  {
    accountName: ['accountName', string()],
    deviceFirmwarVersionList: [
      'deviceFirmwarVersionList',
      optional(array(lazy(() => deviceFirmwareVersionSchema))),
    ],
  },
  'additionalProperties',
  optional(unknown())
);
