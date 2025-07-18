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

export interface Cellphonenumber {
  number?: string;
  carrier?: string;
  additionalProperties?: Record<string, unknown>;
}

export const cellphonenumberSchema: Schema<Cellphonenumber> = typedExpandoObject(
  {
    number: ['number', optional(string())],
    carrier: ['carrier', optional(string())],
  },
  'additionalProperties',
  optional(unknown())
);
