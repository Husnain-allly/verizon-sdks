/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import {
  array,
  lazy,
  optional,
  Schema,
  string,
  typedExpandoObject,
  unknown,
} from '../schema';
import { V2TimeWindow, v2TimeWindowSchema } from './v2TimeWindow';

/** Software upgrade information. */
export interface CampaignSoftware {
  /** Upgrade identifier. */
  id: string;
  /** Account identifier. */
  accountName: string;
  /** Campaign name. */
  campaignName?: string;
  /** Software name. */
  softwareName: string;
  /** LWM2M, OMD-DM or HTTP. */
  distributionType: string;
  /** Applicable make. */
  make: string;
  /** Applicable model. */
  model: string;
  /** Old software name. */
  softwareFrom: string;
  /** New software name. */
  softwareTo: string;
  /** Campaign start date. */
  startDate: string;
  /** Campaign end date. */
  endDate: string;
  /** Specifies starting date client should download package. If null, client will download as soon as possible. */
  downloadAfterDate?: string;
  /** List of allowed download time windows. */
  downloadTimeWindowList?: V2TimeWindow[];
  /** Client will install package after date. If null, client will install as soon as possible. */
  installAfterDate?: string;
  /** List of allowed install time windows. */
  installTimeWindowList?: V2TimeWindow[];
  /** Software upgrade status. */
  status: string;
  additionalProperties?: Record<string, unknown>;
}

export const campaignSoftwareSchema: Schema<CampaignSoftware> = typedExpandoObject(
  {
    id: ['id', string()],
    accountName: ['accountName', string()],
    campaignName: ['campaignName', optional(string())],
    softwareName: ['softwareName', string()],
    distributionType: ['distributionType', string()],
    make: ['make', string()],
    model: ['model', string()],
    softwareFrom: ['softwareFrom', string()],
    softwareTo: ['softwareTo', string()],
    startDate: ['startDate', string()],
    endDate: ['endDate', string()],
    downloadAfterDate: ['downloadAfterDate', optional(string())],
    downloadTimeWindowList: [
      'downloadTimeWindowList',
      optional(array(lazy(() => v2TimeWindowSchema))),
    ],
    installAfterDate: ['installAfterDate', optional(string())],
    installTimeWindowList: [
      'installTimeWindowList',
      optional(array(lazy(() => v2TimeWindowSchema))),
    ],
    status: ['status', string()],
  },
  'additionalProperties',
  optional(unknown())
);
