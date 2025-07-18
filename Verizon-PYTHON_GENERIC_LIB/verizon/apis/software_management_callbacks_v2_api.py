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
from verizon.models.callback_summary import CallbackSummary
from verizon.models.fota_v2_callback_registration_result import FotaV2CallbackRegistrationResult
from verizon.models.fota_v2_success_result import FotaV2SuccessResult
from verizon.exceptions.fota_v2_result_exception import FotaV2ResultException


class SoftwareManagementCallbacksV2Api(BaseApi):

    """A Controller to access Endpoints in the verizon API."""
    def __init__(self, config):
        super(SoftwareManagementCallbacksV2Api, self).__init__(config)

    def list_registered_callbacks(self,
                                  account):
        """Does a GET request to /callbacks/{account}.

        This endpoint allows user to get the registered callback information.

        Args:
            account (str): Account identifier.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Return
                callback registration.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SOFTWARE_MANAGEMENT_V2)
            .path('/callbacks/{account}')
            .http_method(HttpMethodEnum.GET)
            .template_param(Parameter()
                            .key('account')
                            .value(account)
                            .is_required(True)
                            .should_encode(True))
            .header_param(Parameter()
                          .key('accept')
                          .value('application/json'))
            .auth(And(Single('thingspace_oauth'), Single('VZ-M2M-Token')))
        ).response(
            ResponseHandler()
            .deserializer(APIHelper.json_deserialize)
            .deserialize_into(CallbackSummary.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Unexpected error.', FotaV2ResultException)
        ).execute()

    def update_callback(self,
                        account,
                        body):
        """Does a PUT request to /callbacks/{account}.

        This endpoint allows user to update the HTTPS callback address.

        Args:
            account (str): Account identifier.
            body (FotaV2CallbackRegistrationRequest): Callback URL
                registration.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Return
                callback registration.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SOFTWARE_MANAGEMENT_V2)
            .path('/callbacks/{account}')
            .http_method(HttpMethodEnum.PUT)
            .template_param(Parameter()
                            .key('account')
                            .value(account)
                            .is_required(True)
                            .should_encode(True))
            .header_param(Parameter()
                          .key('Content-Type')
                          .value('*/*'))
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
            .deserialize_into(FotaV2CallbackRegistrationResult.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Unexpected error.', FotaV2ResultException)
        ).execute()

    def register_callback(self,
                          account,
                          body):
        """Does a POST request to /callbacks/{account}.

        This endpoint allows user to create the HTTPS callback address.

        Args:
            account (str): Account identifier.
            body (FotaV2CallbackRegistrationRequest): Callback URL
                registration.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Return
                callback registration.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SOFTWARE_MANAGEMENT_V2)
            .path('/callbacks/{account}')
            .http_method(HttpMethodEnum.POST)
            .template_param(Parameter()
                            .key('account')
                            .value(account)
                            .is_required(True)
                            .should_encode(True))
            .header_param(Parameter()
                          .key('Content-Type')
                          .value('*/*'))
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
            .deserialize_into(FotaV2CallbackRegistrationResult.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Unexpected error.', FotaV2ResultException)
        ).execute()

    def deregister_callback(self,
                            account):
        """Does a DELETE request to /callbacks/{account}.

        This endpoint allows user to delete a previously registered callback
        URL.

        Args:
            account (str): Account identifier.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Result of
                deregistering a callback.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SOFTWARE_MANAGEMENT_V2)
            .path('/callbacks/{account}')
            .http_method(HttpMethodEnum.DELETE)
            .template_param(Parameter()
                            .key('account')
                            .value(account)
                            .is_required(True)
                            .should_encode(True))
            .header_param(Parameter()
                          .key('accept')
                          .value('application/json'))
            .auth(And(Single('thingspace_oauth'), Single('VZ-M2M-Token')))
        ).response(
            ResponseHandler()
            .deserializer(APIHelper.json_deserialize)
            .deserialize_into(FotaV2SuccessResult.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Unexpected error.', FotaV2ResultException)
        ).execute()
