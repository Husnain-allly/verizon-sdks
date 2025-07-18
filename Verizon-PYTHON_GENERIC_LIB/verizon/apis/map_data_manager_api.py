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
from verizon.exceptions.map_data_response_error_exception import MapDataResponseErrorException


class MapDataManagerApi(BaseApi):

    """A Controller to access Endpoints in the verizon API."""
    def __init__(self, config):
        super(MapDataManagerApi, self).__init__(config)

    def upload_map_data_message(self,
                                vendor_id,
                                body):
        """Does a POST request to /api/v2/mapdata.

        This endpoint allows the user to upload map messages in SAE J2735 MAP
        messages in ASN.1 UPER or JER (JSON) formats. The MAP data message can
        have more than one intersections in it.
        Note: The user needs to authenticate with their ThingSpace credentials
        using the Access/Bearer and Session/M2M tokens in order to call this
        API.

        Args:
            vendor_id (str): The VendorID set during the Vendor registration
                call.
            body (str): The request body parameter.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. Map
                message/s successfully processed

        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.IMP_SERVER)
            .path('/api/v2/mapdata')
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
            .auth(And(Single('thingspace_oauth'), Single('SessionToken')))
        ).response(
            ResponseHandler()
            .deserializer(APIHelper.json_deserialize)
            .is_api_response(True)
            .local_error('400', 'Invalid request', MapDataResponseErrorException)
            .local_error('401', 'Unauthorized', MapDataResponseErrorException)
            .local_error('403', 'Forbidden Request', MapDataResponseErrorException)
            .local_error('429', 'Too Many Requests', MapDataResponseErrorException)
            .local_error('503', 'Internal server Error', MapDataResponseErrorException)
            .local_error('default', 'Unexpected Error', MapDataResponseErrorException)
        ).execute()

    def download_map_data_message(self,
                                  vendor_id,
                                  geofence):
        """Does a GET request to /api/v2/mapdata.

        This endpoint allows user to download SAE J2735 MAP messages in ASN.1
        UPER format. The area for the MAP messages is needed to be defined in
        the query.

        Args:
            vendor_id (str): The VendorID set during the Vendor registration
                call.
            geofence (Geofence): The area where the user wants to receive MAP
                data from.

        Returns:
            ApiResponse: An object with the response value as well as other
                useful information such as status codes and headers. The
                response is a list line separated ASN.1 UPER J2735 base64
                encoded MapData messages


        Raises:
            ApiException: When an error occurs while fetching the data from
                the remote API. This exception includes the HTTP Response
                code, an error message, and the HTTP body that was received in
                the request.

        """

        return super().new_api_call_builder.request(
            RequestBuilder().server(Server.IMP_SERVER)
            .path('/api/v2/mapdata')
            .http_method(HttpMethodEnum.GET)
            .header_param(Parameter()
                          .key('VendorID')
                          .value(vendor_id)
                          .is_required(True))
            .query_param(Parameter()
                         .key('Geofence')
                         .value(geofence)
                         .is_required(True))
            .auth(And(Single('thingspace_oauth'), Single('SessionToken')))
        ).response(
            ResponseHandler()
            .deserializer(APIHelper.json_deserialize)
            .is_api_response(True)
            .local_error('400', 'Invalid request', MapDataResponseErrorException)
            .local_error('401', 'Unauthorized', MapDataResponseErrorException)
            .local_error('403', 'Forbidden Request', MapDataResponseErrorException)
            .local_error('429', 'Too Many Requests', MapDataResponseErrorException)
            .local_error('503', 'Internal server Error', MapDataResponseErrorException)
            .local_error('default', 'Unexpected Error', MapDataResponseErrorException)
        ).execute()
