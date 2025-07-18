# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Subrequest Model.
  class Subrequest < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # TODO: Write general description for this method
    # @return [GioDeviceId]
    attr_accessor :ids

    # TODO: Write general description for this method
    # @return [String]
    attr_accessor :status

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['ids'] = 'ids'
      @_hash['status'] = 'status'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        ids
        status
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(ids: SKIP, status: SKIP)
      @ids = ids unless ids == SKIP
      @status = status unless status == SKIP
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      ids = GioDeviceId.from_hash(hash['ids']) if hash['ids']
      status = hash.key?('status') ? hash['status'] : SKIP

      # Create object from extracted values.
      Subrequest.new(ids: ids,
                     status: status)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} ids: #{@ids}, status: #{@status}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} ids: #{@ids.inspect}, status: #{@status.inspect}>"
    end
  end
end
