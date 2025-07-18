# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

require 'date'
module Verizon
  # Device and firmware information.
  class DeviceFirmwareVersion < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # TODO: Write general description for this method
    # @return [String]
    attr_accessor :status

    # TODO: Write general description for this method
    # @return [String]
    attr_accessor :reason

    # Device IMEI.
    # @return [String]
    attr_accessor :device_id

    # Device Firmware Version.
    # @return [String]
    attr_accessor :firmware_version

    # Device Firmware Version.
    # @return [DateTime]
    attr_accessor :firmware_version_update_time

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['status'] = 'status'
      @_hash['reason'] = 'reason'
      @_hash['device_id'] = 'deviceId'
      @_hash['firmware_version'] = 'firmwareVersion'
      @_hash['firmware_version_update_time'] = 'firmwareVersionUpdateTime'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        status
        reason
        firmware_version_update_time
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(device_id:, firmware_version:, status: SKIP, reason: SKIP,
                   firmware_version_update_time: SKIP,
                   additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @status = status unless status == SKIP
      @reason = reason unless reason == SKIP
      @device_id = device_id
      @firmware_version = firmware_version
      unless firmware_version_update_time == SKIP
        @firmware_version_update_time =
          firmware_version_update_time
      end
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      device_id = hash.key?('deviceId') ? hash['deviceId'] : nil
      firmware_version =
        hash.key?('firmwareVersion') ? hash['firmwareVersion'] : nil
      status = hash.key?('status') ? hash['status'] : SKIP
      reason = hash.key?('reason') ? hash['reason'] : SKIP
      firmware_version_update_time = if hash.key?('firmwareVersionUpdateTime')
                                       (DateTimeHelper.from_rfc3339(hash['firmwareVersionUpdateTime']) if hash['firmwareVersionUpdateTime'])
                                     else
                                       SKIP
                                     end

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      DeviceFirmwareVersion.new(device_id: device_id,
                                firmware_version: firmware_version,
                                status: status,
                                reason: reason,
                                firmware_version_update_time: firmware_version_update_time,
                                additional_properties: additional_properties)
    end

    def to_custom_firmware_version_update_time
      DateTimeHelper.to_rfc3339(firmware_version_update_time)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} status: #{@status}, reason: #{@reason}, device_id: #{@device_id},"\
      " firmware_version: #{@firmware_version}, firmware_version_update_time:"\
      " #{@firmware_version_update_time}, additional_properties: #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} status: #{@status.inspect}, reason: #{@reason.inspect}, device_id:"\
      " #{@device_id.inspect}, firmware_version: #{@firmware_version.inspect},"\
      " firmware_version_update_time: #{@firmware_version_update_time.inspect},"\
      " additional_properties: #{@additional_properties}>"
    end
  end
end
