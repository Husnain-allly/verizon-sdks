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
import { DeviceList, deviceListSchema } from './deviceList';

export interface ProfileChangeStateRequest {
  devices: DeviceList[];
  accountName: string;
  smsrOid: string;
  additionalProperties?: Record<string, unknown>;
}

export const profileChangeStateRequestSchema: Schema<ProfileChangeStateRequest> = typedExpandoObject(
  {
    devices: ['devices', array(lazy(() => deviceListSchema))],
    accountName: ['accountName', string()],
    smsrOid: ['smsrOid', string()],
  },
  'additionalProperties',
  optional(unknown())
);
