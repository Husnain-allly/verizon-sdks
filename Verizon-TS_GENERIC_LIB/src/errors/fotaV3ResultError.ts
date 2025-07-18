/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { ApiError } from '../core';

/**
 * Creates an instance of FotaV3Result
 */
interface FotaV3Result {
  /** Error code string. */
  errorCode: string;
  /** Error message string. */
  errorMessage: string;
  additionalProperties?: Record<string, unknown>;
}

export class FotaV3ResultError extends ApiError<FotaV3Result> {}
