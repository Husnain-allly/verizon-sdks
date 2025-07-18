# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # SessionManagementApi
  class SessionManagementApi < BaseApi
    # Initiates a Connectivity Management session and returns a VZ-M2M session
    # token that is required in subsequent API requests.
    # @param [LogInRequest] body Optional parameter: Request to initiate a
    # session.
    # @return [ApiResponse] Complete http response with raw body and status code.
    def start_connectivity_management_session(body: nil)
      @api_call
        .request(new_request_builder(HttpMethodEnum::POST,
                                     '/m2m/v1/session/login',
                                     Server::THINGSPACE)
                   .header_param(new_parameter('application/json', key: 'Content-Type'))
                   .body_param(new_parameter(body))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .body_serializer(proc do |param| param.to_json unless param.nil? end)
                   .auth(Single.new('thingspace_oauth')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(LogInResult.method(:from_hash))
                    .is_api_response(true)
                    .local_error('400',
                                 'Error response.',
                                 ConnectivityManagementResultException))
        .execute
    end

    # Ends a Connectivity Management session.
    # @return [ApiResponse] Complete http response with raw body and status code.
    def end_connectivity_management_session
      @api_call
        .request(new_request_builder(HttpMethodEnum::POST,
                                     '/m2m/v1/session/logout',
                                     Server::THINGSPACE)
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(LogOutRequest.method(:from_hash))
                    .is_api_response(true)
                    .local_error('400',
                                 'Error response.',
                                 ConnectivityManagementResultException))
        .execute
    end

    # The new password is effective immediately. Passwords do not expire, but
    # Verizon recommends changing your password every 90 days.
    # @param [SessionResetPasswordRequest] body Required parameter: Request with
    # current password that needs to be reset.
    # @return [ApiResponse] Complete http response with raw body and status code.
    def reset_connectivity_management_password(body)
      @api_call
        .request(new_request_builder(HttpMethodEnum::PUT,
                                     '/m2m/v1/session/password/actions/reset',
                                     Server::THINGSPACE)
                   .header_param(new_parameter('application/json', key: 'Content-Type'))
                   .body_param(new_parameter(body)
                                .is_required(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .body_serializer(proc do |param| param.to_json unless param.nil? end)
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(SessionResetPasswordResult.method(:from_hash))
                    .is_api_response(true)
                    .local_error('400',
                                 'Error response.',
                                 ConnectivityManagementResultException))
        .execute
    end
  end
end
