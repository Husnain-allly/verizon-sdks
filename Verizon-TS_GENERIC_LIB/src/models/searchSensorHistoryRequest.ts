/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import {
  lazy,
  number,
  optional,
  Schema,
  string,
  typedExpandoObject,
  unknown,
} from '../schema';
import {
  AccountIdentifier,
  accountIdentifierSchema,
} from './accountIdentifier';
import {
  ResourceIdentifier,
  resourceIdentifierSchema,
} from './resourceIdentifier';

/** Search Device By Property resource definition. */
export interface SearchSensorHistoryRequest {
  /** The ID of the authenticating billing account, in the format `{"billingaccountid":"1234567890-12345"}`. */
  accountidentifier: AccountIdentifier;
  /** The ID of the target to delete, in the format {"id": "dd1682d3-2d80-cefc-f3ee-25154800beff"}. */
  resourceidentifier: ResourceIdentifier;
  /** The maximum number of events to include in the response. */
  mLimitnumber?: number;
  /** The maximum number of events to include in the response. */
  mPage?: string;
  additionalProperties?: Record<string, unknown>;
}

export const searchSensorHistoryRequestSchema: Schema<SearchSensorHistoryRequest> = typedExpandoObject(
  {
    accountidentifier: [
      'accountidentifier',
      lazy(() => accountIdentifierSchema),
    ],
    resourceidentifier: [
      'resourceidentifier',
      lazy(() => resourceIdentifierSchema),
    ],
    mLimitnumber: ['$limitnumber', optional(number())],
    mPage: ['$page', optional(string())],
  },
  'additionalProperties',
  optional(unknown())
);
