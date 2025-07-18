# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""

from verizon.api_helper import APIHelper
from verizon.configuration import Server
from verizon.http.api_response import ApiResponse
from verizon.apis.base_api import BaseApi
from apimatic_core.request_builder import RequestBuilder
from apimatic_core.response_handler import ResponseHandler
from apimatic_core.types.parameter import Parameter
from verizon.http.http_method_enum import HttpMethodEnum
from apimatic_core.authentication.multiple.single_auth import Single
from apimatic_core.authentication.multiple.and_auth_group import And
from verizon.models.subscription import Subscription


class CloudConnectorSubscriptionsApi(BaseApi):

    """A Controller to access Endpoints in the verizon API."""
    def __init__(self, config):
        super(CloudConnectorSubscriptionsApi, self).__init__(config)

    def create_subscription(self,
                            body):
        """Does a POST request to /subscriptions.

        Create a subscription to define a streaming channel that sends data
        from devices in the account to an endpoint defined in a target
        resource.

        Args:
            body (CreateSubscriptionRequest): The request body provides the
                details of the subscription that you want to create.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Returns
                full subscription resource definition.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.CLOUD_CONNECTOR)
            .path('/subscriptions')
            .http_method(HttpMethodEnum.POST)
            .header_param(Parameter()
                          .key('Content-Type')
                          .value('application/json'))
            .body_param(Parameter()
                        .value(body)
                        .is_required(True))
            .header_param(Parameter()
                          .key('accept')
                          .value('application/json'))
            .body_serializer(APIHelper.json_serialize)
            .auth(And(Single('thingspace_oauth'), Single('VZ-M2M-Token')))
        ).response(
            ResponseHandler()
            .deserializer(APIHelper.json_deserialize)
            .deserialize_into(Subscription.from_dictionary)
            .is_api_response(True)
        ).execute()

    def query_subscription(self,
                           body):
        """Does a POST request to /subscriptions/actions/query.

        Search for subscriptions by property values. Returns an array of all
        matching subscription resources.

        Args:
            body (QuerySubscriptionRequest): The request body specifies fields
                and values to match.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Returns
                an array of all matching subscriptions. Each subscription
                includes the full subscription resource definition.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.CLOUD_CONNECTOR)
            .path('/subscriptions/actions/query')
            .http_method(HttpMethodEnum.POST)
            .header_param(Parameter()
                          .key('Content-Type')
                          .value('application/json'))
            .body_param(Parameter()
                        .value(body)
                        .is_required(True))
            .header_param(Parameter()
                          .key('accept')
                          .value('application/json'))
            .body_serializer(APIHelper.json_serialize)
            .auth(And(Single('thingspace_oauth'), Single('VZ-M2M-Token')))
        ).response(
            ResponseHandler()
            .deserializer(APIHelper.json_deserialize)
            .deserialize_into(Subscription.from_dictionary)
            .is_api_response(True)
        ).execute()

    def delete_subscription(self,
                            body):
        """Does a POST request to /subscriptions/actions/delete.

        Remove a subscription from a ThingSpace account.

        Args:
            body (DeleteSubscriptionRequest): The request body identifies the
                subscription to delete.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers.
                Subscription deleted successfully.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.CLOUD_CONNECTOR)
            .path('/subscriptions/actions/delete')
            .http_method(HttpMethodEnum.POST)
            .header_param(Parameter()
                          .key('Content-Type')
                          .value('application/json'))
            .body_param(Parameter()
                        .value(body)
                        .is_required(True))
            .body_serializer(APIHelper.json_serialize)
            .auth(And(Single('thingspace_oauth'), Single('VZ-M2M-Token')))
        ).response(
            ResponseHandler()
            .is_api_response(True)
        ).execute()
