# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # BillingApi
  class BillingApi < BaseApi
    # This endpoint allows user to add managed accounts to a primary account.
    # @param [ManagedAccountsAddRequest] body Required parameter: Service name
    # and list of accounts to add
    # @return [ApiResponse] Complete http response with raw body and status code.
    def add_account(body)
      @api_call
        .request(new_request_builder(HttpMethodEnum::POST,
                                     '/managedaccounts/actions/add',
                                     Server::SUBSCRIPTION_SERVER)
                   .header_param(new_parameter('application/json', key: 'Content-Type'))
                   .body_param(new_parameter(body)
                                .is_required(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .body_serializer(proc do |param| param.to_json unless param.nil? end)
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(ManagedAccountsAddResponse.method(:from_hash))
                    .is_api_response(true)
                    .local_error('400',
                                 'Unexpected error',
                                 DeviceLocationResultException))
        .execute
    end

    # Activates a managed billing service relationship between a managed account
    # and the primary account.
    # @param [ManagedAccountsProvisionRequest] body Required parameter: Service
    # name and list of accounts to add
    # @return [ApiResponse] Complete http response with raw body and status code.
    def managed_account_action(body)
      @api_call
        .request(new_request_builder(HttpMethodEnum::POST,
                                     '/managedaccounts/actions/provision',
                                     Server::SUBSCRIPTION_SERVER)
                   .header_param(new_parameter('application/json', key: 'Content-Type'))
                   .body_param(new_parameter(body)
                                .is_required(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .body_serializer(proc do |param| param.to_json unless param.nil? end)
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(ManagedAccountsProvisionResponse.method(:from_hash))
                    .is_api_response(true)
                    .local_error('400',
                                 'Unexpected error',
                                 DeviceLocationResultException))
        .execute
    end

    # Deactivates a managed billing service relationship between a managed
    # account and the primary account.
    # @param [ManagedAccountCancelRequest] body Required parameter: Service name
    # and list of accounts to add
    # @return [ApiResponse] Complete http response with raw body and status code.
    def cancel_managed_account_action(body)
      @api_call
        .request(new_request_builder(HttpMethodEnum::POST,
                                     '/managedaccounts/actions/cancel',
                                     Server::SUBSCRIPTION_SERVER)
                   .header_param(new_parameter('application/json', key: 'Content-Type'))
                   .body_param(new_parameter(body)
                                .is_required(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .body_serializer(proc do |param| param.to_json unless param.nil? end)
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(ManagedAccountCancelResponse.method(:from_hash))
                    .is_api_response(true)
                    .local_error('400',
                                 'Unexpected error',
                                 DeviceLocationResultException))
        .execute
    end

    # This endpoint allows user to retrieve the list of all accounts managed by
    # a primary account.
    # @param [String] account_name Required parameter: Primary account
    # identifier
    # @param [String] service_name Required parameter: Service name
    # @return [ApiResponse] Complete http response with raw body and status code.
    def list_managed_account(account_name,
                             service_name)
      @api_call
        .request(new_request_builder(HttpMethodEnum::GET,
                                     '/managedaccounts/{accountName}/service/{serviceName}',
                                     Server::SUBSCRIPTION_SERVER)
                   .template_param(new_parameter(account_name, key: 'accountName')
                                    .is_required(true)
                                    .should_encode(true))
                   .template_param(new_parameter(service_name, key: 'serviceName')
                                    .is_required(true)
                                    .should_encode(true))
                   .header_param(new_parameter('application/json', key: 'accept'))
                   .auth(And.new('thingspace_oauth', 'VZ-M2M-Token')))
        .response(new_response_handler
                    .deserializer(APIHelper.method(:custom_type_deserializer))
                    .deserialize_into(ManagedAccountsGetAllResponse.method(:from_hash))
                    .is_api_response(true)
                    .local_error('400',
                                 'Unexpected error',
                                 DeviceLocationResultException))
        .execute
    end
  end
end
