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
  DtoOffBoardSensor,
  dtoOffBoardSensorSchema,
} from './dtoOffBoardSensor';

/** The configuration of the remove request */
export interface Sensorinsightsconfig {
  /** The EUI64 address of the device being removed */
  removesensor?: DtoOffBoardSensor;
  additionalProperties?: Record<string, unknown>;
}

export const sensorinsightsconfigSchema: Schema<Sensorinsightsconfig> = typedExpandoObject(
  {
    removesensor: [
      'removesensor',
      optional(lazy(() => dtoOffBoardSensorSchema)),
    ],
  },
  'additionalProperties',
  optional(unknown())
);
