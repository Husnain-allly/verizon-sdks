/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import {
  lazy,
  nullable,
  optional,
  Schema,
  typedExpandoObject,
  unknown,
} from '../schema';
import { Speed, speedSchema } from './speed';

/**
 * Defines the acceptable speed range for road users in m/s. Messages are triggered when:
 *     1. The road user's speed is below the required minimum OR
 *     2. The road user's speed is above the acceptable maximum AND
 *     3. The associated TriggerConditions are met.
 * Example: For the speed range of 10-20 m/s and a TriggerCondition of 'user inside geofence', the message is sent if the user's speed is below 10 m/s or above 20 m/s while in the geofence area.
 */
export interface SpeedItem {
  speed: Speed | null;
  additionalProperties?: Record<string, unknown>;
}

export const speedItemSchema: Schema<SpeedItem> = typedExpandoObject(
  { speed: ['speed', nullable(lazy(() => speedSchema))] },
  'additionalProperties',
  optional(unknown())
);
