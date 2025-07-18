/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { array, lazy, object, optional, Schema, string } from '../schema';
import { DeviceId2, deviceId2Schema } from './deviceId2';
import {
  ProfileStatusFilter,
  profileStatusFilterSchema,
} from './profileStatusFilter';
import {
  ProvisioningStatusFilter,
  provisioningStatusFilterSchema,
} from './provisioningStatusFilter';

export interface EsimGlobalDeviceList {
  /** The numeric name of the account. */
  accountName?: string;
  /** The last status of the device as a list filter. */
  provisioningStatusFilter?: ProvisioningStatusFilter;
  /** The last status of the device's profile as a filter. */
  profileStatusFilter?: ProfileStatusFilter;
  /** The cellular service provider. */
  carrierNameFilter?: string;
  /** An array of device identifiers to filter the list. */
  deviceFilter?: DeviceId2[];
}

export const esimGlobalDeviceListSchema: Schema<EsimGlobalDeviceList> = object({
  accountName: ['accountName', optional(string())],
  provisioningStatusFilter: [
    'provisioningStatusFilter',
    optional(provisioningStatusFilterSchema),
  ],
  profileStatusFilter: [
    'profileStatusFilter',
    optional(profileStatusFilterSchema),
  ],
  carrierNameFilter: ['carrierNameFilter', optional(string())],
  deviceFilter: ['deviceFilter', optional(array(lazy(() => deviceId2Schema)))],
});
