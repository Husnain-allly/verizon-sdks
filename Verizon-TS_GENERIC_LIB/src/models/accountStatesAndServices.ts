/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import {
  array,
  lazy,
  optional,
  Schema,
  typedExpandoObject,
  unknown,
} from '../schema';
import { Engagement, engagementSchema } from './engagement';

/** Returns a list and details of all custom services and states defined for a specified account. */
export interface AccountStatesAndServices {
  /** The engagements associated with the account. */
  engagement: Engagement[];
  additionalProperties?: Record<string, unknown>;
}

export const accountStatesAndServicesSchema: Schema<AccountStatesAndServices> = typedExpandoObject(
  { engagement: ['engagement', array(lazy(() => engagementSchema))] },
  'additionalProperties',
  optional(unknown())
);
