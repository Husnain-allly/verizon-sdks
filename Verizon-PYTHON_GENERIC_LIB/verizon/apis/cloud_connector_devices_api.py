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
from verizon.models.change_configuration_response import ChangeConfigurationResponse
from verizon.models.find_device_by_property_response_list import FindDeviceByPropertyResponseList
from verizon.models.search_device_by_property_response_list import SearchDeviceByPropertyResponseList
from verizon.models.search_device_event_history_response_list import SearchDeviceEventHistoryResponseList
from verizon.models.search_sensor_history_response_list import SearchSensorHistoryResponseList


class CloudConnectorDevicesApi(BaseApi):

    """A Controller to access Endpoints in the verizon API."""
    def __init__(self, config):
        super(CloudConnectorDevicesApi, self).__init__(config)

    def update_devices_configuration_value(self,
                                           body):
        """Does a POST request to /devices/configuration/actions/set.

        Change configuration values on a device, such as setting how often a
        device records and reports sensor readings.

        Args:
            body (ChangeConfigurationRequest): The request body changes
                configuration values on a device.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. A success
                response contains the ts.event.configuration event that was
                created to record the change.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.CLOUD_CONNECTOR)
            .path('/devices/configuration/actions/set')
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
            .deserialize_into(ChangeConfigurationResponse.from_dictionary)
            .is_api_response(True)
        ).execute()

    def find_device_by_property_values(self,
                                       body):
        """Does a POST request to /devices/actions/query.

        Find devices by property values. Returns an array of all matching
        device resources.

        Args:
            body (QuerySubscriptionRequest): The request body specifies fields
                and values to match.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. A success
                response includes an array of all matching devices. Each
                device includes the full device resource definition.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.CLOUD_CONNECTOR)
            .path('/devices/actions/query')
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
            .deserialize_into(FindDeviceByPropertyResponseList.from_dictionary)
            .is_api_response(True)
        ).execute()

    def search_devices_resources_by_property_values(self,
                                                    body):
        """Does a POST request to /devices/actions/search.

        Search for devices by property values. Returns an array of all
        matching device resources.

        Args:
            body (QuerySubscriptionRequest): The request body specifies fields
                and values to match.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. A success
                response includes an array of all matching devices.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.CLOUD_CONNECTOR)
            .path('/devices/actions/search')
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
            .deserialize_into(SearchDeviceByPropertyResponseList.from_dictionary)
            .is_api_response(True)
        ).execute()

    def search_device_event_history(self,
                                    body):
        """Does a POST request to /devices/fields/actions/history/search.

        Search device event history to find events that match criteria.Sensor
        readings, configuration changes, and other device data are all stored
        as events.

        Args:
            body (SearchDeviceEventHistoryRequest): The device identifier and
                fields to match in the search.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. A success
                response includes an array of all matching devices.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.CLOUD_CONNECTOR)
            .path('/devices/fields/actions/history/search')
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
            .deserialize_into(SearchDeviceEventHistoryResponseList.from_dictionary)
            .is_api_response(True)
        ).execute()

    def search_sensor_readings(self,
                               fieldname,
                               body):
        """Does a POST request to /devices/fields/{fieldname}/actions/history.

        Returns the readings of a specified sensor, with the most recent
        reading first. Sensor readings are stored as events; this request an
        array of events.

        Args:
            fieldname (str): The name of the sensor.
            body (SearchSensorHistoryRequest): The device identifier and
                fields to match in the search.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. A success
                response includes an array of all matching devices.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.CLOUD_CONNECTOR)
            .path('/devices/fields/{fieldname}/actions/history')
            .http_method(HttpMethodEnum.POST)
            .template_param(Parameter()
                            .key('fieldname')
                            .value(fieldname)
                            .is_required(True)
                            .should_encode(True))
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
            .deserialize_into(SearchSensorHistoryResponseList.from_dictionary)
            .is_api_response(True)
        ).execute()

    def delete_device_from_account(self,
                                   body):
        """Does a POST request to /devices/actions/delete.

        Remove a device from a ThingSpace account.

        Args:
            body (RemoveDeviceRequest): The request body identifies the device
                to delete.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Target
                deleted successfully.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.CLOUD_CONNECTOR)
            .path('/devices/actions/delete')
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
