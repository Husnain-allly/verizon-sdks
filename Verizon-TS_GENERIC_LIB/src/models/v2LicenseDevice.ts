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

/** Device IMEI list. */
export interface V2LicenseDevice {
  /** Device IMEI. */
  deviceId: string;
  /** License assignment time. */
  assignmentTime?: string;
  additionalProperties?: Record<string, unknown>;
}

export const v2LicenseDeviceSchema: Schema<V2LicenseDevice> = typedExpandoObject(
  {
    deviceId: ['deviceId', string()],
    assignmentTime: ['assignmentTime', optional(string())],
  },
  'additionalProperties',
  optional(unknown())
);
