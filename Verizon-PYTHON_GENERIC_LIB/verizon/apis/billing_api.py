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
from verizon.models.managed_accounts_add_response import ManagedAccountsAddResponse
from verizon.models.managed_accounts_provision_response import ManagedAccountsProvisionResponse
from verizon.models.managed_account_cancel_response import ManagedAccountCancelResponse
from verizon.models.managed_accounts_get_all_response import ManagedAccountsGetAllResponse
from verizon.exceptions.device_location_result_exception import DeviceLocationResultException


class BillingApi(BaseApi):

    """A Controller to access Endpoints in the verizon API."""
    def __init__(self, config):
        super(BillingApi, self).__init__(config)

    def add_account(self,
                    body):
        """Does a POST request to /managedaccounts/actions/add.

        This endpoint allows user to add managed accounts to a primary account.

        Args:
            body (ManagedAccountsAddRequest): Service name and list of
                accounts to add

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Add
                managed accounts response

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SUBSCRIPTION_SERVER)
            .path('/managedaccounts/actions/add')
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
            .deserialize_into(ManagedAccountsAddResponse.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Unexpected error', DeviceLocationResultException)
        ).execute()

    def managed_account_action(self,
                               body):
        """Does a POST request to /managedaccounts/actions/provision.

        Activates a managed billing service relationship between a managed
        account and the primary account.

        Args:
            body (ManagedAccountsProvisionRequest): Service name and list of
                accounts to add

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Managed
                account provision response

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SUBSCRIPTION_SERVER)
            .path('/managedaccounts/actions/provision')
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
            .deserialize_into(ManagedAccountsProvisionResponse.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Unexpected error', DeviceLocationResultException)
        ).execute()

    def cancel_managed_account_action(self,
                                      body):
        """Does a POST request to /managedaccounts/actions/cancel.

        Deactivates a managed billing service relationship between a managed
        account and the primary account. 

        Args:
            body (ManagedAccountCancelRequest): Service name and list of
                accounts to add

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Managed
                account cancel response

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SUBSCRIPTION_SERVER)
            .path('/managedaccounts/actions/cancel')
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
            .deserialize_into(ManagedAccountCancelResponse.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Unexpected error', DeviceLocationResultException)
        ).execute()

    def list_managed_account(self,
                             account_name,
                             service_name):
        """Does a GET request to /managedaccounts/{accountName}/service/{serviceName}.

        This endpoint allows user to retrieve the list of all accounts managed
        by a primary account.

        Args:
            account_name (str): Primary account identifier
            service_name (str): Service name

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. List of
                managed accounts

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SUBSCRIPTION_SERVER)
            .path('/managedaccounts/{accountName}/service/{serviceName}')
            .http_method(HttpMethodEnum.GET)
            .template_param(Parameter()
                            .key('accountName')
                            .value(account_name)
                            .is_required(True)
                            .should_encode(True))
            .template_param(Parameter()
                            .key('serviceName')
                            .value(service_name)
                            .is_required(True)
                            .should_encode(True))
            .header_param(Parameter()
                          .key('accept')
                          .value('application/json'))
            .auth(And(Single('thingspace_oauth'), Single('VZ-M2M-Token')))
        ).response(
            ResponseHandler()
            .deserializer(APIHelper.json_deserialize)
            .deserialize_into(ManagedAccountsGetAllResponse.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Unexpected error', DeviceLocationResultException)
        ).execute()
