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
  AccountGroupShareIndividual1,
  accountGroupShareIndividual1Schema,
} from './accountGroupShareIndividual1';

export interface AccountGroupShareObject {
  accountGroupShare?: AccountGroupShareIndividual1;
  additionalProperties?: Record<string, unknown>;
}

export const accountGroupShareObjectSchema: Schema<AccountGroupShareObject> = typedExpandoObject(
  {
    accountGroupShare: [
      'accountGroupShare',
      optional(lazy(() => accountGroupShareIndividual1Schema)),
    ],
  },
  'additionalProperties',
  optional(unknown())
);
