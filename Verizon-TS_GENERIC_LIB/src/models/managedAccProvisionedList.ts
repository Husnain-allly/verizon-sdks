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

export interface ManagedAccProvisionedList {
  /** Account name */
  id?: string;
  /** Transaction identifier */
  txid?: string;
  additionalProperties?: Record<string, unknown>;
}

export const managedAccProvisionedListSchema: Schema<ManagedAccProvisionedList> = typedExpandoObject(
  { id: ['id', optional(string())], txid: ['txid', optional(string())] },
  'additionalProperties',
  optional(unknown())
);
