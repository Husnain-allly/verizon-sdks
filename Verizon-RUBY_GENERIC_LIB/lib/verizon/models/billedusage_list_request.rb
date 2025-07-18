# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Information required to associate a usage segmentation label with a device
  # to retrieve billing.
  class BilledusageListRequest < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # TODO: Write general description for this method
    # @return [String]
    attr_accessor :account_name

    # TODO: Write general description for this method
    # @return [LabelsList]
    attr_accessor :labels

    # TODO: Write general description for this method
    # @return [Array[DeviceList]]
    attr_accessor :device_ids

    # TODO: Write general description for this method
    # @return [BillingCycle]
    attr_accessor :billing_cycle

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['account_name'] = 'accountName'
      @_hash['labels'] = 'labels'
      @_hash['device_ids'] = 'deviceIds'
      @_hash['billing_cycle'] = 'billingCycle'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        labels
        device_ids
        billing_cycle
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(account_name:, labels: SKIP, device_ids: SKIP,
                   billing_cycle: SKIP, additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @account_name = account_name
      @labels = labels unless labels == SKIP
      @device_ids = device_ids unless device_ids == SKIP
      @billing_cycle = billing_cycle unless billing_cycle == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      account_name = hash.key?('accountName') ? hash['accountName'] : nil
      labels = LabelsList.from_hash(hash['labels']) if hash['labels']
      # Parameter is an array, so we need to iterate through it
      device_ids = nil
      unless hash['deviceIds'].nil?
        device_ids = []
        hash['deviceIds'].each do |structure|
          device_ids << (DeviceList.from_hash(structure) if structure)
        end
      end

      device_ids = SKIP unless hash.key?('deviceIds')
      billing_cycle = BillingCycle.from_hash(hash['billingCycle']) if hash['billingCycle']

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      BilledusageListRequest.new(account_name: account_name,
                                 labels: labels,
                                 device_ids: device_ids,
                                 billing_cycle: billing_cycle,
                                 additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name}, labels: #{@labels}, device_ids:"\
      " #{@device_ids}, billing_cycle: #{@billing_cycle}, additional_properties:"\
      " #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name.inspect}, labels: #{@labels.inspect},"\
      " device_ids: #{@device_ids.inspect}, billing_cycle: #{@billing_cycle.inspect},"\
      " additional_properties: #{@additional_properties}>"
    end
  end
end
