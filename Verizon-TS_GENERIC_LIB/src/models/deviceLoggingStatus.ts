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

/** Device logging status information. */
export interface DeviceLoggingStatus {
  /** Device IMEI. */
  deviceId: string;
  /** The date when device logging expires. */
  expiryDate: string;
  additionalProperties?: Record<string, unknown>;
}

export const deviceLoggingStatusSchema: Schema<DeviceLoggingStatus> = typedExpandoObject(
  { deviceId: ['deviceId', string()], expiryDate: ['expiryDate', string()] },
  'additionalProperties',
  optional(unknown())
);
