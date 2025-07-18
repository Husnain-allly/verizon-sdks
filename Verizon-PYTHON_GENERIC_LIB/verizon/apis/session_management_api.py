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
from verizon.models.log_in_result import LogInResult
from verizon.models.log_out_request import LogOutRequest
from verizon.models.session_reset_password_result import SessionResetPasswordResult
from verizon.exceptions.connectivity_management_result_exception import ConnectivityManagementResultException


class SessionManagementApi(BaseApi):

    """A Controller to access Endpoints in the verizon API."""
    def __init__(self, config):
        super(SessionManagementApi, self).__init__(config)

    def start_connectivity_management_session(self,
                                              body=None):
        """Does a POST request to /m2m/v1/session/login.

        Initiates a Connectivity Management session and returns a VZ-M2M
        session token that is required in subsequent API requests.

        Args:
            body (LogInRequest, optional): Request to initiate a session.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. VZ-M2M
                session token.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.THINGSPACE)
            .path('/m2m/v1/session/login')
            .http_method(HttpMethodEnum.POST)
            .header_param(Parameter()
                          .key('Content-Type')
                          .value('application/json'))
            .body_param(Parameter()
                        .value(body))
            .header_param(Parameter()
                          .key('accept')
                          .value('application/json'))
            .body_serializer(APIHelper.json_serialize)
            .auth(Single('thingspace_oauth'))
        ).response(
            ResponseHandler()
            .deserializer(APIHelper.json_deserialize)
            .deserialize_into(LogInResult.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Error response.', ConnectivityManagementResultException)
        ).execute()

    def end_connectivity_management_session(self):
        """Does a POST request to /m2m/v1/session/logout.

        Ends a Connectivity Management session.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. VZ-M2M
                session token.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.THINGSPACE)
            .path('/m2m/v1/session/logout')
            .http_method(HttpMethodEnum.POST)
            .header_param(Parameter()
                          .key('accept')
                          .value('application/json'))
            .auth(And(Single('thingspace_oauth'), Single('VZ-M2M-Token')))
        ).response(
            ResponseHandler()
            .deserializer(APIHelper.json_deserialize)
            .deserialize_into(LogOutRequest.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Error response.', ConnectivityManagementResultException)
        ).execute()

    def reset_connectivity_management_password(self,
                                               body):
        """Does a PUT request to /m2m/v1/session/password/actions/reset.

        The new password is effective immediately. Passwords do not expire,
        but Verizon recommends changing your password every 90 days.

        Args:
            body (SessionResetPasswordRequest): Request with current password
                that needs to be reset.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Returns a
                new, randomly generated password for the current username.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.THINGSPACE)
            .path('/m2m/v1/session/password/actions/reset')
            .http_method(HttpMethodEnum.PUT)
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
            .deserialize_into(SessionResetPasswordResult.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Error response.', ConnectivityManagementResultException)
        ).execute()
