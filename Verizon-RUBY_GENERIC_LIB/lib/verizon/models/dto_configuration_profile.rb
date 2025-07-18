# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # DtoConfigurationProfile Model.
  class DtoConfigurationProfile < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # The numeric account name, which must include leading zeros
    # @return [String]
    attr_accessor :accountname

    # The numeric account name, which must include leading zeros
    # @return [Array[DtoProfile]]
    attr_accessor :profiles

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['accountname'] = 'accountname'
      @_hash['profiles'] = 'profiles'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        accountname
        profiles
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(accountname: SKIP, profiles: SKIP,
                   additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @accountname = accountname unless accountname == SKIP
      @profiles = profiles unless profiles == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      accountname = hash.key?('accountname') ? hash['accountname'] : SKIP
      # Parameter is an array, so we need to iterate through it
      profiles = nil
      unless hash['profiles'].nil?
        profiles = []
        hash['profiles'].each do |structure|
          profiles << (DtoProfile.from_hash(structure) if structure)
        end
      end

      profiles = SKIP unless hash.key?('profiles')

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      DtoConfigurationProfile.new(accountname: accountname,
                                  profiles: profiles,
                                  additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} accountname: #{@accountname}, profiles: #{@profiles},"\
      " additional_properties: #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} accountname: #{@accountname.inspect}, profiles: #{@profiles.inspect},"\
      " additional_properties: #{@additional_properties}>"
    end
  end
end
