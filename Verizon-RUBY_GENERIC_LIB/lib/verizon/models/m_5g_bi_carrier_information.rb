# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # M5GBiCarrierInformation Model.
  class M5GBiCarrierInformation < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # TODO: Write general description for this method
    # @return [String]
    attr_accessor :carrier_name

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['carrier_name'] = 'carrierName'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        carrier_name
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(carrier_name: SKIP, additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @carrier_name = carrier_name unless carrier_name == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      carrier_name = hash.key?('carrierName') ? hash['carrierName'] : SKIP

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      M5GBiCarrierInformation.new(carrier_name: carrier_name,
                                  additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} carrier_name: #{@carrier_name}, additional_properties:"\
      " #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} carrier_name: #{@carrier_name.inspect}, additional_properties:"\
      " #{@additional_properties}>"
    end
  end
end
