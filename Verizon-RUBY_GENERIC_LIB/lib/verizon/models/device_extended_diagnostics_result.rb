# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Result for a request to obtain device extended diagnostics.
  class DeviceExtendedDiagnosticsResult < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # The response includes various types of information about the device,
    # grouped into categories. Each category object contains the category name
    # and a list of Extended Attribute objects as key-value pairs.
    # @return [Array[DiagnosticsCategory]]
    attr_accessor :categories

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['categories'] = 'categories'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        categories
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(categories: SKIP, additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @categories = categories unless categories == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      # Parameter is an array, so we need to iterate through it
      categories = nil
      unless hash['categories'].nil?
        categories = []
        hash['categories'].each do |structure|
          categories << (DiagnosticsCategory.from_hash(structure) if structure)
        end
      end

      categories = SKIP unless hash.key?('categories')

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      DeviceExtendedDiagnosticsResult.new(categories: categories,
                                          additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} categories: #{@categories}, additional_properties:"\
      " #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} categories: #{@categories.inspect}, additional_properties:"\
      " #{@additional_properties}>"
    end
  end
end
