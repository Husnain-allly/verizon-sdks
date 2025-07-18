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

/** Registered callback information. */
export interface CallbackSummary {
  /** Callback URL for an subscribed service. */
  url?: string;
  additionalProperties?: Record<string, unknown>;
}

export const callbackSummarySchema: Schema<CallbackSummary> = typedExpandoObject(
  { url: ['url', optional(string())] },
  'additionalProperties',
  optional(unknown())
);
