/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { lazy, object, optional, Schema } from '../schema';
import {
  Devicepropertyfilter,
  devicepropertyfilterSchema,
} from './devicepropertyfilter';

export interface ResourceResourceQuery {
  filter?: Devicepropertyfilter;
}

export const resourceResourceQuerySchema: Schema<ResourceResourceQuery> = object(
  { filter: ['filter', optional(lazy(() => devicepropertyfilterSchema))] }
);
