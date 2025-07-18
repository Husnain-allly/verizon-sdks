# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Device that exist in Verizon Mobile Device Management (MDM).
  class ThingspaceDevice < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # The billing account that the device is associated with.
    # @return [String]
    attr_accessor :account_name

    # The date that the device's current billing cycle ends.
    # @return [String]
    attr_accessor :billing_cycle_end_date

    # The carrier information associated with the device.
    # @return [Array[CarrierInformation]]
    attr_accessor :carrier_informations

    # True if the device is connected; false if it is not.
    # @return [TrueClass | FalseClass]
    attr_accessor :connected

    # The date and time that the device was added to the system.
    # @return [String]
    attr_accessor :created_at

    # The custom fields and values that have been set for the device.
    # @return [Array[CustomFields]]
    attr_accessor :custom_fields

    # All identifiers for the device.
    # @return [Array[DeviceId]]
    attr_accessor :device_ids

    # Any extended attributes for the device, as Key and Value pairs. The pairs
    # listed below are returned as part of the response for a single device, but
    # are not included if the request was for information about multiple
    # devices.
    # @return [Array[CustomFields]]
    attr_accessor :extended_attributes

    # The device groups that the device belongs to.
    # @return [Array[String]]
    attr_accessor :group_names

    # The IP address of the device.
    # @return [String]
    attr_accessor :ipaddress

    # The user who last activated the device.
    # @return [String]
    attr_accessor :last_activation_by

    # The date and time that the device was last activated.
    # @return [String]
    attr_accessor :last_activation_date

    # The most recent connection date and time.
    # @return [String]
    attr_accessor :last_connection_date

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['account_name'] = 'accountName'
      @_hash['billing_cycle_end_date'] = 'billingCycleEndDate'
      @_hash['carrier_informations'] = 'carrierInformations'
      @_hash['connected'] = 'connected'
      @_hash['created_at'] = 'createdAt'
      @_hash['custom_fields'] = 'customFields'
      @_hash['device_ids'] = 'deviceIds'
      @_hash['extended_attributes'] = 'extendedAttributes'
      @_hash['group_names'] = 'groupNames'
      @_hash['ipaddress'] = 'ipAddress'
      @_hash['last_activation_by'] = 'lastActivationBy'
      @_hash['last_activation_date'] = 'lastActivationDate'
      @_hash['last_connection_date'] = 'lastConnectionDate'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        account_name
        billing_cycle_end_date
        carrier_informations
        connected
        created_at
        custom_fields
        device_ids
        extended_attributes
        group_names
        ipaddress
        last_activation_by
        last_activation_date
        last_connection_date
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(account_name: SKIP, billing_cycle_end_date: SKIP,
                   carrier_informations: SKIP, connected: SKIP,
                   created_at: SKIP, custom_fields: SKIP, device_ids: SKIP,
                   extended_attributes: SKIP, group_names: SKIP,
                   ipaddress: SKIP, last_activation_by: SKIP,
                   last_activation_date: SKIP, last_connection_date: SKIP,
                   additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @account_name = account_name unless account_name == SKIP
      @billing_cycle_end_date = billing_cycle_end_date unless billing_cycle_end_date == SKIP
      @carrier_informations = carrier_informations unless carrier_informations == SKIP
      @connected = connected unless connected == SKIP
      @created_at = created_at unless created_at == SKIP
      @custom_fields = custom_fields unless custom_fields == SKIP
      @device_ids = device_ids unless device_ids == SKIP
      @extended_attributes = extended_attributes unless extended_attributes == SKIP
      @group_names = group_names unless group_names == SKIP
      @ipaddress = ipaddress unless ipaddress == SKIP
      @last_activation_by = last_activation_by unless last_activation_by == SKIP
      @last_activation_date = last_activation_date unless last_activation_date == SKIP
      @last_connection_date = last_connection_date unless last_connection_date == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      account_name = hash.key?('accountName') ? hash['accountName'] : SKIP
      billing_cycle_end_date =
        hash.key?('billingCycleEndDate') ? hash['billingCycleEndDate'] : SKIP
      # Parameter is an array, so we need to iterate through it
      carrier_informations = nil
      unless hash['carrierInformations'].nil?
        carrier_informations = []
        hash['carrierInformations'].each do |structure|
          carrier_informations << (CarrierInformation.from_hash(structure) if structure)
        end
      end

      carrier_informations = SKIP unless hash.key?('carrierInformations')
      connected = hash.key?('connected') ? hash['connected'] : SKIP
      created_at = hash.key?('createdAt') ? hash['createdAt'] : SKIP
      # Parameter is an array, so we need to iterate through it
      custom_fields = nil
      unless hash['customFields'].nil?
        custom_fields = []
        hash['customFields'].each do |structure|
          custom_fields << (CustomFields.from_hash(structure) if structure)
        end
      end

      custom_fields = SKIP unless hash.key?('customFields')
      # Parameter is an array, so we need to iterate through it
      device_ids = nil
      unless hash['deviceIds'].nil?
        device_ids = []
        hash['deviceIds'].each do |structure|
          device_ids << (DeviceId.from_hash(structure) if structure)
        end
      end

      device_ids = SKIP unless hash.key?('deviceIds')
      # Parameter is an array, so we need to iterate through it
      extended_attributes = nil
      unless hash['extendedAttributes'].nil?
        extended_attributes = []
        hash['extendedAttributes'].each do |structure|
          extended_attributes << (CustomFields.from_hash(structure) if structure)
        end
      end

      extended_attributes = SKIP unless hash.key?('extendedAttributes')
      group_names = hash.key?('groupNames') ? hash['groupNames'] : SKIP
      ipaddress = hash.key?('ipAddress') ? hash['ipAddress'] : SKIP
      last_activation_by =
        hash.key?('lastActivationBy') ? hash['lastActivationBy'] : SKIP
      last_activation_date =
        hash.key?('lastActivationDate') ? hash['lastActivationDate'] : SKIP
      last_connection_date =
        hash.key?('lastConnectionDate') ? hash['lastConnectionDate'] : SKIP

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      ThingspaceDevice.new(account_name: account_name,
                           billing_cycle_end_date: billing_cycle_end_date,
                           carrier_informations: carrier_informations,
                           connected: connected,
                           created_at: created_at,
                           custom_fields: custom_fields,
                           device_ids: device_ids,
                           extended_attributes: extended_attributes,
                           group_names: group_names,
                           ipaddress: ipaddress,
                           last_activation_by: last_activation_by,
                           last_activation_date: last_activation_date,
                           last_connection_date: last_connection_date,
                           additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name}, billing_cycle_end_date:"\
      " #{@billing_cycle_end_date}, carrier_informations: #{@carrier_informations}, connected:"\
      " #{@connected}, created_at: #{@created_at}, custom_fields: #{@custom_fields}, device_ids:"\
      " #{@device_ids}, extended_attributes: #{@extended_attributes}, group_names:"\
      " #{@group_names}, ipaddress: #{@ipaddress}, last_activation_by: #{@last_activation_by},"\
      " last_activation_date: #{@last_activation_date}, last_connection_date:"\
      " #{@last_connection_date}, additional_properties: #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name.inspect}, billing_cycle_end_date:"\
      " #{@billing_cycle_end_date.inspect}, carrier_informations:"\
      " #{@carrier_informations.inspect}, connected: #{@connected.inspect}, created_at:"\
      " #{@created_at.inspect}, custom_fields: #{@custom_fields.inspect}, device_ids:"\
      " #{@device_ids.inspect}, extended_attributes: #{@extended_attributes.inspect}, group_names:"\
      " #{@group_names.inspect}, ipaddress: #{@ipaddress.inspect}, last_activation_by:"\
      " #{@last_activation_by.inspect}, last_activation_date: #{@last_activation_date.inspect},"\
      " last_connection_date: #{@last_connection_date.inspect}, additional_properties:"\
      " #{@additional_properties}>"
    end
  end
end
