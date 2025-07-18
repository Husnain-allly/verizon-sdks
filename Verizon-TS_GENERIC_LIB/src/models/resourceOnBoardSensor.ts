/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { dict, object, optional, Schema, string, unknown } from '../schema';

export interface ResourceOnBoardSensor {
  /** the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer */
  deveui: string;
  /** global application ID in IEEE EUI64 address space that uniquely identifies the entity able to process the JoinReq frame */
  appeui: string;
  /** an encryption key used for messages during every over the air activation */
  appkey: string;
  /** Class of the sensor device. Valid values are Class A (A), Class B (B), and Class C (C). All LoRaWAN devices must implement Class A */
  mClass: string;
  /** The kind of sensor device */
  kind: string;
  description: string;
  name: string;
  /** Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action. */
  customdata?: Record<string, unknown>;
}

export const resourceOnBoardSensorSchema: Schema<ResourceOnBoardSensor> = object(
  {
    deveui: ['deveui', string()],
    appeui: ['appeui', string()],
    appkey: ['appkey', string()],
    mClass: ['class', string()],
    kind: ['kind', string()],
    description: ['description', string()],
    name: ['name', string()],
    customdata: ['customdata', optional(dict(unknown()))],
  }
);
