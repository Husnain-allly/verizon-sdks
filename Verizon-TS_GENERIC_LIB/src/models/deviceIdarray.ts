/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import {
  optional,
  Schema,
  string,
  typedExpandoObject,
  unknown,
} from '../schema';

export interface DeviceIdarray {
  kind?: string;
  id?: string;
  additionalProperties?: Record<string, unknown>;
}

export const deviceIdarraySchema: Schema<DeviceIdarray> = typedExpandoObject(
  { kind: ['kind', optional(string())], id: ['id', optional(string())] },
  'additionalProperties',
  optional(unknown())
);
