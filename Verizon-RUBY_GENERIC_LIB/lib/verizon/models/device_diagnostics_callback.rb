# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

require 'date'
module Verizon
  # Callback information of an existing diagnostics subscription.
  class DeviceDiagnosticsCallback < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # The name of the billing account for which callback messages will be sent.
    # Format: "##########-#####".
    # @return [String]
    attr_accessor :account_name

    # The name of the callback service, which identifies the type and format of
    # messages that will be sent to the registered URL.
    # @return [String]
    attr_accessor :service_name

    # The URL for your web server.
    # @return [String]
    attr_accessor :endpoint

    # The date and time of when this request was created.
    # @return [DateTime]
    attr_accessor :created_on

    # Your HTTP headers.
    # @return [Object]
    attr_accessor :http_headers

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['account_name'] = 'accountName'
      @_hash['service_name'] = 'serviceName'
      @_hash['endpoint'] = 'endpoint'
      @_hash['created_on'] = 'createdOn'
      @_hash['http_headers'] = 'httpHeaders'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        http_headers
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(account_name:, service_name:, endpoint:, created_on:,
                   http_headers: SKIP, additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @account_name = account_name
      @service_name = service_name
      @endpoint = endpoint
      @created_on = created_on
      @http_headers = http_headers unless http_headers == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      account_name = hash.key?('accountName') ? hash['accountName'] : nil
      service_name = hash.key?('serviceName') ? hash['serviceName'] : nil
      endpoint = hash.key?('endpoint') ? hash['endpoint'] : nil
      created_on = if hash.key?('createdOn')
                     (DateTimeHelper.from_rfc3339(hash['createdOn']) if hash['createdOn'])
                   end
      http_headers = hash.key?('httpHeaders') ? hash['httpHeaders'] : SKIP

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      DeviceDiagnosticsCallback.new(account_name: account_name,
                                    service_name: service_name,
                                    endpoint: endpoint,
                                    created_on: created_on,
                                    http_headers: http_headers,
                                    additional_properties: additional_properties)
    end

    def to_custom_created_on
      DateTimeHelper.to_rfc3339(created_on)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name}, service_name: #{@service_name}, endpoint:"\
      " #{@endpoint}, created_on: #{@created_on}, http_headers: #{@http_headers},"\
      " additional_properties: #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name.inspect}, service_name:"\
      " #{@service_name.inspect}, endpoint: #{@endpoint.inspect}, created_on:"\
      " #{@created_on.inspect}, http_headers: #{@http_headers.inspect}, additional_properties:"\
      " #{@additional_properties}>"
    end
  end
end
