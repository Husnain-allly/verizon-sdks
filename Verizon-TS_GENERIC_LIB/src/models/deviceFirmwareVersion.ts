/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import {
  optional,
  Schema,
  string,
  typedExpandoObject,
  unknown,
} from '../schema';

/** Device and firmware information. */
export interface DeviceFirmwareVersion {
  status?: string;
  reason?: string;
  /** Device IMEI. */
  deviceId: string;
  /** Device Firmware Version. */
  firmwareVersion: string;
  firmwareVersionUpdateTime?: string;
  additionalProperties?: Record<string, unknown>;
}

export const deviceFirmwareVersionSchema: Schema<DeviceFirmwareVersion> = typedExpandoObject(
  {
    status: ['status', optional(string())],
    reason: ['reason', optional(string())],
    deviceId: ['deviceId', string()],
    firmwareVersion: ['firmwareVersion', string()],
    firmwareVersionUpdateTime: [
      'firmwareVersionUpdateTime',
      optional(string()),
    ],
  },
  'additionalProperties',
  optional(unknown())
);
