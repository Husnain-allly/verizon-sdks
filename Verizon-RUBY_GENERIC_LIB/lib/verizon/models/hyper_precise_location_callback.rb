# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Callback registration request.
  class HyperPreciseLocationCallback < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # The name of the callback service that you want to subscribe to.
    # @return [String]
    attr_accessor :name

    # The address on your server where you have enabled a listening service for
    # the specific type of callback messages. Specify a URL that is reachable
    # from the Verizon data centers. If your service is running on HTTPS, you
    # should use a one-way authentication certificate with a white-listed IP
    # address.
    # @return [String]
    attr_accessor :url

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['name'] = 'name'
      @_hash['url'] = 'url'
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

    def initialize(name:, url:, additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @name = name
      @url = url
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      name = hash.key?('name') ? hash['name'] : nil
      url = hash.key?('url') ? hash['url'] : nil

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      HyperPreciseLocationCallback.new(name: name,
                                       url: url,
                                       additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} name: #{@name}, url: #{@url}, additional_properties:"\
      " #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} name: #{@name.inspect}, url: #{@url.inspect}, additional_properties:"\
      " #{@additional_properties}>"
    end
  end
end
