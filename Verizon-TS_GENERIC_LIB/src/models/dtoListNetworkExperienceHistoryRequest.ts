/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { lazy, object, optional, Schema, string } from '../schema';
import { DtoFilter, dtoFilterSchema } from './dtoFilter';

export interface DtoListNetworkExperienceHistoryRequest {
  /** The numeric account name, which must include leading zeros */
  accountname?: string;
  filter?: DtoFilter;
}

export const dtoListNetworkExperienceHistoryRequestSchema: Schema<DtoListNetworkExperienceHistoryRequest> = object(
  {
    accountname: ['accountname', optional(string())],
    filter: ['filter', optional(lazy(() => dtoFilterSchema))],
  }
);
