# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # ResponseToUsageQuery Model.
  class ResponseToUsageQuery < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # TODO: Write general description for this method
    # @return [TrueClass | FalseClass]
    attr_accessor :hasmoredata

    # TODO: Write general description for this method
    # @return [ReadySimDeviceId]
    attr_accessor :device_id

    # TODO: Write general description for this method
    # @return [Array[UsageHistory]]
    attr_accessor :usage_history

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['hasmoredata'] = 'hasmoredata'
      @_hash['device_id'] = 'deviceId'
      @_hash['usage_history'] = 'usageHistory'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        hasmoredata
        device_id
        usage_history
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(hasmoredata: SKIP, device_id: SKIP, usage_history: SKIP,
                   additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @hasmoredata = hasmoredata unless hasmoredata == SKIP
      @device_id = device_id unless device_id == SKIP
      @usage_history = usage_history unless usage_history == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      hasmoredata = hash.key?('hasmoredata') ? hash['hasmoredata'] : SKIP
      device_id = ReadySimDeviceId.from_hash(hash['deviceId']) if hash['deviceId']
      # Parameter is an array, so we need to iterate through it
      usage_history = nil
      unless hash['usageHistory'].nil?
        usage_history = []
        hash['usageHistory'].each do |structure|
          usage_history << (UsageHistory.from_hash(structure) if structure)
        end
      end

      usage_history = SKIP unless hash.key?('usageHistory')

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      ResponseToUsageQuery.new(hasmoredata: hasmoredata,
                               device_id: device_id,
                               usage_history: usage_history,
                               additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} hasmoredata: #{@hasmoredata}, device_id: #{@device_id}, usage_history:"\
      " #{@usage_history}, additional_properties: #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} hasmoredata: #{@hasmoredata.inspect}, device_id: #{@device_id.inspect},"\
      " usage_history: #{@usage_history.inspect}, additional_properties:"\
      " #{@additional_properties}>"
    end
  end
end
