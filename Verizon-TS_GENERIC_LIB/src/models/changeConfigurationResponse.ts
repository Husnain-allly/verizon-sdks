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
import { Fields, fieldsSchema } from './fields';

/** Change Configuration resource definition. */
export interface ChangeConfigurationResponse {
  /** The action requested in this event; “change” for device configuration changes. */
  action?: string;
  /** The date and time of the change request. */
  createdon?: string;
  /** The device’s ThingSpace UUID. */
  deviceid?: string;
  /** List of fields affected by the event. */
  fields?: Fields;
  /** foreign id */
  foreignid?: string;
  /** The unique ID of this ts.event.configuration event. */
  id?: string;
  /** The kind of the ThingSpace resource that is being reported */
  kind?: string;
  /** The date and time that the event was last updated. */
  lastupdated?: string;
  /** The name of the event; “SetConfigurationReq” for device configuration changes. */
  name?: string;
  /** The current status of the request. The value will be “pending” until the device wakes up and ThingSpace can send the request to the device. */
  state?: string;
  /** transaction id */
  transactionid?: string;
  /** version */
  version?: string;
  additionalProperties?: Record<string, unknown>;
}

export const changeConfigurationResponseSchema: Schema<ChangeConfigurationResponse> = typedExpandoObject(
  {
    action: ['action', optional(string())],
    createdon: ['createdon', optional(string())],
    deviceid: ['deviceid', optional(string())],
    fields: ['fields', optional(lazy(() => fieldsSchema))],
    foreignid: ['foreignid', optional(string())],
    id: ['id', optional(string())],
    kind: ['kind', optional(string())],
    lastupdated: ['lastupdated', optional(string())],
    name: ['name', optional(string())],
    state: ['state', optional(string())],
    transactionid: ['transactionid', optional(string())],
    version: ['version', optional(string())],
  },
  'additionalProperties',
  optional(unknown())
);
