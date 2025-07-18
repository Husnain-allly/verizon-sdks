# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Rbstiltconfig Model.
  class Rbstiltconfig < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # TODO: Write general description for this method
    # @return [RbsHighPrecisionTiltConfig]
    attr_accessor :rbs_high_precision_tilt_config

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['rbs_high_precision_tilt_config'] = 'RbsHighPrecisionTiltConfig'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        rbs_high_precision_tilt_config
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(rbs_high_precision_tilt_config: SKIP,
                   additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      unless rbs_high_precision_tilt_config == SKIP
        @rbs_high_precision_tilt_config =
          rbs_high_precision_tilt_config
      end
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      if hash['RbsHighPrecisionTiltConfig']
        rbs_high_precision_tilt_config = RbsHighPrecisionTiltConfig.from_hash(hash['RbsHighPrecisionTiltConfig'])
      end

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      Rbstiltconfig.new(rbs_high_precision_tilt_config: rbs_high_precision_tilt_config,
                        additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} rbs_high_precision_tilt_config: #{@rbs_high_precision_tilt_config},"\
      " additional_properties: #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} rbs_high_precision_tilt_config: #{@rbs_high_precision_tilt_config.inspect},"\
      " additional_properties: #{@additional_properties}>"
    end
  end
end
