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
from verizon.models.firmware_package import FirmwarePackage
from verizon.models.device_firmware_list import DeviceFirmwareList
from verizon.models.device_firmware_version_update_result import DeviceFirmwareVersionUpdateResult
from verizon.exceptions.fota_v3_result_exception import FotaV3ResultException


class FirmwareV3Api(BaseApi):

    """A Controller to access Endpoints in the verizon API."""
    def __init__(self, config):
        super(FirmwareV3Api, self).__init__(config)

    def list_available_firmware(self,
                                acc,
                                protocol):
        """Does a GET request to /firmware/{acc}.

        This endpoint allows user to list the firmware of an account.

        Args:
            acc (str): Account identifier.
            protocol (FirmwareProtocol): Filter to retrieve a specific
                protocol type used.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Returns
                an array of firmware objects.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SOFTWARE_MANAGEMENT_V3)
            .path('/firmware/{acc}')
            .http_method(HttpMethodEnum.GET)
            .template_param(Parameter()
                            .key('acc')
                            .value(acc)
                            .is_required(True)
                            .should_encode(True))
            .query_param(Parameter()
                         .key('protocol')
                         .value(protocol)
                         .is_required(True))
            .header_param(Parameter()
                          .key('accept')
                          .value('application/json'))
            .auth(And(Single('thingspace_oauth'), Single('VZ-M2M-Token')))
        ).response(
            ResponseHandler()
            .deserializer(APIHelper.json_deserialize)
            .deserialize_into(FirmwarePackage.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Unexpected error.', FotaV3ResultException)
        ).execute()

    def synchronize_device_firmware(self,
                                    acc,
                                    body):
        """Does a PUT request to /firmware/{acc}/devices.

        Synchronize ThingSpace with the FOTA server for up to 100 devices.

        Args:
            acc (str): Account identifier.
            body (FirmwareImei): DeviceIds to get firmware info synchronously.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Returns
                device firmware information.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SOFTWARE_MANAGEMENT_V3)
            .path('/firmware/{acc}/devices')
            .http_method(HttpMethodEnum.PUT)
            .template_param(Parameter()
                            .key('acc')
                            .value(acc)
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
            .deserialize_into(DeviceFirmwareList.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Unexpected error.', FotaV3ResultException)
        ).execute()

    def report_device_firmware(self,
                               acc,
                               device_id):
        """Does a PUT request to /firmware/{acc}/async/{deviceId}.

        Ask a device to report its firmware version asynchronously.

        Args:
            acc (str): Account identifier.
            device_id (str): Device identifier.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Device
                firmware version update request.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SOFTWARE_MANAGEMENT_V3)
            .path('/firmware/{acc}/async/{deviceId}')
            .http_method(HttpMethodEnum.PUT)
            .template_param(Parameter()
                            .key('acc')
                            .value(acc)
                            .is_required(True)
                            .should_encode(True))
            .template_param(Parameter()
                            .key('deviceId')
                            .value(device_id)
                            .is_required(True)
                            .should_encode(True))
            .header_param(Parameter()
                          .key('accept')
                          .value('application/json'))
            .auth(And(Single('thingspace_oauth'), Single('VZ-M2M-Token')))
        ).response(
            ResponseHandler()
            .deserializer(APIHelper.json_deserialize)
            .deserialize_into(DeviceFirmwareVersionUpdateResult.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Unexpected error.', FotaV3ResultException)
        ).execute()
