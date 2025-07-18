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
  typedExpandoObject,
  unknown,
} from '../schema';
import { MismatchedDevice, mismatchedDeviceSchema } from './mismatchedDevice';

/** Response to list of all 4G devices with an ICCID (SIM) that was not activated with the expected IMEI (hardware) during a specified time frame. */
export interface DeviceMismatchListResult {
  /** A list of specific devices that you want to check, specified by ICCID or MDN. */
  devices?: MismatchedDevice[];
  additionalProperties?: Record<string, unknown>;
}

export const deviceMismatchListResultSchema: Schema<DeviceMismatchListResult> = typedExpandoObject(
  { devices: ['devices', optional(array(lazy(() => mismatchedDeviceSchema)))] },
  'additionalProperties',
  optional(unknown())
);
