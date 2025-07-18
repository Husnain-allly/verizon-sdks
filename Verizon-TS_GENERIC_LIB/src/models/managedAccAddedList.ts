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

export interface ManagedAccAddedList {
  /** Account name */
  id?: string;
  /** Transaction identifier */
  txid?: string;
  additionalProperties?: Record<string, unknown>;
}

export const managedAccAddedListSchema: Schema<ManagedAccAddedList> = typedExpandoObject(
  { id: ['id', optional(string())], txid: ['txid', optional(string())] },
  'additionalProperties',
  optional(unknown())
);
