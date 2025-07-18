# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # AccountDetails Model.
  class AccountDetails < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # The numeric name of the account, in the format "0000123456-00001". Leading
    # zeros must be included.
    # @return [String]
    attr_accessor :account_name

    # The numeric name of the account, in the format "0000123456-00001". Leading
    # zeros must be included.
    # @return [String]
    attr_accessor :account_number

    # user defined name of organization
    # @return [String]
    attr_accessor :organization_name

    # Flag set to indicate if account details can be edited or not. Default is
    # "true".
    # @return [TrueClass | FalseClass]
    attr_accessor :is_provisioning_allowed

    # Flag set to indicate if account details can be edited or not. Default is
    # "true".
    # @return [Array[Carrier]]
    attr_accessor :carriers

    # Flag set to indicate if account details can be edited or not. Default is
    # "true".
    # @return [Array[Feature]]
    attr_accessor :features

    # Flag set to indicate if account details can be edited or not. Default is
    # "true".
    # @return [Array[CarrierServicePlan]]
    attr_accessor :service_plans

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['account_name'] = 'accountName'
      @_hash['account_number'] = 'accountNumber'
      @_hash['organization_name'] = 'organizationName'
      @_hash['is_provisioning_allowed'] = 'isProvisioningAllowed'
      @_hash['carriers'] = 'carriers'
      @_hash['features'] = 'features'
      @_hash['service_plans'] = 'servicePlans'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        account_name
        account_number
        organization_name
        is_provisioning_allowed
        carriers
        features
        service_plans
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(account_name: SKIP, account_number: SKIP,
                   organization_name: SKIP, is_provisioning_allowed: SKIP,
                   carriers: SKIP, features: SKIP, service_plans: SKIP,
                   additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @account_name = account_name unless account_name == SKIP
      @account_number = account_number unless account_number == SKIP
      @organization_name = organization_name unless organization_name == SKIP
      @is_provisioning_allowed = is_provisioning_allowed unless is_provisioning_allowed == SKIP
      @carriers = carriers unless carriers == SKIP
      @features = features unless features == SKIP
      @service_plans = service_plans unless service_plans == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      account_name = hash.key?('accountName') ? hash['accountName'] : SKIP
      account_number = hash.key?('accountNumber') ? hash['accountNumber'] : SKIP
      organization_name =
        hash.key?('organizationName') ? hash['organizationName'] : SKIP
      is_provisioning_allowed =
        hash.key?('isProvisioningAllowed') ? hash['isProvisioningAllowed'] : SKIP
      # Parameter is an array, so we need to iterate through it
      carriers = nil
      unless hash['carriers'].nil?
        carriers = []
        hash['carriers'].each do |structure|
          carriers << (Carrier.from_hash(structure) if structure)
        end
      end

      carriers = SKIP unless hash.key?('carriers')
      # Parameter is an array, so we need to iterate through it
      features = nil
      unless hash['features'].nil?
        features = []
        hash['features'].each do |structure|
          features << (Feature.from_hash(structure) if structure)
        end
      end

      features = SKIP unless hash.key?('features')
      # Parameter is an array, so we need to iterate through it
      service_plans = nil
      unless hash['servicePlans'].nil?
        service_plans = []
        hash['servicePlans'].each do |structure|
          service_plans << (CarrierServicePlan.from_hash(structure) if structure)
        end
      end

      service_plans = SKIP unless hash.key?('servicePlans')

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      AccountDetails.new(account_name: account_name,
                         account_number: account_number,
                         organization_name: organization_name,
                         is_provisioning_allowed: is_provisioning_allowed,
                         carriers: carriers,
                         features: features,
                         service_plans: service_plans,
                         additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name}, account_number: #{@account_number},"\
      " organization_name: #{@organization_name}, is_provisioning_allowed:"\
      " #{@is_provisioning_allowed}, carriers: #{@carriers}, features: #{@features},"\
      " service_plans: #{@service_plans}, additional_properties: #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name.inspect}, account_number:"\
      " #{@account_number.inspect}, organization_name: #{@organization_name.inspect},"\
      " is_provisioning_allowed: #{@is_provisioning_allowed.inspect}, carriers:"\
      " #{@carriers.inspect}, features: #{@features.inspect}, service_plans:"\
      " #{@service_plans.inspect}, additional_properties: #{@additional_properties}>"
    end
  end
end
