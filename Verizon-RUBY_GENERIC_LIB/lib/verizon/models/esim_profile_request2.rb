# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # EsimProfileRequest2 Model.
  class EsimProfileRequest2 < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # TODO: Write general description for this method
    # @return [Array[EsimDeviceList]]
    attr_accessor :devices

    # TODO: Write general description for this method
    # @return [String]
    attr_accessor :account_name

    # TODO: Write general description for this method
    # @return [String]
    attr_accessor :service_plan

    # TODO: Write general description for this method
    # @return [String]
    attr_accessor :mdn_zip_code

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['devices'] = 'devices'
      @_hash['account_name'] = 'accountName'
      @_hash['service_plan'] = 'servicePlan'
      @_hash['mdn_zip_code'] = 'mdnZipCode'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        devices
        account_name
        service_plan
        mdn_zip_code
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(devices: SKIP, account_name: SKIP, service_plan: SKIP,
                   mdn_zip_code: SKIP)
      @devices = devices unless devices == SKIP
      @account_name = account_name unless account_name == SKIP
      @service_plan = service_plan unless service_plan == SKIP
      @mdn_zip_code = mdn_zip_code unless mdn_zip_code == SKIP
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      # Parameter is an array, so we need to iterate through it
      devices = nil
      unless hash['devices'].nil?
        devices = []
        hash['devices'].each do |structure|
          devices << (EsimDeviceList.from_hash(structure) if structure)
        end
      end

      devices = SKIP unless hash.key?('devices')
      account_name = hash.key?('accountName') ? hash['accountName'] : SKIP
      service_plan = hash.key?('servicePlan') ? hash['servicePlan'] : SKIP
      mdn_zip_code = hash.key?('mdnZipCode') ? hash['mdnZipCode'] : SKIP

      # Create object from extracted values.
      EsimProfileRequest2.new(devices: devices,
                              account_name: account_name,
                              service_plan: service_plan,
                              mdn_zip_code: mdn_zip_code)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} devices: #{@devices}, account_name: #{@account_name}, service_plan:"\
      " #{@service_plan}, mdn_zip_code: #{@mdn_zip_code}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} devices: #{@devices.inspect}, account_name: #{@account_name.inspect},"\
      " service_plan: #{@service_plan.inspect}, mdn_zip_code: #{@mdn_zip_code.inspect}>"
    end
  end
end
