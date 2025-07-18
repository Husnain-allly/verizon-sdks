# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # AccountGroupShareFilter Model.
  class AccountGroupShareFilter < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # TODO: Write general description for this method
    # @return [Integer]
    attr_accessor :rate_plan_group_id

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['rate_plan_group_id'] = 'ratePlanGroupId'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        rate_plan_group_id
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(rate_plan_group_id: SKIP, additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @rate_plan_group_id = rate_plan_group_id unless rate_plan_group_id == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      rate_plan_group_id =
        hash.key?('ratePlanGroupId') ? hash['ratePlanGroupId'] : SKIP

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      AccountGroupShareFilter.new(rate_plan_group_id: rate_plan_group_id,
                                  additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} rate_plan_group_id: #{@rate_plan_group_id}, additional_properties:"\
      " #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} rate_plan_group_id: #{@rate_plan_group_id.inspect}, additional_properties:"\
      " #{@additional_properties}>"
    end
  end
end
