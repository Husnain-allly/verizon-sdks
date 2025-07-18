# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Host information.
  class TargetAuthenticationBodyHost < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # TODO: Write general description for this method
    # @return [String]
    attr_accessor :hostandpath

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['hostandpath'] = 'hostandpath'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        hostandpath
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(hostandpath: SKIP, additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @hostandpath = hostandpath unless hostandpath == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      hostandpath = hash.key?('hostandpath') ? hash['hostandpath'] : SKIP

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      TargetAuthenticationBodyHost.new(hostandpath: hostandpath,
                                       additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} hostandpath: #{@hostandpath}, additional_properties:"\
      " #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} hostandpath: #{@hostandpath.inspect}, additional_properties:"\
      " #{@additional_properties}>"
    end
  end
end
