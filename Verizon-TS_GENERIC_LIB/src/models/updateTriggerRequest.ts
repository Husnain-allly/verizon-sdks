/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { boolean, lazy, object, optional, Schema, string } from '../schema';
import {
  AnomalyTriggerRequest,
  anomalyTriggerRequestSchema,
} from './anomalyTriggerRequest';
import { CycleType, cycleTypeSchema } from './cycleType';
import {
  DataTriggerRequest,
  dataTriggerRequestSchema,
} from './dataTriggerRequest';
import {
  PromoAlertTriggerRequest,
  promoAlertTriggerRequestSchema,
} from './promoAlertTriggerRequest';
import {
  SessionTriggerRequest,
  sessionTriggerRequestSchema,
} from './sessionTriggerRequest';
import {
  SmsTriggerRequest,
  smsTriggerRequestSchema,
} from './smsTriggerRequest';

export interface UpdateTriggerRequest {
  accountName?: string;
  active?: boolean;
  /** The details of the UsageAnomaly trigger. */
  anomalyTriggerRequest?: AnomalyTriggerRequest;
  cycleType?: CycleType;
  dataTriggerRequest?: DataTriggerRequest;
  groupName?: string;
  promoAlertTriggerRequest?: PromoAlertTriggerRequest;
  sessionTriggerRequest?: SessionTriggerRequest;
  smsTriggerRequest?: SmsTriggerRequest;
  triggerCategory?: string;
  triggerId?: string;
  triggerName?: string;
}

export const updateTriggerRequestSchema: Schema<UpdateTriggerRequest> = object({
  accountName: ['accountName', optional(string())],
  active: ['active', optional(boolean())],
  anomalyTriggerRequest: [
    'anomalyTriggerRequest',
    optional(lazy(() => anomalyTriggerRequestSchema)),
  ],
  cycleType: ['cycleType', optional(cycleTypeSchema)],
  dataTriggerRequest: [
    'dataTriggerRequest',
    optional(lazy(() => dataTriggerRequestSchema)),
  ],
  groupName: ['groupName', optional(string())],
  promoAlertTriggerRequest: [
    'promoAlertTriggerRequest',
    optional(lazy(() => promoAlertTriggerRequestSchema)),
  ],
  sessionTriggerRequest: [
    'sessionTriggerRequest',
    optional(lazy(() => sessionTriggerRequestSchema)),
  ],
  smsTriggerRequest: [
    'smsTriggerRequest',
    optional(lazy(() => smsTriggerRequestSchema)),
  ],
  triggerCategory: ['triggerCategory', optional(string())],
  triggerId: ['triggerId', optional(string())],
  triggerName: ['triggerName', optional(string())],
});
