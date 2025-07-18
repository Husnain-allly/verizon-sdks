# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # The ID of the authenticating billing account, in the format
  # `{"billingaccountid":"1234567890-12345"}`.
  class AccountIdentifier < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # TODO: Write general description for this method
    # @return [String]
    attr_accessor :billingaccountid

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['billingaccountid'] = 'billingaccountid'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        billingaccountid
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(billingaccountid: SKIP, additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @billingaccountid = billingaccountid unless billingaccountid == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      billingaccountid =
        hash.key?('billingaccountid') ? hash['billingaccountid'] : SKIP

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      AccountIdentifier.new(billingaccountid: billingaccountid,
                            additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} billingaccountid: #{@billingaccountid}, additional_properties:"\
      " #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} billingaccountid: #{@billingaccountid.inspect}, additional_properties:"\
      " #{@additional_properties}>"
    end
  end
end
