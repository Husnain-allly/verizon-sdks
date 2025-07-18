# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # SensorInsightsDeviceProfileApi
  class SensorInsightsDeviceProfileApi < BaseApi
    # Create a device profile
    # @param [DtoConfigurationProfile] body Required parameter: TODO: type
    # description here
    # @return [ApiResponse] Complete http response with raw body and status code.
    def create_a_profile(body)
      @api_call
        .request(new_request_builder(HttpMethodEnum::POST,
                                     '/dm/v1/deviceConfigurationProfiles',
                                     Server::THINGSPACE)
                   .header_param(new_parameter('application/json', key: 'Content-Type'))
                   .body_param(new_parameter(body)
                                .is_required(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .body_serializer(proc do |param| param.to_json unless param.nil? end)
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(DtoProfileResponse.method(:from_hash))
                    .is_api_response(true)
                    .is_response_array(true)
                    .local_error('400',
                                 'Bad Request',
                                 M400ManagementErrorException)
                    .local_error('401',
                                 'UnAuthorized',
                                 ManagementErrorException)
                    .local_error('403',
                                 'Forbidden',
                                 M403ManagementErrorException)
                    .local_error('500',
                                 'Internal server error.',
                                 M500ManagementErrorException))
        .execute
    end

    # Delete a device profile
    # @param [DtoConfigurationProfileDelete] deleterequest Required parameter:
    # payload for the delete request
    # @return [ApiResponse] Complete http response with raw body and status code.
    def delete_a_profile(deleterequest)
      @api_call
        .request(new_request_builder(HttpMethodEnum::DELETE,
                                     '/dm/v1/deviceConfigurationProfiles',
                                     Server::THINGSPACE)
                   .header_param(new_parameter(deleterequest, key: 'deleterequest')
                                  .is_required(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(DtoProfileResponse.method(:from_hash))
                    .is_api_response(true)
                    .is_response_array(true)
                    .local_error('400',
                                 'Bad Request',
                                 M400ManagementErrorException)
                    .local_error('401',
                                 'UnAuthorized',
                                 ManagementErrorException)
                    .local_error('403',
                                 'Forbidden',
                                 M403ManagementErrorException)
                    .local_error('500',
                                 'Internal server error.',
                                 M500ManagementErrorException))
        .execute
    end

    # Partially update a device profile
    # @param [DtoConfigurationProfilePath] body Required parameter: TODO: type
    # description here
    # @return [ApiResponse] Complete http response with raw body and status code.
    def update_a_profile(body)
      @api_call
        .request(new_request_builder(HttpMethodEnum::PATCH,
                                     '/dm/v1/deviceConfigurationProfiles',
                                     Server::THINGSPACE)
                   .header_param(new_parameter('application/json', key: 'Content-Type'))
                   .body_param(new_parameter(body)
                                .is_required(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .body_serializer(proc do |param| param.to_json unless param.nil? end)
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(DtoProfileResponse.method(:from_hash))
                    .is_api_response(true)
                    .is_response_array(true)
                    .local_error('400',
                                 'Bad Request',
                                 M400ManagementErrorException)
                    .local_error('401',
                                 'UnAuthorized',
                                 ManagementErrorException)
                    .local_error('403',
                                 'Forbidden',
                                 M403ManagementErrorException)
                    .local_error('500',
                                 'Internal server error.',
                                 M500ManagementErrorException))
        .execute
    end

    # Query a device profile for an individual device
    # @param [ResourceResourceQuery] body Required parameter: body
    # @return [ApiResponse] Complete http response with raw body and status code.
    def query_a_profile(body)
      @api_call
        .request(new_request_builder(HttpMethodEnum::POST,
                                     '/dm/v1/deviceConfigurationProfiles/actions/query',
                                     Server::THINGSPACE)
                   .header_param(new_parameter('application/json', key: 'Content-Type'))
                   .body_param(new_parameter(body)
                                .is_required(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .body_serializer(proc do |param| param.to_json unless param.nil? end)
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(DtoProfileResponse.method(:from_hash))
                    .is_api_response(true)
                    .is_response_array(true)
                    .local_error('400',
                                 'Bad Request',
                                 M400ManagementErrorException)
                    .local_error('401',
                                 'UnAuthorized',
                                 ManagementErrorException)
                    .local_error('403',
                                 'Forbidden',
                                 M403ManagementErrorException)
                    .local_error('500',
                                 'Internal server error.',
                                 M500ManagementErrorException))
        .execute
    end
  end
end
