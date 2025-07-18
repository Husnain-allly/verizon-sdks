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
import {
  DtoDeviceActionSetConfiguration,
  dtoDeviceActionSetConfigurationSchema,
} from './dtoDeviceActionSetConfiguration';

export interface ActionResultwithDeviceConfig {
  /** Timestamp of the record */
  createdon?: string;
  description?: string;
  /** This is a UUID value of the device created when the device is onboarded */
  deviceid?: string;
  /** Error message */
  errmsg?: string;
  fields?: DtoDeviceActionSetConfiguration;
  /** UUID of the ECPD account the user belongs to */
  foreignid?: string;
  /** UUID of the user record, assigned at creation */
  id?: string;
  /** Timestamp of the record */
  lastupdated?: string;
  /** The current status of the device or transaction and will be `success` or `failed` */
  state?: string;
  /** The system-generated UUID of the transaction */
  transactionid?: string;
  /** The resource version */
  version?: string;
  /** The UUID of the resource version */
  versionid?: string;
  additionalProperties?: Record<string, unknown>;
}

export const actionResultwithDeviceConfigSchema: Schema<ActionResultwithDeviceConfig> = typedExpandoObject(
  {
    createdon: ['createdon', optional(string())],
    description: ['description', optional(string())],
    deviceid: ['deviceid', optional(string())],
    errmsg: ['errmsg', optional(string())],
    fields: [
      'fields',
      optional(lazy(() => dtoDeviceActionSetConfigurationSchema)),
    ],
    foreignid: ['foreignid', optional(string())],
    id: ['id', optional(string())],
    lastupdated: ['lastupdated', optional(string())],
    state: ['state', optional(string())],
    transactionid: ['transactionid', optional(string())],
    version: ['version', optional(string())],
    versionid: ['versionid', optional(string())],
  },
  'additionalProperties',
  optional(unknown())
);
