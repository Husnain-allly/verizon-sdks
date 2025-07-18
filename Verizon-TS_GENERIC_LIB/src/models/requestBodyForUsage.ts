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

export interface RequestBodyForUsage {
  accountId?: string;
  deviceId?: ReadySimDeviceId[];
  startTime?: string;
  endTime?: string;
  additionalProperties?: Record<string, unknown>;
}

export const requestBodyForUsageSchema: Schema<RequestBodyForUsage> = typedExpandoObject(
  {
    accountId: ['accountId', optional(string())],
    deviceId: ['deviceId', optional(array(lazy(() => readySimDeviceIdSchema)))],
    startTime: ['startTime', optional(string())],
    endTime: ['endTime', optional(string())],
  },
  'additionalProperties',
  optional(unknown())
);
