/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import {
  array,
  optional,
  Schema,
  string,
  typedExpandoObject,
  unknown,
} from '../schema';

export interface DtoRemoveUsersFromNotificationGroupRequest {
  /** The numeric account name, which must include leading zeros */
  accountname?: string;
  /** UUID of the user record, assigned at creation */
  id?: string;
  userids?: string[];
  additionalProperties?: Record<string, unknown>;
}

export const dtoRemoveUsersFromNotificationGroupRequestSchema: Schema<DtoRemoveUsersFromNotificationGroupRequest> = typedExpandoObject(
  {
    accountname: ['accountname', optional(string())],
    id: ['id', optional(string())],
    userids: ['userids', optional(array(string()))],
  },
  'additionalProperties',
  optional(unknown())
);
