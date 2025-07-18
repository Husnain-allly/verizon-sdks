# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # The devices that you want to locate. The array cannot contain more than 20
  # devices.
  class DeviceInfo < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # Device identifier.
    # @return [String]
    attr_accessor :id

    # Device identifier kind.
    # @return [String]
    attr_accessor :kind

    # Device MDN.
    # @return [String]
    attr_accessor :mdn

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['id'] = 'id'
      @_hash['kind'] = 'kind'
      @_hash['mdn'] = 'mdn'
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

    def initialize(id:, kind:, mdn:, additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @id = id
      @kind = kind
      @mdn = mdn
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      id = hash.key?('id') ? hash['id'] : nil
      kind = hash.key?('kind') ? hash['kind'] : nil
      mdn = hash.key?('mdn') ? hash['mdn'] : nil

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      DeviceInfo.new(id: id,
                     kind: kind,
                     mdn: mdn,
                     additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} id: #{@id}, kind: #{@kind}, mdn: #{@mdn}, additional_properties:"\
      " #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} id: #{@id.inspect}, kind: #{@kind.inspect}, mdn: #{@mdn.inspect},"\
      " additional_properties: #{@additional_properties}>"
    end
  end
end
