# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Response to return the daily network data usage of a single device during a
  # specified time period.
  class DeviceUsageListResult < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # False for a status 200 response.True for a status 202 response, indicating
    # that there is more data to be retrieved.
    # @return [TrueClass | FalseClass]
    attr_accessor :has_more_data

    # Placeholder.
    # @return [Array[Usage]]
    attr_accessor :usage_history

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['has_more_data'] = 'hasMoreData'
      @_hash['usage_history'] = 'usageHistory'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        has_more_data
        usage_history
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(has_more_data: SKIP, usage_history: SKIP,
                   additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @has_more_data = has_more_data unless has_more_data == SKIP
      @usage_history = usage_history unless usage_history == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      has_more_data = hash.key?('hasMoreData') ? hash['hasMoreData'] : SKIP
      # Parameter is an array, so we need to iterate through it
      usage_history = nil
      unless hash['usageHistory'].nil?
        usage_history = []
        hash['usageHistory'].each do |structure|
          usage_history << (Usage.from_hash(structure) if structure)
        end
      end

      usage_history = SKIP unless hash.key?('usageHistory')

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      DeviceUsageListResult.new(has_more_data: has_more_data,
                                usage_history: usage_history,
                                additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} has_more_data: #{@has_more_data}, usage_history: #{@usage_history},"\
      " additional_properties: #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} has_more_data: #{@has_more_data.inspect}, usage_history:"\
      " #{@usage_history.inspect}, additional_properties: #{@additional_properties}>"
    end
  end
end
