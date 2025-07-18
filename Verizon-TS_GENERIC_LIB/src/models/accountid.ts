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

export interface Accountid {
  /** The numeric name of the account and must include leading zeroes */
  accountName?: string;
  mtasAccountNumber?: string;
  additionalProperties?: Record<string, unknown>;
}

export const accountidSchema: Schema<Accountid> = typedExpandoObject(
  {
    accountName: ['accountName', optional(string())],
    mtasAccountNumber: ['mtasAccountNumber', optional(string())],
  },
  'additionalProperties',
  optional(unknown())
);
