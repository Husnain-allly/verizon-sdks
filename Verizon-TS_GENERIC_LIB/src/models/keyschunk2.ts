/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import {
  boolean,
  number,
  optional,
  Schema,
  typedExpandoObject,
  unknown,
} from '../schema';

export interface Keyschunk2 {
  dataPercentage50?: boolean;
  dataPercentage75?: boolean;
  dataPercentage90?: boolean;
  dataPercentage100?: boolean;
  smsPercentage50?: boolean;
  smsPercentage75?: boolean;
  smsPercentage90?: boolean;
  smsPercentage100?: boolean;
  noOfDaysB4PromoExp?: number;
  additionalProperties?: Record<string, unknown>;
}

export const keyschunk2Schema: Schema<Keyschunk2> = typedExpandoObject(
  {
    dataPercentage50: ['dataPercentage50', optional(boolean())],
    dataPercentage75: ['dataPercentage75', optional(boolean())],
    dataPercentage90: ['dataPercentage90', optional(boolean())],
    dataPercentage100: ['dataPercentage100', optional(boolean())],
    smsPercentage50: ['smsPercentage50', optional(boolean())],
    smsPercentage75: ['smsPercentage75', optional(boolean())],
    smsPercentage90: ['smsPercentage90', optional(boolean())],
    smsPercentage100: ['smsPercentage100', optional(boolean())],
    noOfDaysB4PromoExp: ['NoOfDaysB4PromoExp', optional(number())],
  },
  'additionalProperties',
  optional(unknown())
);
