# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # A success response includes an array of all matching events. Each event
  # includes the full event resource definition.
  class CreateIoTApplicationResponse < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # An application will be created under the user's Azure subscription with
    # this name and of type IOT central.
    # @return [String]
    attr_accessor :app_name

    # Part of the user credentials (from Azure) the user needs to use for
    # calling further TS Core APIs for setting up Azure cloud connector.
    # @return [String]
    attr_accessor :shared_secret

    # An IOT central endpoint the user can use to see the data that is being
    # streamed.
    # @return [String]
    attr_accessor :url

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['app_name'] = 'appName'
      @_hash['shared_secret'] = 'sharedSecret'
      @_hash['url'] = 'url'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        app_name
        shared_secret
        url
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(app_name: SKIP, shared_secret: SKIP, url: SKIP,
                   additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @app_name = app_name unless app_name == SKIP
      @shared_secret = shared_secret unless shared_secret == SKIP
      @url = url unless url == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      app_name = hash.key?('appName') ? hash['appName'] : SKIP
      shared_secret = hash.key?('sharedSecret') ? hash['sharedSecret'] : SKIP
      url = hash.key?('url') ? hash['url'] : SKIP

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      CreateIoTApplicationResponse.new(app_name: app_name,
                                       shared_secret: shared_secret,
                                       url: url,
                                       additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} app_name: #{@app_name}, shared_secret: #{@shared_secret}, url: #{@url},"\
      " additional_properties: #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} app_name: #{@app_name.inspect}, shared_secret: #{@shared_secret.inspect},"\
      " url: #{@url.inspect}, additional_properties: #{@additional_properties}>"
    end
  end
end
