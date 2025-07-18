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
import { GioDeviceId, gioDeviceIdSchema } from './gioDeviceId';

export interface GioSmsMessage {
  deviceIds?: GioDeviceId[];
  message?: string;
  timestamp?: string;
  additionalProperties?: Record<string, unknown>;
}

export const gioSmsMessageSchema: Schema<GioSmsMessage> = typedExpandoObject(
  {
    deviceIds: ['deviceIds', optional(array(lazy(() => gioDeviceIdSchema)))],
    message: ['message', optional(string())],
    timestamp: ['timestamp', optional(string())],
  },
  'additionalProperties',
  optional(unknown())
);
