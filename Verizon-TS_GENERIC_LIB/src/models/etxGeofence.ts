/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { array, lazy, object, Schema } from '../schema';
import {
  FeatureCollectionType,
  featureCollectionTypeSchema,
} from './featureCollectionType';
import { GeoFeature, geoFeatureSchema } from './geoFeature';

/** The GeoJSON representation of geofence. Geofence supports the following geometry types: LineString, Polygon, MultiLineString, and MultiPolygon. The system only supports a single Feature in the FeatureCollection, so only one Line, Polygon, MultiLine or MultiPolygon can be defined within one Geofencing configuration. */
export interface EtxGeofence {
  type: FeatureCollectionType;
  features: GeoFeature[];
}

export const etxGeofenceSchema: Schema<EtxGeofence> = object({
  type: ['type', featureCollectionTypeSchema],
  features: ['features', array(lazy(() => geoFeatureSchema))],
});
