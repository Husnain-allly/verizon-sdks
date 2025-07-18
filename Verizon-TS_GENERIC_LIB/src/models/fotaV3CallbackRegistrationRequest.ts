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

/** Callback URL where the listening service is running. */
export interface FotaV3CallbackRegistrationRequest {
  /** Callback URL for an subscribed service. */
  url?: string;
  additionalProperties?: Record<string, unknown>;
}

export const fotaV3CallbackRegistrationRequestSchema: Schema<FotaV3CallbackRegistrationRequest> = typedExpandoObject(
  { url: ['url', optional(string())] },
  'additionalProperties',
  optional(unknown())
);
