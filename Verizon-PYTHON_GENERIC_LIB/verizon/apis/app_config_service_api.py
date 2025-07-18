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
from verizon.models.configuration_list_item import ConfigurationListItem
from verizon.models.geo_fence_configuration_response import GeoFenceConfigurationResponse
from verizon.exceptions.app_config_response_error_exception import AppConfigResponseErrorException


class AppConfigServiceApi(BaseApi):

    """A Controller to access Endpoints in the verizon API."""
    def __init__(self, config):
        super(AppConfigServiceApi, self).__init__(config)

    def get_configuration_list(self,
                               vendor_id):
        """Does a GET request to /api/v1/application/configurations/geofence/ids.

        This endpoint fetches and returns the list of configurations defined
        by the Vendor. The list contains the configurations' identifier, name,
        description, and active flag. The vendor ID is provided when the
        configuration is created through the POST request.
        Note: The user needs to authenticate with their ThingSpace credentials
        using the Access/Bearer and Session/M2M tokens in order to call this
        API.

        Args:
            vendor_id (str): The vendor's identifier

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers.
                Configuration list was queried successfully

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.IMP_SERVER)
            .path('/api/v1/application/configurations/geofence/ids')
            .http_method(HttpMethodEnum.GET)
            .header_param(Parameter()
                          .key('VendorID')
                          .value(vendor_id)
                          .is_required(True))
            .header_param(Parameter()
                          .key('accept')
                          .value('application/json'))
            .auth(And(Single('thingspace_oauth'), Single('SessionToken')))
        ).response(
            ResponseHandler()
            .deserializer(APIHelper.json_deserialize)
            .deserialize_into(ConfigurationListItem.from_dictionary)
            .is_api_response(True)
            .local_error('403', 'Forbidden', AppConfigResponseErrorException)
            .local_error('404', 'Configuration not found', AppConfigResponseErrorException)
            .local_error('429', 'Too many requests', AppConfigResponseErrorException)
            .local_error('default', 'unexpected error', AppConfigResponseErrorException)
        ).execute()

    def get_configuration(self,
                          id,
                          vendor_id):
        """Does a GET request to /api/v1/application/configurations/geofence.

        This endpoint fetches and returns a specific configuration's details.
        The configuration ID parameter, which was provided when the
        configuration was created through the POST request, is need to
        retrieve the configuration details.
        Note: The user needs to authenticate with their ThingSpace credentials
        using the Access/Bearer and Session/M2M tokens in order to call this
        API.

        Args:
            id (str): The configuration identifier
            vendor_id (str): The vendor's identifier

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers.
                Configuration found

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.IMP_SERVER)
            .path('/api/v1/application/configurations/geofence')
            .http_method(HttpMethodEnum.GET)
            .query_param(Parameter()
                         .key('id')
                         .value(id)
                         .is_required(True))
            .header_param(Parameter()
                          .key('VendorID')
                          .value(vendor_id)
                          .is_required(True))
            .header_param(Parameter()
                          .key('accept')
                          .value('application/json'))
            .auth(And(Single('thingspace_oauth'), Single('SessionToken')))
        ).response(
            ResponseHandler()
            .deserializer(APIHelper.json_deserialize)
            .deserialize_into(GeoFenceConfigurationResponse.from_dictionary)
            .is_api_response(True)
            .local_error('403', 'Forbidden', AppConfigResponseErrorException)
            .local_error('404', 'Configuration not found', AppConfigResponseErrorException)
            .local_error('429', 'Too many requests', AppConfigResponseErrorException)
            .local_error('default', 'unexpected error', AppConfigResponseErrorException)
        ).execute()

    def create_configuration(self,
                             vendor_id,
                             body):
        """Does a POST request to /api/v1/application/configurations/geofence.

        This endpoint creates a new configuration in the system. The data for
        the new configuration should be provided as JSON in the body of the
        POST request. The system will return with a unique ID for the
        configuration, which is needed for any further manipulation (update or
        delete) of the configuration.
        Note: The user needs to authenticate with their ThingSpace credentials
        using the Access/Bearer and Session/M2M tokens in order to call this
        API.

        Args:
            vendor_id (str): The vendor's identifier
            body (GeoFenceConfigurationRequest): The request body parameter.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers.
                Configuration created

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.IMP_SERVER)
            .path('/api/v1/application/configurations/geofence')
            .http_method(HttpMethodEnum.POST)
            .header_param(Parameter()
                          .key('VendorID')
                          .value(vendor_id)
                          .is_required(True))
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
            .auth(And(Single('thingspace_oauth'), Single('SessionToken')))
        ).response(
            ResponseHandler()
            .deserializer(APIHelper.json_deserialize)
            .deserialize_into(GeoFenceConfigurationResponse.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Invalid configuration', AppConfigResponseErrorException)
            .local_error('403', 'Forbidden', AppConfigResponseErrorException)
            .local_error('429', 'Too many requests', AppConfigResponseErrorException)
            .local_error('default', 'unexpected error', AppConfigResponseErrorException)
        ).execute()

    def update_configuration(self,
                             vendor_id,
                             id,
                             body):
        """Does a PUT request to /api/v1/application/configurations/geofence.

        This endpoint updates an existing configuration. Similar to POST, the
        updated data for the configuration should be provided as JSON in the
        body of the PUT request. The configuration ID parameter, which was
        provided by the POST (create) operation, is required to do any updates
        on the configuration.
        Note: The user needs to authenticate with their ThingSpace credentials
        using the Access/Bearer and Session/M2M tokens in order to call this
        API.

        Args:
            vendor_id (str): The vendor's identifier
            id (str): The configuration identifier
            body (GeoFenceConfigurationUpdateRequest): The request body
                parameter.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers.
                Configuration applied

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.IMP_SERVER)
            .path('/api/v1/application/configurations/geofence')
            .http_method(HttpMethodEnum.PUT)
            .header_param(Parameter()
                          .key('VendorID')
                          .value(vendor_id)
                          .is_required(True))
            .query_param(Parameter()
                         .key('id')
                         .value(id)
                         .is_required(True))
            .header_param(Parameter()
                          .key('Content-Type')
                          .value('application/json'))
            .body_param(Parameter()
                        .value(body)
                        .is_required(True))
            .body_serializer(APIHelper.json_serialize)
            .auth(And(Single('thingspace_oauth'), Single('SessionToken')))
        ).response(
            ResponseHandler()
            .is_api_response(True)
            .local_error('400', 'Invalid configuration', AppConfigResponseErrorException)
            .local_error('403', 'Forbidden', AppConfigResponseErrorException)
            .local_error('404', 'Configuration not found', AppConfigResponseErrorException)
            .local_error('429', 'Too many requests', AppConfigResponseErrorException)
            .local_error('default', 'unexpected error', AppConfigResponseErrorException)
        ).execute()

    def delete_configuration(self,
                             vendor_id,
                             id):
        """Does a DELETE request to /api/v1/application/configurations/geofence.

        This endpoint deletes a specific configuration from the system. It
        requires the configuration ID parameter, which was provided by the
        POST (create) operation.
        Note: The user needs to authenticate with their ThingSpace credentials
        using the Access/Bearer and Session/M2M tokens in order to call this
        API.

        Args:
            vendor_id (str): The vendor's identifier
            id (str): The configuration identifier

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers.
                Configuration deleted

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.IMP_SERVER)
            .path('/api/v1/application/configurations/geofence')
            .http_method(HttpMethodEnum.DELETE)
            .header_param(Parameter()
                          .key('VendorID')
                          .value(vendor_id)
                          .is_required(True))
            .query_param(Parameter()
                         .key('id')
                         .value(id)
                         .is_required(True))
            .auth(And(Single('thingspace_oauth'), Single('SessionToken')))
        ).response(
            ResponseHandler()
            .is_api_response(True)
            .local_error('403', 'Forbidden', AppConfigResponseErrorException)
            .local_error('429', 'Too many requests', AppConfigResponseErrorException)
            .local_error('default', 'unexpected error', AppConfigResponseErrorException)
        ).execute()
