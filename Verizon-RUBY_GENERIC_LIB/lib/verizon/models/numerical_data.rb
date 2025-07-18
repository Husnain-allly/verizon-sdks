# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Describes value and unit of time.
  class NumericalData < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # Numerical value.
    # @return [Integer]
    attr_accessor :value

    # Unit of time.
    # @return [NumericalDataUnit]
    attr_accessor :unit

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['value'] = 'value'
      @_hash['unit'] = 'unit'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        value
        unit
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(value: SKIP, unit: SKIP, additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @value = value unless value == SKIP
      @unit = unit unless unit == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      value = hash.key?('value') ? hash['value'] : SKIP
      unit = hash.key?('unit') ? hash['unit'] : SKIP

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      NumericalData.new(value: value,
                        unit: unit,
                        additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} value: #{@value}, unit: #{@unit}, additional_properties:"\
      " #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} value: #{@value.inspect}, unit: #{@unit.inspect}, additional_properties:"\
      " #{@additional_properties}>"
    end
  end
end
