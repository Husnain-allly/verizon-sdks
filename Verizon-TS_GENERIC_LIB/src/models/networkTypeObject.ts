/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { object, optional, Schema, string } from '../schema';

/** Network type. */
export interface NetworkTypeObject {
  networkType?: string;
}

export const networkTypeObjectSchema: Schema<NetworkTypeObject> = object({
  networkType: ['networkType', optional(string())],
});
