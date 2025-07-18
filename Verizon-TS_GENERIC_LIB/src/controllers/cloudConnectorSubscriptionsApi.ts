/**
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

import { ApiResponse, RequestOptions } from '../core';
import {
  CreateSubscriptionRequest,
  createSubscriptionRequestSchema,
} from '../models/createSubscriptionRequest';
import {
  DeleteSubscriptionRequest,
  deleteSubscriptionRequestSchema,
} from '../models/deleteSubscriptionRequest';
import {
  QuerySubscriptionRequest,
  querySubscriptionRequestSchema,
} from '../models/querySubscriptionRequest';
import { Subscription, subscriptionSchema } from '../models/subscription';
import { array } from '../schema';
import { BaseApi } from './baseApi';

export class CloudConnectorSubscriptionsApi extends BaseApi {
  /**
   * Create a subscription to define a streaming channel that sends data from devices in the account to
   * an endpoint defined in a target resource.
   *
   * @param body         The request body provides the details of the subscription
   *                                                         that you want to create.
   * @return Response from the API call
   */
  async createSubscription(
    body: CreateSubscriptionRequest,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<Subscription>> {
    const req = this.createRequest('POST', '/subscriptions');
    req.baseUrl('Cloud Connector');
    const mapped = req.prepareArgs({
      body: [body, createSubscriptionRequestSchema],
    });
    req.header('Content-Type', 'application/json');
    req.json(mapped.body);
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(subscriptionSchema, requestOptions);
  }

  /**
   * Search for subscriptions by property values. Returns an array of all matching subscription resources.
   *
   * @param body         The request body specifies fields and values to match.
   * @return Response from the API call
   */
  async querySubscription(
    body: QuerySubscriptionRequest,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<Subscription[]>> {
    const req = this.createRequest('POST', '/subscriptions/actions/query');
    req.baseUrl('Cloud Connector');
    const mapped = req.prepareArgs({
      body: [body, querySubscriptionRequestSchema],
    });
    req.header('Content-Type', 'application/json');
    req.json(mapped.body);
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.callAsJson(array(subscriptionSchema), requestOptions);
  }

  /**
   * Remove a subscription from a ThingSpace account.
   *
   * @param body         The request body identifies the subscription to delete.
   * @return Response from the API call
   */
  async deleteSubscription(
    body: DeleteSubscriptionRequest,
    requestOptions?: RequestOptions
  ): Promise<ApiResponse<void>> {
    const req = this.createRequest('POST', '/subscriptions/actions/delete');
    req.baseUrl('Cloud Connector');
    const mapped = req.prepareArgs({
      body: [body, deleteSubscriptionRequestSchema],
    });
    req.header('Content-Type', 'application/json');
    req.json(mapped.body);
    req.authenticate([{ thingspaceOauth: true, vzM2MToken: true }]);
    return req.call(requestOptions);
  }
}
