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
from verizon.models.oauth_token import OauthToken
from verizon.exceptions.oauth_provider_exception import OauthProviderException


class OauthAuthorizationApi(BaseApi):

    """A Controller to access Endpoints in the verizon API."""
    def __init__(self, config):
        super(OauthAuthorizationApi, self).__init__(config)

    def request_token_thingspace_oauth(self,
                                       authorization,
                                       scope=None,
                                       _optional_form_parameters=None):
        """Does a POST request to /oauth2/token.

        Create a new OAuth 2 token.

        Args:
            authorization (str): Authorization header in Basic auth format
            scope (str, optional): Requested scopes as a space-delimited list.
            _optional_form_parameters (Array, optional): Additional optional
                form parameters are supported by this endpoint

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.OAUTH_SERVER)
            .path('/oauth2/token')
            .http_method(HttpMethodEnum.POST)
            .form_param(Parameter()
                        .key('grant_type')
                        .value('client_credentials'))
            .header_param(Parameter()
                          .key('Authorization')
                          .value(authorization)
                          .is_required(True))
            .form_param(Parameter()
                        .key('scope')
                        .value(scope))
            .header_param(Parameter()
                          .key('content-type')
                          .value('application/x-www-form-urlencoded'))
            .header_param(Parameter()
                          .key('accept')
                          .value('application/json'))
            .additional_form_params(_optional_form_parameters)
        ).response(
            ResponseHandler()
            .deserializer(APIHelper.json_deserialize)
            .deserialize_into(OauthToken.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'OAuth 2 provider returned an error.', OauthProviderException)
            .local_error('401', 'OAuth 2 provider says client authentication failed.', OauthProviderException)
        ).execute()

    def request_token_thingspace_oauth_1(self,
                                         authorization,
                                         scope=None,
                                         _optional_form_parameters=None):
        """Does a POST request to /.

        Create a new OAuth 2 token.

        Args:
            authorization (str): Authorization header in Basic auth format
            scope (str, optional): Requested scopes as a space-delimited list.
            _optional_form_parameters (Array, optional): Additional optional
                form parameters are supported by this endpoint

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.OAUTH_SERVER)
            .path('/')
            .http_method(HttpMethodEnum.POST)
            .form_param(Parameter()
                        .key('grant_type')
                        .value('client_credentials'))
            .header_param(Parameter()
                          .key('Authorization')
                          .value(authorization)
                          .is_required(True))
            .form_param(Parameter()
                        .key('scope')
                        .value(scope))
            .header_param(Parameter()
                          .key('content-type')
                          .value('application/x-www-form-urlencoded'))
            .header_param(Parameter()
                          .key('accept')
                          .value('application/json'))
            .additional_form_params(_optional_form_parameters)
        ).response(
            ResponseHandler()
            .deserializer(APIHelper.json_deserialize)
            .deserialize_into(OauthToken.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'OAuth 2 provider returned an error.', OauthProviderException)
            .local_error('401', 'OAuth 2 provider says client authentication failed.', OauthProviderException)
        ).execute()
