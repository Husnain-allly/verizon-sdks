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
from verizon.models.device_list_query_result import DeviceListQueryResult
from verizon.models.upgrade_list_query_result import UpgradeListQueryResult
from verizon.models.device_upgrade_history import DeviceUpgradeHistory
from verizon.exceptions.fota_v1_result_exception import FotaV1ResultException


class SoftwareManagementReportsV1Api(BaseApi):

    """A Controller to access Endpoints in the verizon API."""
    def __init__(self, config):
        super(SoftwareManagementReportsV1Api, self).__init__(config)

    def list_account_devices(self,
                             account,
                             start_index):
        """Does a GET request to /devices/{account}/index/{startIndex}.

        Returns an array of all devices in the specified account. Each device
        object includes information needed for managing firmware, including
        the device make and model, MDN and IMEI, and current firmware version.

        Args:
            account (str): Account identifier in "##########-#####".
            start_index (str): Only return devices with IMEIs larger than this
                value. Use 0 for the first request. If `hasMoreData`=true in
                the response, use the `lastSeenDeviceId` value from the
                response as the startIndex in the next request.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. List of
                all devices in the specified account.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SOFTWARE_MANAGEMENT_V1)
            .path('/devices/{account}/index/{startIndex}')
            .http_method(HttpMethodEnum.GET)
            .template_param(Parameter()
                            .key('account')
                            .value(account)
                            .is_required(True)
                            .should_encode(True))
            .template_param(Parameter()
                            .key('startIndex')
                            .value(start_index)
                            .is_required(True)
                            .should_encode(True))
            .header_param(Parameter()
                          .key('accept')
                          .value('application/json'))
            .auth(And(Single('thingspace_oauth'), Single('VZ-M2M-Token')))
        ).response(
            ResponseHandler()
            .deserializer(APIHelper.json_deserialize)
            .deserialize_into(DeviceListQueryResult.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Unexpected error.', FotaV1ResultException)
        ).execute()

    def list_upgrades_for_specified_status(self,
                                           account,
                                           upgrade_status,
                                           start_index):
        """Does a GET request to /reports/{account}/status/{upgradeStatus}/index/{startIndex}.

        Returns a list of all upgrades with a specified status.

        Args:
            account (str): Account identifier in "##########-#####".
            upgrade_status (UpgradeStatus): The status of the upgrades that
                you want to retrieve.
            start_index (str): The zero-based number of the first record to
                return. Set startIndex=0 for the first request. If
                `hasMoreFlag`=true in the response, use the
                `lastSeenUpgradeId` value from the response as the startIndex
                in the next request.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. A list of
                all upgrades with a specified status.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SOFTWARE_MANAGEMENT_V1)
            .path('/reports/{account}/status/{upgradeStatus}/index/{startIndex}')
            .http_method(HttpMethodEnum.GET)
            .template_param(Parameter()
                            .key('account')
                            .value(account)
                            .is_required(True)
                            .should_encode(True))
            .template_param(Parameter()
                            .key('upgradeStatus')
                            .value(upgrade_status)
                            .is_required(True)
                            .should_encode(True))
            .template_param(Parameter()
                            .key('startIndex')
                            .value(start_index)
                            .is_required(True)
                            .should_encode(True))
            .header_param(Parameter()
                          .key('accept')
                          .value('application/json'))
            .auth(And(Single('thingspace_oauth'), Single('VZ-M2M-Token')))
        ).response(
            ResponseHandler()
            .deserializer(APIHelper.json_deserialize)
            .deserialize_into(UpgradeListQueryResult.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Unexpected error.', FotaV1ResultException)
        ).execute()

    def get_device_firmware_upgrade_history(self,
                                            account,
                                            device_id):
        """Does a GET request to /reports/{account}/devices/{deviceId}.

        Returns the upgrade history of the specified device from the previous
        six months.

        Args:
            account (str): Account identifier in "##########-#####".
            device_id (str): The IMEI of the device.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Device
                upgrade history.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SOFTWARE_MANAGEMENT_V1)
            .path('/reports/{account}/devices/{deviceId}')
            .http_method(HttpMethodEnum.GET)
            .template_param(Parameter()
                            .key('account')
                            .value(account)
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
            .deserialize_into(DeviceUpgradeHistory.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Unexpected error.', FotaV1ResultException)
        ).execute()
