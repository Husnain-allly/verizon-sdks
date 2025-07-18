/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { lazy, object, optional, Schema, string } from '../schema';
import { Active, activeSchema } from './active';
import { DataTrigger2, dataTrigger2Schema } from './dataTrigger2';
import {
  Notificationarray,
  notificationarraySchema,
} from './notificationarray';
import { TriggerCategory, triggerCategorySchema } from './triggerCategory';

export interface DeviceLevelUpdateTriggerRequest {
  /** The system assigned UUID of the trigger */
  triggerId?: string;
  /** The user defined name of the trigger */
  triggerName?: string;
  /** The Enterprise Customer Profile Database ID */
  ecpdId?: string;
  /** The type of trigger being created or modified */
  triggerCategory?: TriggerCategory;
  dataTrigger?: DataTrigger2;
  notification?: Notificationarray;
  /** A flag to indicate of the trigger is active, true, or not, false */
  active?: Active;
}

export const deviceLevelUpdateTriggerRequestSchema: Schema<DeviceLevelUpdateTriggerRequest> = object(
  {
    triggerId: ['triggerId', optional(string())],
    triggerName: ['triggerName', optional(string())],
    ecpdId: ['ecpdId', optional(string())],
    triggerCategory: ['triggerCategory', optional(triggerCategorySchema)],
    dataTrigger: ['dataTrigger', optional(lazy(() => dataTrigger2Schema))],
    notification: [
      'notification',
      optional(lazy(() => notificationarraySchema)),
    ],
    active: ['active', optional(activeSchema)],
  }
);
