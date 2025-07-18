/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { Schema, stringEnum } from '../schema';

/**
 * Enum for ProfileStatusFilter
 */
export enum ProfileStatusFilter {
  Enable = 'ENABLE',
  Disable = 'DISABLE',
  DownloadDisable = 'DOWNLOAD_DISABLE',
  DownloadEnable = 'DOWNLOAD_ENABLE',
  NotDownloaded = 'NOT_DOWNLOADED',
  Unknown = 'UNKNOWN',
  Delete = 'DELETE',
}

/**
 * Schema for ProfileStatusFilter
 */
export const profileStatusFilterSchema: Schema<ProfileStatusFilter> = stringEnum(
  ProfileStatusFilter
);
