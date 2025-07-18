# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # The data frame is used to support the cross-cutting need in many V2X
  # messages to describe arbitrary spatial areas (polygons, boundary lines, and
  # other basic shapes) required by various message types in a small message
  # size.
  class GeographicalPath < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # This data frame can describe a complex path of arbitrary size using node
    # offset method (LL offsets).
    # @return [GeographicalPathDescription]
    attr_accessor :description

    # This data frame can describe a complex path of arbitrary size using node
    # offset method (LL offsets).
    # @return [String]
    attr_accessor :direction

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['description'] = 'description'
      @_hash['direction'] = 'direction'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        description
        direction
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(description: SKIP, direction: SKIP)
      @description = description unless description == SKIP
      @direction = direction unless direction == SKIP
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      description = GeographicalPathDescription.from_hash(hash['description']) if
        hash['description']
      direction = hash.key?('direction') ? hash['direction'] : SKIP

      # Create object from extracted values.
      GeographicalPath.new(description: description,
                           direction: direction)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} description: #{@description}, direction: #{@direction}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} description: #{@description.inspect}, direction: #{@direction.inspect}>"
    end
  end
end
