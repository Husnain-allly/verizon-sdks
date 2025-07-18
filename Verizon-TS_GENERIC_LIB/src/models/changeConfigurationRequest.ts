/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import {
  lazy,
  optional,
  Schema,
  typedExpandoObject,
  unknown,
} from '../schema';
import {
  AccountIdentifier,
  accountIdentifierSchema,
} from './accountIdentifier';
import { MConfiguration, mConfigurationSchema } from './mConfiguration';
import {
  ResourceIdentifier,
  resourceIdentifierSchema,
} from './resourceIdentifier';

/** The request body identifies the device and the values to set. */
export interface ChangeConfigurationRequest {
  /** The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`. */
  accountidentifier?: AccountIdentifier;
  /** The ID of the target to delete, in the format {"id": "dd1682d3-2d80-cefc-f3ee-25154800beff"}. */
  resourceidentifier?: ResourceIdentifier;
  /** List of the field names and values to set. */
  configuration?: MConfiguration;
  additionalProperties?: Record<string, unknown>;
}

export const changeConfigurationRequestSchema: Schema<ChangeConfigurationRequest> = typedExpandoObject(
  {
    accountidentifier: [
      'accountidentifier',
      optional(lazy(() => accountIdentifierSchema)),
    ],
    resourceidentifier: [
      'resourceidentifier',
      optional(lazy(() => resourceIdentifierSchema)),
    ],
    configuration: [
      'configuration',
      optional(lazy(() => mConfigurationSchema)),
    ],
  },
  'additionalProperties',
  optional(unknown())
);
