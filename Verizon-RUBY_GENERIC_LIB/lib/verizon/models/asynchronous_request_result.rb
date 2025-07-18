# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # A successful request returns the request ID and the current status.
  class AsynchronousRequestResult < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # The unique ID of the asynchronous request.
    # @return [String]
    attr_accessor :request_id

    # The current status of the callback response.
    # @return [RequestStatus]
    attr_accessor :status

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['request_id'] = 'requestId'
      @_hash['status'] = 'status'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        request_id
        status
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(request_id: SKIP, status: SKIP, additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @request_id = request_id unless request_id == SKIP
      @status = status unless status == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      request_id = hash.key?('requestId') ? hash['requestId'] : SKIP
      status = hash.key?('status') ? hash['status'] : SKIP

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      AsynchronousRequestResult.new(request_id: request_id,
                                    status: status,
                                    additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} request_id: #{@request_id}, status: #{@status}, additional_properties:"\
      " #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} request_id: #{@request_id.inspect}, status: #{@status.inspect},"\
      " additional_properties: #{@additional_properties}>"
    end
  end
end
