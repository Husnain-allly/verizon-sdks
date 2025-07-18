/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import {
  optional,
  Schema,
  string,
  typedExpandoObject,
  unknown,
} from '../schema';

/** Callback information of an existing diagnostics subscription. */
export interface DeviceDiagnosticsCallback {
  /** The name of the billing account for which callback messages will be sent. Format: "##########-#####". */
  accountName: string;
  /** The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL. */
  serviceName: string;
  /** The URL for your web server. */
  endpoint: string;
  /** The date and time of when this request was created. */
  createdOn: string;
  /** Your HTTP headers. */
  httpHeaders?: unknown;
  additionalProperties?: Record<string, unknown>;
}

export const deviceDiagnosticsCallbackSchema: Schema<DeviceDiagnosticsCallback> = typedExpandoObject(
  {
    accountName: ['accountName', string()],
    serviceName: ['serviceName', string()],
    endpoint: ['endpoint', string()],
    createdOn: ['createdOn', string()],
    httpHeaders: ['httpHeaders', optional(unknown())],
  },
  'additionalProperties',
  optional(unknown())
);
