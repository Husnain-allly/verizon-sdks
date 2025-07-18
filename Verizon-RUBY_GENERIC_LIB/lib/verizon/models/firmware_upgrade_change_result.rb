# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Upgrade information.
  class FirmwareUpgradeChangeResult < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # Account identifier in "##########-#####".
    # @return [String]
    attr_accessor :account_name

    # The unique identifier for this upgrade.
    # @return [String]
    attr_accessor :id

    # A JSON object for each device that was included in the request, showing
    # the device IMEI, the status of the addition or removal, and additional
    # information about the status.
    # @return [Array[V1DeviceListItem]]
    attr_accessor :device_list

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['account_name'] = 'accountName'
      @_hash['id'] = 'id'
      @_hash['device_list'] = 'deviceList'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        account_name
        id
        device_list
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(account_name: SKIP, id: SKIP, device_list: SKIP,
                   additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @account_name = account_name unless account_name == SKIP
      @id = id unless id == SKIP
      @device_list = device_list unless device_list == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      account_name = hash.key?('accountName') ? hash['accountName'] : SKIP
      id = hash.key?('id') ? hash['id'] : SKIP
      # Parameter is an array, so we need to iterate through it
      device_list = nil
      unless hash['deviceList'].nil?
        device_list = []
        hash['deviceList'].each do |structure|
          device_list << (V1DeviceListItem.from_hash(structure) if structure)
        end
      end

      device_list = SKIP unless hash.key?('deviceList')

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      FirmwareUpgradeChangeResult.new(account_name: account_name,
                                      id: id,
                                      device_list: device_list,
                                      additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name}, id: #{@id}, device_list: #{@device_list},"\
      " additional_properties: #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name.inspect}, id: #{@id.inspect}, device_list:"\
      " #{@device_list.inspect}, additional_properties: #{@additional_properties}>"
    end
  end
end
