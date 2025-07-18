# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # An identifier for a single device.
  class DeviceId < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # The value of the device identifier.
    # @return [String]
    attr_accessor :id

    # The type of the device identifier. Valid types of identifiers are:ESN
    # (decimal),EID,ICCID (up to 20 digits),IMEI (up to 16 digits),MDN,MEID
    # (hexadecimal),MSISDN.
    # @return [String]
    attr_accessor :kind

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['id'] = 'id'
      @_hash['kind'] = 'kind'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      []
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(id:, kind:, additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @id = id
      @kind = kind
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      id = hash.key?('id') ? hash['id'] : nil
      kind = hash.key?('kind') ? hash['kind'] : nil

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      DeviceId.new(id: id,
                   kind: kind,
                   additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} id: #{@id}, kind: #{@kind}, additional_properties:"\
      " #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} id: #{@id.inspect}, kind: #{@kind.inspect}, additional_properties:"\
      " #{@additional_properties}>"
    end
  end
end
