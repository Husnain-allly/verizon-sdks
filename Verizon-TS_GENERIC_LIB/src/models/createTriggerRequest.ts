/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { lazy, object, optional, Schema, string } from '../schema';
import {
  AnomalyTriggerRequest,
  anomalyTriggerRequestSchema,
} from './anomalyTriggerRequest';
import {
  DataTriggerRequest,
  dataTriggerRequestSchema,
} from './dataTriggerRequest';
import {
  SessionTriggerRequest,
  sessionTriggerRequestSchema,
} from './sessionTriggerRequest';
import {
  SmsTriggerRequest,
  smsTriggerRequestSchema,
} from './smsTriggerRequest';

export interface CreateTriggerRequest {
  accountName?: string;
  /** The details of the UsageAnomaly trigger. */
  anomalyTriggerRequest?: AnomalyTriggerRequest;
  dataTriggerRequest?: DataTriggerRequest;
  groupName?: string;
  name?: string;
  sessionTriggerRequest?: SessionTriggerRequest;
  smsTriggerRequest?: SmsTriggerRequest;
  triggerCategory?: string;
  triggerCycle?: string;
}

export const createTriggerRequestSchema: Schema<CreateTriggerRequest> = object({
  accountName: ['accountName', optional(string())],
  anomalyTriggerRequest: [
    'anomalyTriggerRequest',
    optional(lazy(() => anomalyTriggerRequestSchema)),
  ],
  dataTriggerRequest: [
    'dataTriggerRequest',
    optional(lazy(() => dataTriggerRequestSchema)),
  ],
  groupName: ['groupName', optional(string())],
  name: ['name', optional(string())],
  sessionTriggerRequest: [
    'sessionTriggerRequest',
    optional(lazy(() => sessionTriggerRequestSchema)),
  ],
  smsTriggerRequest: [
    'smsTriggerRequest',
    optional(lazy(() => smsTriggerRequestSchema)),
  ],
  triggerCategory: ['triggerCategory', optional(string())],
  triggerCycle: ['triggerCycle', optional(string())],
});
