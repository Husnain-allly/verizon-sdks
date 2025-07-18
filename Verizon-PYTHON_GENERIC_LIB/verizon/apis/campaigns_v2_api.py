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
from verizon.models.campaign_software import CampaignSoftware
from verizon.models.v2_add_or_remove_device_result import V2AddOrRemoveDeviceResult
from verizon.models.fota_v2_success_result import FotaV2SuccessResult
from verizon.models.upload_and_schedule_file_response import UploadAndScheduleFileResponse
from verizon.exceptions.fota_v2_result_exception import FotaV2ResultException


class CampaignsV2Api(BaseApi):

    """A Controller to access Endpoints in the verizon API."""
    def __init__(self, config):
        super(CampaignsV2Api, self).__init__(config)

    def schedule_campaign_firmware_upgrade(self,
                                           account,
                                           body):
        """Does a POST request to /campaigns/{account}.

        This endpoint allows user to schedule a software upgrade.

        Args:
            account (str): Account identifier.
            body (CampaignSoftwareUpgrade): Software upgrade information.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Return
                software upgrade information.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SOFTWARE_MANAGEMENT_V2)
            .path('/campaigns/{account}')
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
            .deserialize_into(CampaignSoftware.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Unexpected error.', FotaV2ResultException)
        ).execute()

    def get_campaign_information(self,
                                 account,
                                 campaign_id):
        """Does a GET request to /campaigns/{account}/{campaignId}.

        This endpoint allows user to get information of a software upgrade.

        Args:
            account (str): Account identifier.
            campaign_id (str): Software upgrade identifier.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Return
                software upgrade information.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SOFTWARE_MANAGEMENT_V2)
            .path('/campaigns/{account}/{campaignId}')
            .http_method(HttpMethodEnum.GET)
            .template_param(Parameter()
                            .key('account')
                            .value(account)
                            .is_required(True)
                            .should_encode(True))
            .template_param(Parameter()
                            .key('campaignId')
                            .value(campaign_id)
                            .is_required(True)
                            .should_encode(True))
            .header_param(Parameter()
                          .key('accept')
                          .value('application/json'))
            .auth(And(Single('thingspace_oauth'), Single('VZ-M2M-Token')))
        ).response(
            ResponseHandler()
            .deserializer(APIHelper.json_deserialize)
            .deserialize_into(CampaignSoftware.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Unexpected error.', FotaV2ResultException)
        ).execute()

    def update_campaign_firmware_devices(self,
                                         account,
                                         campaign_id,
                                         body):
        """Does a PUT request to /campaigns/{account}/{campaignId}.

        This endpoint allows user to Add or Remove devices to an existing
        software upgrade.

        Args:
            account (str): Account identifier.
            campaign_id (str): Software upgrade information.
            body (V2AddOrRemoveDeviceRequest): Request to add or remove device
                to existing software upgrade information.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Result of
                adding or removing devices to existing software upgrade
                information.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SOFTWARE_MANAGEMENT_V2)
            .path('/campaigns/{account}/{campaignId}')
            .http_method(HttpMethodEnum.PUT)
            .template_param(Parameter()
                            .key('account')
                            .value(account)
                            .is_required(True)
                            .should_encode(True))
            .template_param(Parameter()
                            .key('campaignId')
                            .value(campaign_id)
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
            .deserialize_into(V2AddOrRemoveDeviceResult.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Unexpected error.', FotaV2ResultException)
        ).execute()

    def cancel_campaign(self,
                        account,
                        campaign_id):
        """Does a DELETE request to /campaigns/{account}/{campaignId}.

        This endpoint allows user to cancel software upgrade. A software
        upgrade already started can not be cancelled.

        Args:
            account (str): Account identifier.
            campaign_id (str): Unique identifier of campaign.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Return
                cancellation status.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SOFTWARE_MANAGEMENT_V2)
            .path('/campaigns/{account}/{campaignId}')
            .http_method(HttpMethodEnum.DELETE)
            .template_param(Parameter()
                            .key('account')
                            .value(account)
                            .is_required(True)
                            .should_encode(True))
            .template_param(Parameter()
                            .key('campaignId')
                            .value(campaign_id)
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

    def update_campaign_dates(self,
                              account,
                              campaign_id,
                              body):
        """Does a PUT request to /campaigns/{account}/{campaignId}/dates.

        This endpoint allows user to change campaign dates and time windows.
        Fields which need to remain unchanged should be also provided.

        Args:
            account (str): Account identifier.
            campaign_id (str): Software upgrade information.
            body (V2ChangeCampaignDatesRequest): New dates and time windows.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Updated
                campaign information.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SOFTWARE_MANAGEMENT_V2)
            .path('/campaigns/{account}/{campaignId}/dates')
            .http_method(HttpMethodEnum.PUT)
            .template_param(Parameter()
                            .key('account')
                            .value(account)
                            .is_required(True)
                            .should_encode(True))
            .template_param(Parameter()
                            .key('campaignId')
                            .value(campaign_id)
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
            .deserialize_into(CampaignSoftware.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Unexpected error.', FotaV2ResultException)
        ).execute()

    def schedule_file_upgrade(self,
                              acc,
                              body):
        """Does a POST request to /campaigns/files/{acc}.

        You can upload configuration files and schedule them in a campaign to
        devices.

        Args:
            acc (str): Account identifier.
            body (UploadAndScheduleFileRequest): Device logging information.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers.
                Successful responses.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SOFTWARE_MANAGEMENT_V2)
            .path('/campaigns/files/{acc}')
            .http_method(HttpMethodEnum.POST)
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
            .deserialize_into(UploadAndScheduleFileResponse.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Unexpected error.', FotaV2ResultException)
        ).execute()

    def schedule_sw_upgrade_http_devices(self,
                                         acc,
                                         body):
        """Does a POST request to /campaigns/software/{acc}.

        Campaign time windows for downloading and installing software are
        available as long as the device OEM supports this.

        Args:
            acc (str): Account identifier.
            body (SchedulesSoftwareUpgradeRequest): Device logging information.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers.
                Successful responses.

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.SOFTWARE_MANAGEMENT_V2)
            .path('/campaigns/software/{acc}')
            .http_method(HttpMethodEnum.POST)
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
            .deserialize_into(UploadAndScheduleFileResponse.from_dictionary)
            .is_api_response(True)
            .local_error('400', 'Unexpected error.', FotaV2ResultException)
        ).execute()
