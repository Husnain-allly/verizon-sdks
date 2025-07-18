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

export interface Offboarding {
  /** the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer */
  sensoridentifier?: string;
  additionalProperties?: Record<string, unknown>;
}

export const offboardingSchema: Schema<Offboarding> = typedExpandoObject(
  { sensoridentifier: ['sensoridentifier', optional(string())] },
  'additionalProperties',
  optional(unknown())
);
