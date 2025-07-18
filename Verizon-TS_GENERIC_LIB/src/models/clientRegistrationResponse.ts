/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { lazy, object, Schema, string } from '../schema';
import { Certificate, certificateSchema } from './certificate';

/** Response for /clients/registration. It provides a generated device ID and the certificates needed to connect the ETX Message Exchange. */
export interface ClientRegistrationResponse {
  /**
   * The generated ID (UUID v4) for the device. It can be used as:
   *   - the MQTT Client ID when connecting to the Message Exchange system
   *   - a parameter when asking for the connection endpoint
   *   - a parameter when finishing the device registration
   *   - a parameter when unregistering the device
   */
  deviceId: string;
  /** Structure for the credentials required to connect to the ETX MQTT Message Exchange. */
  certificate: Certificate;
}

export const clientRegistrationResponseSchema: Schema<ClientRegistrationResponse> = object(
  {
    deviceId: ['DeviceID', string()],
    certificate: ['Certificate', lazy(() => certificateSchema)],
  }
);
