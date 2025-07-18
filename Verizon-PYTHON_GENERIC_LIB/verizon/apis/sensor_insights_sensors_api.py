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
from verizon.models.resource_device import ResourceDevice
from verizon.models.dto_sensor_on_boarding_status_response import DtoSensorOnBoardingStatusResponse
from verizon.models.dto_sensor_off_boarding_status_response import DtoSensorOffBoardingStatusResponse
from verizon.exceptions.m_400_management_error_exception import M400ManagementErrorException
from verizon.exceptions.management_error_exception import ManagementErrorException
from verizon.exceptions.m_403_management_error_exception import M403ManagementErrorException
from verizon.exceptions.m_404_management_error_exception import M404ManagementErrorException
from verizon.exceptions.m_500_management_error_exception import M500ManagementErrorException


class SensorInsightsSensorsApi(BaseApi):

    """A Controller to access Endpoints in the verizon API."""
    def __init__(self, config):
        super(SensorInsightsSensorsApi, self).__init__(config)

    def sensor_insights_list_sensor_devices_request(self,
                                                    body):
        """Does a POST request to /dm/v1/devices/sensors/actions/query.

        Args:
            body (DtoListSensorDevicesRequest): List details of the sensors

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. OK

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.THINGSPACE)
            .path('/dm/v1/devices/sensors/actions/query')
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
            .deserialize_into(ResourceDevice.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Bad Request', M400ManagementErrorException)
            .local_error('401', 'UnAuthorized', ManagementErrorException)
            .local_error('403', 'Forbidden', M403ManagementErrorException)
            .local_error('404', 'Not Found', M404ManagementErrorException)
            .local_error('406', 'Not Acceptable', ManagementErrorException)
            .local_error('415', 'Unsupported media type', ManagementErrorException)
            .local_error('429', 'Too many requests', ManagementErrorException)
            .local_error('500', 'Internal server error.', M500ManagementErrorException)
            .local_error('default', 'Unexpected error', ManagementErrorException)
        ).execute()

    def sensor_insights_on_board_sensor_request(self,
                                                body):
        """Does a POST request to /dm/v1/devices/sensors/onboard.

        Args:
            body (DtoOnBoardSensorRequest): Onboarding a sensor

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. OK

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.THINGSPACE)
            .path('/dm/v1/devices/sensors/onboard')
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
            .local_error('400', 'Bad Request', M400ManagementErrorException)
            .local_error('401', 'UnAuthorized', ManagementErrorException)
            .local_error('403', 'Forbidden', M403ManagementErrorException)
            .local_error('406', 'Not Acceptable', ManagementErrorException)
            .local_error('415', 'Unsupported media type', ManagementErrorException)
            .local_error('429', 'Too many requests', ManagementErrorException)
            .local_error('500', 'Internal server error.', M500ManagementErrorException)
            .local_error('default', 'Unexpected error', ManagementErrorException)
        ).execute()

    def sensor_insights_sensor_on_board_status_request(self,
                                                       body):
        """Does a POST request to /dm/v1/devices/sensors/onboard/status/actions/query.

        Args:
            body (DtoSensorOnBoardStatusRequest): Get the sensor's onboarding
                status

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. OK

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.THINGSPACE)
            .path('/dm/v1/devices/sensors/onboard/status/actions/query')
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
            .deserialize_into(DtoSensorOnBoardingStatusResponse.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Bad Request', M400ManagementErrorException)
            .local_error('401', 'UnAuthorized', ManagementErrorException)
            .local_error('403', 'Forbidden', M403ManagementErrorException)
            .local_error('404', 'Not Found', M404ManagementErrorException)
            .local_error('406', 'Not Acceptable', ManagementErrorException)
            .local_error('415', 'Unsupported media type', ManagementErrorException)
            .local_error('429', 'Too many requests', ManagementErrorException)
            .local_error('500', 'Internal server error.', M500ManagementErrorException)
            .local_error('default', 'Unexpected error', ManagementErrorException)
        ).execute()

    def sensor_insights_off_board_sensor_request(self,
                                                 body):
        """Does a POST request to /dm/v1/devices/sensors/offboard.

        Args:
            body (DtoOffBoardSensorRequest): Offboard a sensor

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. No Content

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.THINGSPACE)
            .path('/dm/v1/devices/sensors/offboard')
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
            .local_error('400', 'Bad Request', M400ManagementErrorException)
            .local_error('401', 'UnAuthorized', ManagementErrorException)
            .local_error('403', 'Forbidden', M403ManagementErrorException)
        ).execute()

    def sensor_insights_sensor_off_boarding_status_request(self,
                                                           body):
        """Does a POST request to /dm/v1/devices/sensors/offboard/status/actions/query.

        Args:
            body (DtoSensorOffBoardStatusRequest): Get a sensor's offboarding
                status

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. OK

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.THINGSPACE)
            .path('/dm/v1/devices/sensors/offboard/status/actions/query')
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
            .deserialize_into(DtoSensorOffBoardingStatusResponse.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Bad Request', M400ManagementErrorException)
            .local_error('401', 'UnAuthorized', ManagementErrorException)
            .local_error('403', 'Forbidden', M403ManagementErrorException)
            .local_error('404', 'Not Found', M404ManagementErrorException)
            .local_error('406', 'Not Acceptable', ManagementErrorException)
            .local_error('415', 'Unsupported media type', ManagementErrorException)
            .local_error('429', 'Too many requests', ManagementErrorException)
            .local_error('500', 'Internal server error.', M500ManagementErrorException)
            .local_error('default', 'Unexpected error', ManagementErrorException)
        ).execute()
