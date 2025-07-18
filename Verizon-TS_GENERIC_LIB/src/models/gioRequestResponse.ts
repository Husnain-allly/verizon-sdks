/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { object, optional, Schema, string } from '../schema';

export interface GioRequestResponse {
  requestId?: string;
}

export const gioRequestResponseSchema: Schema<GioRequestResponse> = object({
  requestId: ['requestId', optional(string())],
});
