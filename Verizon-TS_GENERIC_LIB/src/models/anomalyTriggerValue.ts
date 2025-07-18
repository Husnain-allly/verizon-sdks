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
  string,
  typedExpandoObject,
  unknown,
} from '../schema';
import {
  TriggerAttributesOptions,
  triggerAttributesOptionsSchema,
} from './triggerAttributesOptions';

/** Trigger details. */
export interface AnomalyTriggerValue {
  /** The system assigned name of the trigger being updated. */
  triggerId?: string;
  /** The user defined name of the trigger. */
  triggerName?: string;
  /** The user assigned name of the organization associated with the trigger. */
  organizationName?: string;
  /** This is the value to use in the request body to detect anomalous behaivior. The values in this table will only be relevant when this parameter is set to this value. */
  triggerCategory?: string;
  /** Additional details and keys for the trigger. */
  triggerAttributes?: TriggerAttributesOptions[];
  /** Timestamp for whe the trigger was created. */
  createdAt?: string;
  /** Timestamp for the most recent time the trigger was modified. */
  modifiedAt?: string;
  additionalProperties?: Record<string, unknown>;
}

export const anomalyTriggerValueSchema: Schema<AnomalyTriggerValue> = typedExpandoObject(
  {
    triggerId: ['triggerId', optional(string())],
    triggerName: ['triggerName', optional(string())],
    organizationName: ['organizationName', optional(string())],
    triggerCategory: ['triggerCategory', optional(string())],
    triggerAttributes: [
      'triggerAttributes',
      optional(array(lazy(() => triggerAttributesOptionsSchema))),
    ],
    createdAt: ['createdAt', optional(string())],
    modifiedAt: ['modifiedAt', optional(string())],
  },
  'additionalProperties',
  optional(unknown())
);
