# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

require 'date'
module Verizon
  # Structure for the credentials required to connect to the ETX MQTT Message
  # Exchange.
  class Certificate < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # The string containing the certificate
    # @return [String]
    attr_accessor :cert_pem

    # The string containing the private key
    # @return [String]
    attr_accessor :key_pem

    # The string containing the CA certificate
    # @return [String]
    attr_accessor :ca_pem

    # The string describing the expiration timestamp of the certificate
    # @return [DateTime]
    attr_accessor :expiration_time

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['cert_pem'] = 'cert.pem'
      @_hash['key_pem'] = 'key.pem'
      @_hash['ca_pem'] = 'ca.pem'
      @_hash['expiration_time'] = 'ExpirationTime'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      []
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(cert_pem:, key_pem:, ca_pem:, expiration_time:)
      @cert_pem = cert_pem
      @key_pem = key_pem
      @ca_pem = ca_pem
      @expiration_time = expiration_time
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      cert_pem = hash.key?('cert.pem') ? hash['cert.pem'] : nil
      key_pem = hash.key?('key.pem') ? hash['key.pem'] : nil
      ca_pem = hash.key?('ca.pem') ? hash['ca.pem'] : nil
      expiration_time = if hash.key?('ExpirationTime')
                          (DateTimeHelper.from_rfc3339(hash['ExpirationTime']) if hash['ExpirationTime'])
                        end

      # Create object from extracted values.
      Certificate.new(cert_pem: cert_pem,
                      key_pem: key_pem,
                      ca_pem: ca_pem,
                      expiration_time: expiration_time)
    end

    def to_custom_expiration_time
      DateTimeHelper.to_rfc3339(expiration_time)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} cert_pem: #{@cert_pem}, key_pem: #{@key_pem}, ca_pem: #{@ca_pem},"\
      " expiration_time: #{@expiration_time}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} cert_pem: #{@cert_pem.inspect}, key_pem: #{@key_pem.inspect}, ca_pem:"\
      " #{@ca_pem.inspect}, expiration_time: #{@expiration_time.inspect}>"
    end
  end
end
