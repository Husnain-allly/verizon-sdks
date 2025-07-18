/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { array, lazy, object, optional, Schema, string } from '../schema';
import { DtoUserDto, dtoUserDtoSchema } from './dtoUserDto';

export interface DtoNotificationGroupResponseEntity {
  /** Timestamp of the record */
  createdon?: string;
  /** a short description */
  description?: string;
  /** UUID of the ECPD account the user belongs to */
  foreignid?: string;
  /** Contact email for the group */
  groupemail?: string;
  /** UUID of the user record, assigned at creation */
  id?: string;
  /** Timestamp of the record */
  lastupdated?: string;
  /** User defined name of the record */
  name?: string;
  users?: DtoUserDto[];
  /** The resource version */
  version?: string;
  /** The UUID of the resource version */
  versionid?: string;
}

export const dtoNotificationGroupResponseEntitySchema: Schema<DtoNotificationGroupResponseEntity> = object(
  {
    createdon: ['createdon', optional(string())],
    description: ['description', optional(string())],
    foreignid: ['foreignid', optional(string())],
    groupemail: ['groupemail', optional(string())],
    id: ['id', optional(string())],
    lastupdated: ['lastupdated', optional(string())],
    name: ['name', optional(string())],
    users: ['users', optional(array(lazy(() => dtoUserDtoSchema)))],
    version: ['version', optional(string())],
    versionid: ['versionid', optional(string())],
  }
);
