# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # ServiceUsage Model.
  class ServiceUsage < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # Account identifier.
    # @return [String]
    attr_accessor :account_name

    # Total requests for the account during the reporting period.
    # @return [String]
    attr_accessor :transactions_count

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['account_name'] = 'accountName'
      @_hash['transactions_count'] = 'transactionsCount'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        account_name
        transactions_count
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(account_name: SKIP, transactions_count: SKIP,
                   additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @account_name = account_name unless account_name == SKIP
      @transactions_count = transactions_count unless transactions_count == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      account_name = hash.key?('accountName') ? hash['accountName'] : SKIP
      transactions_count =
        hash.key?('transactionsCount') ? hash['transactionsCount'] : SKIP

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      ServiceUsage.new(account_name: account_name,
                       transactions_count: transactions_count,
                       additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name}, transactions_count: #{@transactions_count},"\
      " additional_properties: #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} account_name: #{@account_name.inspect}, transactions_count:"\
      " #{@transactions_count.inspect}, additional_properties: #{@additional_properties}>"
    end
  end
end
