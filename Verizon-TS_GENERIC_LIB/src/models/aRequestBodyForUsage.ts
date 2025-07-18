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
import { ReadySimDeviceId, readySimDeviceIdSchema } from './readySimDeviceId';

export interface ARequestBodyForUsage {
  deviceId?: ReadySimDeviceId[];
  startTime?: string;
  endTime?: string;
  additionalProperties?: Record<string, unknown>;
}

export const aRequestBodyForUsageSchema: Schema<ARequestBodyForUsage> = typedExpandoObject(
  {
    deviceId: ['deviceId', optional(array(lazy(() => readySimDeviceIdSchema)))],
    startTime: ['startTime', optional(string())],
    endTime: ['endTime', optional(string())],
  },
  'additionalProperties',
  optional(unknown())
);
