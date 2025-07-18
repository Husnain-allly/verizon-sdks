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
  AccountShareFilterCriteria1,
  accountShareFilterCriteria1Schema,
} from './accountShareFilterCriteria1';

export interface AccountShareFilterCriteria {
  filterCriteria?: AccountShareFilterCriteria1;
  additionalProperties?: Record<string, unknown>;
}

export const accountShareFilterCriteriaSchema: Schema<AccountShareFilterCriteria> = typedExpandoObject(
  {
    filterCriteria: [
      'filterCriteria',
      optional(lazy(() => accountShareFilterCriteria1Schema)),
    ],
  },
  'additionalProperties',
  optional(unknown())
);
