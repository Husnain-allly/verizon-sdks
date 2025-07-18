# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # DeviceDiagnosticsApi
  class DeviceDiagnosticsApi < BaseApi
    # If the devices do not already exist in the account, this API resource adds
    # them before activation.
    # @param [NotificationReportStatusRequest] body Required parameter: Retrieve
    # Reachability Report Status for a device.
    # @return [ApiResponse] Complete http response with raw body and status code.
    def device_reachability_status_using_post(body)
      @api_call
        .request(new_request_builder(HttpMethodEnum::POST,
                                     '/m2m/v1/diagnostics/basic/devicereachability/status',
                                     Server::THINGSPACE)
                   .header_param(new_parameter('application/json', key: 'Content-Type'))
                   .body_param(new_parameter(body)
                                .is_required(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .body_serializer(proc do |param| param.to_json unless param.nil? end)
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(DeviceManagementResult.method(:from_hash))
                    .is_api_response(true)
                    .local_error('400',
                                 'Error response.',
                                 ConnectivityManagementResultException))
        .execute
    end

    # Retrieve all the active monitors.
    # @param [RetrieveMonitorsRequest] body Required parameter: Retrieve Monitor
    # Request.
    # @return [ApiResponse] Complete http response with raw body and status code.
    def retrieve_active_monitors_using_post(body)
      @api_call
        .request(new_request_builder(HttpMethodEnum::POST,
                                     '/m2m/v1/diagnostics/basic/devicereachability/monitors',
                                     Server::THINGSPACE)
                   .header_param(new_parameter('application/json', key: 'Content-Type'))
                   .body_param(new_parameter(body)
                                .is_required(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .body_serializer(proc do |param| param.to_json unless param.nil? end)
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(DeviceManagementResult.method(:from_hash))
                    .is_api_response(true)
                    .local_error('400',
                                 'Error response.',
                                 ConnectivityManagementResultException))
        .execute
    end
  end
end
