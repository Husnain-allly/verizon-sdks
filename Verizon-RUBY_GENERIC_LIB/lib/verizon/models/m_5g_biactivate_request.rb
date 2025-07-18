# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # M5GBiactivateRequest Model.
  class M5GBiactivateRequest < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # TODO: Write general description for this method
    # @return [String]
    attr_accessor :account_name

    # TODO: Write general description for this method
    # @return [String]
    attr_accessor :service_plan

    # TODO: Write general description for this method
    # @return [Array[DeviceListWithServiceAddress1]]
    attr_accessor :device_list_with_service_address

    # TODO: Write general description for this method
    # @return [String]
    attr_accessor :public_ip_restriction

    # TODO: Write general description for this method
    # @return [String]
    attr_accessor :carrier_name

    # TODO: Write general description for this method
    # @return [String]
    attr_accessor :mdn_zip_code

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['account_name'] = 'accountName'
      @_hash['service_plan'] = 'servicePlan'
      @_hash['device_list_with_service_address'] =
        'deviceListWithServiceAddress'
      @_hash['public_ip_restriction'] = 'publicIpRestriction'
      @_hash['carrier_name'] = 'carrierName'
      @_hash['mdn_zip_code'] = 'mdnZipCode'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        account_name
        service_plan
        device_list_with_service_address
        public_ip_restriction
        carrier_name
        mdn_zip_code
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(account_name: SKIP, service_plan: SKIP,
                   device_list_with_service_address: SKIP,
                   public_ip_restriction: SKIP, carrier_name: SKIP,
                   mdn_zip_code: SKIP, additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @account_name = account_name unless account_name == SKIP
      @service_plan = service_plan unless service_plan == SKIP
      unless device_list_with_service_address == SKIP
        @device_list_with_service_address =
          device_list_with_service_address
      end
      @public_ip_restriction = public_ip_restriction unless public_ip_restriction == SKIP
      @carrier_name = carrier_name unless carrier_name == SKIP
      @mdn_zip_code = mdn_zip_code unless mdn_zip_code == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      account_name = hash.key?('accountName') ? hash['accountName'] : SKIP
      service_plan = hash.key?('servicePlan') ? hash['servicePlan'] : SKIP
      # Parameter is an array, so we need to iterate through it
      device_list_with_service_address = nil
      unless hash['deviceListWithServiceAddress'].nil?
        device_list_with_service_address = []
        hash['deviceListWithServiceAddress'].each do |structure|
          device_list_with_service_address << (DeviceListWithServiceAddress1.from_hash(structure) if structure)
        end
      end

      device_list_with_service_address = SKIP unless hash.key?('deviceListWithServiceAddress')
      public_ip_restriction =
        hash.key?('publicIpRestriction') ? hash['publicIpRestriction'] : SKIP
      carrier_name = hash.key?('carrierName') ? hash['carrierName'] : SKIP
      mdn_zip_code = hash.key?('mdnZipCode') ? hash['mdnZipCode'] : SKIP

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      M5GBiactivateRequest.new(account_name: account_name,
                               service_plan: service_plan,
                               device_list_with_service_address: device_list_with_service_address,
                               public_ip_restriction: public_ip_restriction,
                               carrier_name: carrier_name,
                               mdn_zip_code: mdn_zip_code,
                               additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name}, service_plan: #{@service_plan},"\
      " device_list_with_service_address: #{@device_list_with_service_address},"\
      " public_ip_restriction: #{@public_ip_restriction}, carrier_name: #{@carrier_name},"\
      " mdn_zip_code: #{@mdn_zip_code}, additional_properties: #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name.inspect}, service_plan:"\
      " #{@service_plan.inspect}, device_list_with_service_address:"\
      " #{@device_list_with_service_address.inspect}, public_ip_restriction:"\
      " #{@public_ip_restriction.inspect}, carrier_name: #{@carrier_name.inspect}, mdn_zip_code:"\
      " #{@mdn_zip_code.inspect}, additional_properties: #{@additional_properties}>"
    end
  end
end
