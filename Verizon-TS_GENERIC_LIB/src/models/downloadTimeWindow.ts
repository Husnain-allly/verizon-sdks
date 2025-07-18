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

export interface DownloadTimeWindow {
  /** Device IMEI list. */
  startTime?: string;
  /** Device IMEI list. */
  endTime?: string;
  additionalProperties?: Record<string, unknown>;
}

export const downloadTimeWindowSchema: Schema<DownloadTimeWindow> = typedExpandoObject(
  {
    startTime: ['startTime', optional(string())],
    endTime: ['endTime', optional(string())],
  },
  'additionalProperties',
  optional(unknown())
);
