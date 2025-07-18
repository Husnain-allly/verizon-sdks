# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Array of upgrade objects with the specified status.
  class FirmwareUpgrade < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # The unique identifier for this upgrade.
    # @return [String]
    attr_accessor :id

    # Account identifier in "##########-#####".
    # @return [String]
    attr_accessor :account_name

    # The name of the firmware image that will be used for the upgrade.
    # @return [String]
    attr_accessor :firmware_name

    # The name of the firmware version that will be on the devices after a
    # successful upgrade.
    # @return [String]
    attr_accessor :firmware_to

    # The intended start date for the upgrade.
    # @return [String]
    attr_accessor :start_date

    # The current status of the upgrade.
    # @return [String]
    attr_accessor :status

    # A JSON object for each device that was included in the upgrade, showing
    # the device IMEI, the status of the upgrade, and additional information
    # about the status.
    # @return [Array[FirmwareUpgradeDeviceListItem]]
    attr_accessor :device_list

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['id'] = 'id'
      @_hash['account_name'] = 'accountName'
      @_hash['firmware_name'] = 'firmwareName'
      @_hash['firmware_to'] = 'firmwareTo'
      @_hash['start_date'] = 'startDate'
      @_hash['status'] = 'status'
      @_hash['device_list'] = 'deviceList'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        id
        account_name
        firmware_name
        firmware_to
        start_date
        status
        device_list
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(id: SKIP, account_name: SKIP, firmware_name: SKIP,
                   firmware_to: SKIP, start_date: SKIP, status: SKIP,
                   device_list: SKIP, additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @id = id unless id == SKIP
      @account_name = account_name unless account_name == SKIP
      @firmware_name = firmware_name unless firmware_name == SKIP
      @firmware_to = firmware_to unless firmware_to == SKIP
      @start_date = start_date unless start_date == SKIP
      @status = status unless status == SKIP
      @device_list = device_list unless device_list == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      id = hash.key?('id') ? hash['id'] : SKIP
      account_name = hash.key?('accountName') ? hash['accountName'] : SKIP
      firmware_name = hash.key?('firmwareName') ? hash['firmwareName'] : SKIP
      firmware_to = hash.key?('firmwareTo') ? hash['firmwareTo'] : SKIP
      start_date = hash.key?('startDate') ? hash['startDate'] : SKIP
      status = hash.key?('status') ? hash['status'] : SKIP
      # Parameter is an array, so we need to iterate through it
      device_list = nil
      unless hash['deviceList'].nil?
        device_list = []
        hash['deviceList'].each do |structure|
          device_list << (FirmwareUpgradeDeviceListItem.from_hash(structure) if structure)
        end
      end

      device_list = SKIP unless hash.key?('deviceList')

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      FirmwareUpgrade.new(id: id,
                          account_name: account_name,
                          firmware_name: firmware_name,
                          firmware_to: firmware_to,
                          start_date: start_date,
                          status: status,
                          device_list: device_list,
                          additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} id: #{@id}, account_name: #{@account_name}, firmware_name:"\
      " #{@firmware_name}, firmware_to: #{@firmware_to}, start_date: #{@start_date}, status:"\
      " #{@status}, device_list: #{@device_list}, additional_properties:"\
      " #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} id: #{@id.inspect}, account_name: #{@account_name.inspect}, firmware_name:"\
      " #{@firmware_name.inspect}, firmware_to: #{@firmware_to.inspect}, start_date:"\
      " #{@start_date.inspect}, status: #{@status.inspect}, device_list: #{@device_list.inspect},"\
      " additional_properties: #{@additional_properties}>"
    end
  end
end
