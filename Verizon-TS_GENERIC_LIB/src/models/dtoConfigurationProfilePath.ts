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
import { DtoProfile, dtoProfileSchema } from './dtoProfile';
import {
  DtoResourceidentifier,
  dtoResourceidentifierSchema,
} from './dtoResourceidentifier';

export interface DtoConfigurationProfilePath {
  /** The numeric account name, which must include leading zeros */
  accountName?: string;
  resourceidentifier?: DtoResourceidentifier;
  profile?: DtoProfile;
  additionalProperties?: Record<string, unknown>;
}

export const dtoConfigurationProfilePathSchema: Schema<DtoConfigurationProfilePath> = typedExpandoObject(
  {
    accountName: ['accountName', optional(string())],
    resourceidentifier: [
      'resourceidentifier',
      optional(lazy(() => dtoResourceidentifierSchema)),
    ],
    profile: ['profile', optional(lazy(() => dtoProfileSchema))],
  },
  'additionalProperties',
  optional(unknown())
);
