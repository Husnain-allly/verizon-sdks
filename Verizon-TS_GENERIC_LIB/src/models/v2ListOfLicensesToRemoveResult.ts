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
  string,
  typedExpandoObject,
  unknown,
} from '../schema';

/** List of created license cancellation devices. */
export interface V2ListOfLicensesToRemoveResult {
  /** The number of devices. */
  count: number;
  /** Device IMEI list. */
  deviceList: string[];
  additionalProperties?: Record<string, unknown>;
}

export const v2ListOfLicensesToRemoveResultSchema: Schema<V2ListOfLicensesToRemoveResult> = typedExpandoObject(
  { count: ['count', number()], deviceList: ['deviceList', array(string())] },
  'additionalProperties',
  optional(unknown())
);
