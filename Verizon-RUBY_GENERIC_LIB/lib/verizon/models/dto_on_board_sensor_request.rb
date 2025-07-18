# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # DtoOnBoardSensorRequest Model.
  class DtoOnBoardSensorRequest < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # The numeric account name, which must include leading zeros
    # @return [String]
    attr_accessor :accountname

    # The numeric account name, which must include leading zeros
    # @return [Payload]
    attr_accessor :payload

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['accountname'] = 'accountname'
      @_hash['payload'] = 'payload'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        accountname
        payload
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(accountname: SKIP, payload: SKIP)
      @accountname = accountname unless accountname == SKIP
      @payload = payload unless payload == SKIP
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      accountname = hash.key?('accountname') ? hash['accountname'] : SKIP
      payload = Payload.from_hash(hash['payload']) if hash['payload']

      # Create object from extracted values.
      DtoOnBoardSensorRequest.new(accountname: accountname,
                                  payload: payload)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} accountname: #{@accountname}, payload: #{@payload}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} accountname: #{@accountname.inspect}, payload: #{@payload.inspect}>"
    end
  end
end
