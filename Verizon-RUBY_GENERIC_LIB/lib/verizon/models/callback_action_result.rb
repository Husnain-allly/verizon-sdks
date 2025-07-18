# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Response to a callback action.
  class CallbackActionResult < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # The name of the billing account.
    # @return [String]
    attr_accessor :account_name

    # The name of the callback service that was registered/deregistered.
    # @return [String]
    attr_accessor :service_name

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['account_name'] = 'accountName'
      @_hash['service_name'] = 'serviceName'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        account_name
        service_name
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(account_name: SKIP, service_name: SKIP,
                   additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @account_name = account_name unless account_name == SKIP
      @service_name = service_name unless service_name == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      account_name = hash.key?('accountName') ? hash['accountName'] : SKIP
      service_name = hash.key?('serviceName') ? hash['serviceName'] : SKIP

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      CallbackActionResult.new(account_name: account_name,
                               service_name: service_name,
                               additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name}, service_name: #{@service_name},"\
      " additional_properties: #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name.inspect}, service_name:"\
      " #{@service_name.inspect}, additional_properties: #{@additional_properties}>"
    end
  end
end
