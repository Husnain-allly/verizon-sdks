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

export interface PwnProfile {
  profileId?: string;
  profileName?: string;
  additionalProperties?: Record<string, unknown>;
}

export const pwnProfileSchema: Schema<PwnProfile> = typedExpandoObject(
  {
    profileId: ['profileId', optional(string())],
    profileName: ['profileName', optional(string())],
  },
  'additionalProperties',
  optional(unknown())
);
