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

export interface DtoProfileResponse {
  id?: string;
  /** the user defined profile kind */
  kind?: string;
  /** The resource version */
  version?: string;
  versionid?: string;
  /** Timestamp of the record */
  createdon?: string;
  /** Timestamp of the record */
  lastupdated?: string;
  /** user defined profile name */
  name?: string;
  /** UUID of the ECPD account the user belongs to */
  foreignid?: string;
  /** The billing account ID. This is the same value as the Account ID */
  billingaccountid?: string;
  /** device model id */
  modelid?: string;
  configuration?: unknown;
  additionalProperties?: Record<string, unknown>;
}

export const dtoProfileResponseSchema: Schema<DtoProfileResponse> = typedExpandoObject(
  {
    id: ['id', optional(string())],
    kind: ['kind', optional(string())],
    version: ['version', optional(string())],
    versionid: ['versionid', optional(string())],
    createdon: ['createdon', optional(string())],
    lastupdated: ['lastupdated', optional(string())],
    name: ['name', optional(string())],
    foreignid: ['foreignid', optional(string())],
    billingaccountid: ['billingaccountid', optional(string())],
    modelid: ['modelid', optional(string())],
    configuration: ['configuration', optional(unknown())],
  },
  'additionalProperties',
  optional(unknown())
);
