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

/** Custom data that can be included using key-value pairs. */
export interface CustomFields {
  /** The key for an extended attribute. */
  key: string;
  /** The value of an extended attribute. */
  value: string;
  additionalProperties?: Record<string, unknown>;
}

export const customFieldsSchema: Schema<CustomFields> = typedExpandoObject(
  { key: ['key', string()], value: ['value', string()] },
  'additionalProperties',
  optional(unknown())
);
