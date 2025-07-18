# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # CampaignsV3Api
  class CampaignsV3Api < BaseApi
    # This endpoint allows a user to schedule a firmware upgrade for a list of
    # devices.
    # @param [String] account_name Required parameter: Account identifier.
    # @param [CampaignFirmwareUpgrade] body Required parameter: Firmware upgrade
    # information.
    # @return [ApiResponse] Complete http response with raw body and status code.
    def schedule_campaign_firmware_upgrade(account_name,
                                           body)
      @api_call
        .request(new_request_builder(HttpMethodEnum::POST,
                                     '/campaigns/firmware/{accountName}',
                                     Server::SOFTWARE_MANAGEMENT_V3)
                   .template_param(new_parameter(account_name, key: 'accountName')
                                    .is_required(true)
                                    .should_encode(true))
                   .header_param(new_parameter('application/json', key: 'Content-Type'))
                   .body_param(new_parameter(body)
                                .is_required(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .body_serializer(proc do |param| param.to_json unless param.nil? end)
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(FirmwareCampaign.method(:from_hash))
                    .is_api_response(true)
                    .local_error('400',
                                 'Unexpected error.',
                                 FotaV3ResultException))
        .execute
    end

    # This endpoint allows user to Add or Remove devices to an existing
    # campaign.
    # @param [String] acc Required parameter: Account identifier.
    # @param [String] campaign_id Required parameter: Unique identifier of a
    # campaign.
    # @param [V3AddOrRemoveDeviceRequest] body Required parameter: Add or remove
    # device to existing upgrade information.
    # @return [ApiResponse] Complete http response with raw body and status code.
    def update_campaign_firmware_devices(acc,
                                         campaign_id,
                                         body)
      @api_call
        .request(new_request_builder(HttpMethodEnum::PUT,
                                     '/campaigns/firmware/{acc}/{campaignId}',
                                     Server::SOFTWARE_MANAGEMENT_V3)
                   .template_param(new_parameter(acc, key: 'acc')
                                    .is_required(true)
                                    .should_encode(true))
                   .template_param(new_parameter(campaign_id, key: 'campaignId')
                                    .is_required(true)
                                    .should_encode(true))
                   .header_param(new_parameter('application/json', key: 'Content-Type'))
                   .body_param(new_parameter(body)
                                .is_required(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .body_serializer(proc do |param| param.to_json unless param.nil? end)
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(V3AddOrRemoveDeviceResult.method(:from_hash))
                    .is_api_response(true)
                    .local_error('400',
                                 'Unexpected error.',
                                 FotaV3ResultException))
        .execute
    end

    # This endpoint allows user to change campaign dates and time windows.
    # Fields which need to remain unchanged should be also provided.
    # @param [String] acc Required parameter: Account identifier.
    # @param [String] campaign_id Required parameter: Firmware upgrade
    # information.
    # @param [V3ChangeCampaignDatesRequest] body Required parameter: New dates
    # and time windows.
    # @return [ApiResponse] Complete http response with raw body and status code.
    def update_campaign_dates(acc,
                              campaign_id,
                              body)
      @api_call
        .request(new_request_builder(HttpMethodEnum::PUT,
                                     '/campaigns/firmware/{acc}/{campaignId}/dates',
                                     Server::SOFTWARE_MANAGEMENT_V3)
                   .template_param(new_parameter(acc, key: 'acc')
                                    .is_required(true)
                                    .should_encode(true))
                   .template_param(new_parameter(campaign_id, key: 'campaignId')
                                    .is_required(true)
                                    .should_encode(true))
                   .header_param(new_parameter('application/json', key: 'Content-Type'))
                   .body_param(new_parameter(body)
                                .is_required(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .body_serializer(proc do |param| param.to_json unless param.nil? end)
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(FirmwareCampaign.method(:from_hash))
                    .is_api_response(true)
                    .local_error('400',
                                 'Unexpected error.',
                                 FotaV3ResultException))
        .execute
    end

    # This endpoint allows the user to retrieve campaign level information for a
    # specified campaign.
    # @param [String] account_name Required parameter: Account identifier.
    # @param [String] campaign_id Required parameter: Firmware upgrade
    # identifier.
    # @return [ApiResponse] Complete http response with raw body and status code.
    def get_campaign_information(account_name,
                                 campaign_id)
      @api_call
        .request(new_request_builder(HttpMethodEnum::GET,
                                     '/campaigns/{accountName}/{campaignId}',
                                     Server::SOFTWARE_MANAGEMENT_V3)
                   .template_param(new_parameter(account_name, key: 'accountName')
                                    .is_required(true)
                                    .should_encode(true))
                   .template_param(new_parameter(campaign_id, key: 'campaignId')
                                    .is_required(true)
                                    .should_encode(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(Campaign.method(:from_hash))
                    .is_api_response(true)
                    .local_error('400',
                                 'Unexpected error.',
                                 FotaV3ResultException))
        .execute
    end

    # This endpoint allows user to cancel a firmware campaign. A firmware
    # campaign already started can not be cancelled.
    # @param [String] account_name Required parameter: Account identifier.
    # @param [String] campaign_id Required parameter: Firmware upgrade
    # information.
    # @return [ApiResponse] Complete http response with raw body and status code.
    def cancel_campaign(account_name,
                        campaign_id)
      @api_call
        .request(new_request_builder(HttpMethodEnum::DELETE,
                                     '/campaigns/{accountName}/{campaignId}',
                                     Server::SOFTWARE_MANAGEMENT_V3)
                   .template_param(new_parameter(account_name, key: 'accountName')
                                    .is_required(true)
                                    .should_encode(true))
                   .template_param(new_parameter(campaign_id, key: 'campaignId')
                                    .is_required(true)
                                    .should_encode(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(FotaV3SuccessResult.method(:from_hash))
                    .is_api_response(true)
                    .local_error('400',
                                 'Unexpected error.',
                                 FotaV3ResultException))
        .execute
    end
  end
end
