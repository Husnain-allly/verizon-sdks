/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { ApiError } from '../core';

/**
 * Creates an instance of Management
 */
interface Management {
  error?: string;
  error_description?: string;
  cause?: string;
  additionalProperties?: Record<string, unknown>;
}

export class ManagementError extends ApiError<Management> {}
