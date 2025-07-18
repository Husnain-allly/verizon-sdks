# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # DeviceActionsApi
  class DeviceActionsApi < BaseApi
    # Retrieve the aggregate usage for a device or a number of devices.
    # @param [AggregateUsage] body Required parameter: TODO: type description
    # here
    # @return [ApiResponse] Complete http response with raw body and status code.
    def aggregate_usage(body)
      @api_call
        .request(new_request_builder(HttpMethodEnum::POST,
                                     '/v1/devices/usage/actions/list/aggregate',
                                     Server::THINGSPACE)
                   .header_param(new_parameter('application/json', key: 'Content-Type'))
                   .body_param(new_parameter(body)
                                .is_required(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .body_serializer(proc do |param| param.to_json unless param.nil? end)
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(GioRequestResponse.method(:from_hash))
                    .is_api_response(true)
                    .local_error('default',
                                 'Error response',
                                 GioRestErrorResponseException))
        .execute
    end

    # Retrieve the daily usage for a device, for a specified period of time,
    # segmented by day
    # @param [DailyUsage] body Required parameter: TODO: type description here
    # @return [ApiResponse] Complete http response with raw body and status code.
    def daily_usage(body)
      @api_call
        .request(new_request_builder(HttpMethodEnum::POST,
                                     '/v1/devices/usage/actions/list',
                                     Server::THINGSPACE)
                   .header_param(new_parameter('application/json', key: 'Content-Type'))
                   .body_param(new_parameter(body)
                                .is_required(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .body_serializer(proc do |param| param.to_json unless param.nil? end)
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(DailyUsageResponse.method(:from_hash))
                    .is_api_response(true)
                    .local_error('default',
                                 'Error response',
                                 GioRestErrorResponseException))
        .execute
    end

    # Retrieve all of the service plans, features and carriers associated with
    # the account specified.
    # @param [String] account_name Required parameter: TODO: type description
    # here
    # @return [ApiResponse] Complete http response with raw body and status code.
    def service_plan_list(account_name)
      @api_call
        .request(new_request_builder(HttpMethodEnum::GET,
                                     '/v1/plans/{accountName}',
                                     Server::THINGSPACE)
                   .template_param(new_parameter(account_name, key: 'accountName')
                                    .is_required(true)
                                    .should_encode(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(AccountDetails.method(:from_hash))
                    .is_api_response(true)
                    .local_error('default',
                                 'Error response',
                                 GioRestErrorResponseException))
        .execute
    end

    # Retrieve all of the service plans, features and carriers associated with
    # the account specified.
    # @param [String] account_name Required parameter: TODO: type description
    # here
    # @return [ApiResponse] Complete http response with raw body and status code.
    def account_information(account_name)
      @api_call
        .request(new_request_builder(HttpMethodEnum::GET,
                                     '/v1/accounts/{accountName}',
                                     Server::THINGSPACE)
                   .template_param(new_parameter(account_name, key: 'accountName')
                                    .is_required(true)
                                    .should_encode(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(AccountDetails.method(:from_hash))
                    .is_api_response(true)
                    .local_error('default',
                                 'Error response',
                                 GioRestErrorResponseException))
        .execute
    end

    # Allows the profile to fetch the complete device list. This works with
    # Verizon US and Global profiles.
    # @param [GetDeviceListWithProfilesRequest] body Required parameter: Device
    # Profile Query
    # @return [ApiResponse] Complete http response with raw body and status code.
    def retrieve_the_global_device_list(body)
      @api_call
        .request(new_request_builder(HttpMethodEnum::POST,
                                     '/m2m/v2/devices/actions/list',
                                     Server::THINGSPACE)
                   .header_param(new_parameter('application/json', key: 'Content-Type'))
                   .body_param(new_parameter(body)
                                .is_required(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .body_serializer(proc do |param| param.to_json unless param.nil? end)
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(GioRequestResponse.method(:from_hash))
                    .is_api_response(true)
                    .local_error('default',
                                 'Error response',
                                 GioRestErrorResponseException))
        .execute
    end

    # Retrieve the provisioning history of a specific device or devices.
    # @param [ProvhistoryRequest] body Required parameter: Device Provisioning
    # History
    # @return [ApiResponse] Complete http response with raw body and status code.
    def retrieve_device_provisioning_history(body)
      @api_call
        .request(new_request_builder(HttpMethodEnum::POST,
                                     '/m2m/v2/devices/history/actions/list',
                                     Server::THINGSPACE)
                   .header_param(new_parameter('application/json', key: 'Content-Type'))
                   .body_param(new_parameter(body)
                                .is_required(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .body_serializer(proc do |param| param.to_json unless param.nil? end)
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(GioRequestResponse.method(:from_hash))
                    .is_api_response(true)
                    .local_error('default',
                                 'Error response',
                                 GioRestErrorResponseException))
        .execute
    end

    # Get the status of an asynchronous request made with the Device Actions.
    # @param [String] account_name Required parameter: TODO: type description
    # here
    # @param [String] request_id Required parameter: TODO: type description
    # here
    # @return [ApiResponse] Complete http response with raw body and status code.
    def get_asynchronous_request_status(account_name,
                                        request_id)
      @api_call
        .request(new_request_builder(HttpMethodEnum::GET,
                                     '/m2m/v2/accounts/{accountName}/requests/{requestID}/status',
                                     Server::THINGSPACE)
                   .template_param(new_parameter(account_name, key: 'accountName')
                                    .is_required(true)
                                    .should_encode(true))
                   .template_param(new_parameter(request_id, key: 'requestID')
                                    .is_required(true)
                                    .should_encode(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(StatusResponse.method(:from_hash))
                    .is_api_response(true)
                    .local_error('default',
                                 'Error response',
                                 GioRestErrorResponseException))
        .execute
    end
  end
end
