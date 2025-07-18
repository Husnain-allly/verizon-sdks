/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import {
  array,
  number,
  optional,
  Schema,
  typedExpandoObject,
  unknown,
} from '../schema';
import { MultiPolygonType, multiPolygonTypeSchema } from './multiPolygonType';

/** A MultiPolygon is a type of geometry that represents a collection of Polygon geometries. */
export interface MultiPolygon {
  type: MultiPolygonType;
  coordinates: number[];
  additionalProperties?: Record<string, unknown>;
}

export const multiPolygonSchema: Schema<MultiPolygon> = typedExpandoObject(
  {
    type: ['type', multiPolygonTypeSchema],
    coordinates: ['coordinates', array(number())],
  },
  'additionalProperties',
  optional(unknown())
);
