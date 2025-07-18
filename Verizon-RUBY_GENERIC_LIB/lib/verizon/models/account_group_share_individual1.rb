# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # AccountGroupShareIndividual1 Model.
  class AccountGroupShareIndividual1 < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # TODO: Write general description for this method
    # @return [AccountGroupShareFilterCriteria]
    attr_accessor :account_group_share_individual

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['account_group_share_individual'] = 'accountGroupShareIndividual'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        account_group_share_individual
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(account_group_share_individual: SKIP,
                   additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      unless account_group_share_individual == SKIP
        @account_group_share_individual =
          account_group_share_individual
      end
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      if hash['accountGroupShareIndividual']
        account_group_share_individual = AccountGroupShareFilterCriteria.from_hash(hash['accountGroupShareIndividual'])
      end

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      AccountGroupShareIndividual1.new(account_group_share_individual: account_group_share_individual,
                                       additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} account_group_share_individual: #{@account_group_share_individual},"\
      " additional_properties: #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} account_group_share_individual: #{@account_group_share_individual.inspect},"\
      " additional_properties: #{@additional_properties}>"
    end
  end
end
