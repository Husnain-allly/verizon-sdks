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

export interface M5GBiattribute1 {
  key?: string;
  additionalProperties?: Record<string, unknown>;
}

export const m5GBiattribute1Schema: Schema<M5GBiattribute1> = typedExpandoObject(
  { key: ['key', optional(string())] },
  'additionalProperties',
  optional(unknown())
);
