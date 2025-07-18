/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import {
  lazy,
  optional,
  Schema,
  string,
  typedExpandoObject,
  unknown,
} from '../schema';
import { GioDeviceId, gioDeviceIdSchema } from './gioDeviceId';

export interface DailyUsage {
  deviceId?: GioDeviceId;
  /** The start date of the time period queried as "$datetime" */
  earliest?: string;
  /** The end date of the time period being queried as "$datetime" */
  latest?: string;
  additionalProperties?: Record<string, unknown>;
}

export const dailyUsageSchema: Schema<DailyUsage> = typedExpandoObject(
  {
    deviceId: ['deviceId', optional(lazy(() => gioDeviceIdSchema))],
    earliest: ['earliest', optional(string())],
    latest: ['latest', optional(string())],
  },
  'additionalProperties',
  optional(unknown())
);
