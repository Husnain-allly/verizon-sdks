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

/** Add or remove devices from the existing software upgrade information. */
export interface V2AddOrRemoveDeviceResult {
  /** Account identifier. */
  accountName: string;
  /** Campaign identifier. */
  campaignId: string;
  /** Request identifier. */
  requestId: string;
  additionalProperties?: Record<string, unknown>;
}

export const v2AddOrRemoveDeviceResultSchema: Schema<V2AddOrRemoveDeviceResult> = typedExpandoObject(
  {
    accountName: ['accountName', string()],
    campaignId: ['campaignId', string()],
    requestId: ['requestId', string()],
  },
  'additionalProperties',
  optional(unknown())
);
