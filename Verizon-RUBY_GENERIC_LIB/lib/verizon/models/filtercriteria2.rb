# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Filtercriteria2 Model.
  class Filtercriteria2 < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # TODO: Write general description for this method
    # @return [Array[Object]]
    attr_accessor :filter_criteria

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['filter_criteria'] = 'filterCriteria'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        filter_criteria
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(filter_criteria: SKIP, additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @filter_criteria = filter_criteria unless filter_criteria == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      filter_criteria =
        hash.key?('filterCriteria') ? hash['filterCriteria'] : SKIP

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      Filtercriteria2.new(filter_criteria: filter_criteria,
                          additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} filter_criteria: #{@filter_criteria}, additional_properties:"\
      " #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} filter_criteria: #{@filter_criteria.inspect}, additional_properties:"\
      " #{@additional_properties}>"
    end
  end
end
