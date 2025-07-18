# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # TargetAuthenticationBody Model.
  class TargetAuthenticationBody < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # Authentication grant type.
    # @return [String]
    attr_accessor :grant_type

    # Refresh token.
    # @return [String]
    attr_accessor :refresh_token

    # Authentication scopes.
    # @return [String]
    attr_accessor :scope

    # Authentication headers.
    # @return [TargetAuthenticationBodyHeaders]
    attr_accessor :headers

    # Host information.
    # @return [TargetAuthenticationBodyHost]
    attr_accessor :host

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['grant_type'] = 'grant_type'
      @_hash['refresh_token'] = 'refresh_token'
      @_hash['scope'] = 'scope'
      @_hash['headers'] = 'headers'
      @_hash['host'] = 'host'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        grant_type
        refresh_token
        scope
        headers
        host
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(grant_type: SKIP, refresh_token: SKIP, scope: SKIP,
                   headers: SKIP, host: SKIP, additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @grant_type = grant_type unless grant_type == SKIP
      @refresh_token = refresh_token unless refresh_token == SKIP
      @scope = scope unless scope == SKIP
      @headers = headers unless headers == SKIP
      @host = host unless host == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      grant_type = hash.key?('grant_type') ? hash['grant_type'] : SKIP
      refresh_token = hash.key?('refresh_token') ? hash['refresh_token'] : SKIP
      scope = hash.key?('scope') ? hash['scope'] : SKIP
      headers = TargetAuthenticationBodyHeaders.from_hash(hash['headers']) if hash['headers']
      host = TargetAuthenticationBodyHost.from_hash(hash['host']) if hash['host']

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      TargetAuthenticationBody.new(grant_type: grant_type,
                                   refresh_token: refresh_token,
                                   scope: scope,
                                   headers: headers,
                                   host: host,
                                   additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} grant_type: #{@grant_type}, refresh_token: #{@refresh_token}, scope:"\
      " #{@scope}, headers: #{@headers}, host: #{@host}, additional_properties:"\
      " #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} grant_type: #{@grant_type.inspect}, refresh_token:"\
      " #{@refresh_token.inspect}, scope: #{@scope.inspect}, headers: #{@headers.inspect}, host:"\
      " #{@host.inspect}, additional_properties: #{@additional_properties}>"
    end
  end
end
