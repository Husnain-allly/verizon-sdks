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

/** Request to register a callback. */
export interface RegisterCallbackRequest {
  /** The name of the callback service that you want to subscribe to. */
  name: string;
  /** The address on your server where you have enabled a listening service for callback messages. */
  url: string;
  /** The user name that the M2M Platform should return in the callback messages. */
  username?: string;
  /** The password that the M2M Platform should return in the callback messages. */
  password?: string;
  additionalProperties?: Record<string, unknown>;
}

export const registerCallbackRequestSchema: Schema<RegisterCallbackRequest> = typedExpandoObject(
  {
    name: ['name', string()],
    url: ['url', string()],
    username: ['username', optional(string())],
    password: ['password', optional(string())],
  },
  'additionalProperties',
  optional(unknown())
);
