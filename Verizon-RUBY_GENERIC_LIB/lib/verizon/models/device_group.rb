# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Returns a list of all device groups in a specified account.
  class DeviceGroup < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # The description of the device group.
    # @return [String]
    attr_accessor :description

    # Any extended attributes for the device group, as Key and Value pairs.
    # @return [Array[CustomFields]]
    attr_accessor :extended_attributes

    # Identifies the default device group.
    # @return [TrueClass | FalseClass]
    attr_accessor :is_default_group

    # The name of the device group.
    # @return [String]
    attr_accessor :name

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['description'] = 'description'
      @_hash['extended_attributes'] = 'extendedAttributes'
      @_hash['is_default_group'] = 'isDefaultGroup'
      @_hash['name'] = 'name'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        description
        extended_attributes
        is_default_group
        name
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(description: SKIP, extended_attributes: SKIP,
                   is_default_group: SKIP, name: SKIP,
                   additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @description = description unless description == SKIP
      @extended_attributes = extended_attributes unless extended_attributes == SKIP
      @is_default_group = is_default_group unless is_default_group == SKIP
      @name = name unless name == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      description = hash.key?('description') ? hash['description'] : SKIP
      # Parameter is an array, so we need to iterate through it
      extended_attributes = nil
      unless hash['extendedAttributes'].nil?
        extended_attributes = []
        hash['extendedAttributes'].each do |structure|
          extended_attributes << (CustomFields.from_hash(structure) if structure)
        end
      end

      extended_attributes = SKIP unless hash.key?('extendedAttributes')
      is_default_group =
        hash.key?('isDefaultGroup') ? hash['isDefaultGroup'] : SKIP
      name = hash.key?('name') ? hash['name'] : SKIP

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      DeviceGroup.new(description: description,
                      extended_attributes: extended_attributes,
                      is_default_group: is_default_group,
                      name: name,
                      additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} description: #{@description}, extended_attributes: #{@extended_attributes},"\
      " is_default_group: #{@is_default_group}, name: #{@name}, additional_properties:"\
      " #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} description: #{@description.inspect}, extended_attributes:"\
      " #{@extended_attributes.inspect}, is_default_group: #{@is_default_group.inspect}, name:"\
      " #{@name.inspect}, additional_properties: #{@additional_properties}>"
    end
  end
end
