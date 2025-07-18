# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Software package information.
  class SoftwarePackage < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # Software name.
    # @return [String]
    attr_accessor :software_name

    # Software launch date.
    # @return [Date]
    attr_accessor :launch_date

    # Software release note reserved for future use.
    # @return [String]
    attr_accessor :release_note

    # Software applicable device model.
    # @return [String]
    attr_accessor :model

    # Software applicable device make.
    # @return [String]
    attr_accessor :make

    # LWM2M, OMD-DM or HTTP.
    # @return [String]
    attr_accessor :distribution_type

    # The platform (Android, iOS, etc.) that the software can be applied to.
    # @return [String]
    attr_accessor :device_platform_id

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['software_name'] = 'softwareName'
      @_hash['launch_date'] = 'launchDate'
      @_hash['release_note'] = 'releaseNote'
      @_hash['model'] = 'model'
      @_hash['make'] = 'make'
      @_hash['distribution_type'] = 'distributionType'
      @_hash['device_platform_id'] = 'devicePlatformId'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        release_note
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(software_name:, launch_date:, model:, make:,
                   distribution_type:, device_platform_id:, release_note: SKIP,
                   additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @software_name = software_name
      @launch_date = launch_date
      @release_note = release_note unless release_note == SKIP
      @model = model
      @make = make
      @distribution_type = distribution_type
      @device_platform_id = device_platform_id
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      software_name = hash.key?('softwareName') ? hash['softwareName'] : nil
      launch_date = hash.key?('launchDate') ? hash['launchDate'] : nil
      model = hash.key?('model') ? hash['model'] : nil
      make = hash.key?('make') ? hash['make'] : nil
      distribution_type =
        hash.key?('distributionType') ? hash['distributionType'] : nil
      device_platform_id =
        hash.key?('devicePlatformId') ? hash['devicePlatformId'] : nil
      release_note = hash.key?('releaseNote') ? hash['releaseNote'] : SKIP

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      SoftwarePackage.new(software_name: software_name,
                          launch_date: launch_date,
                          model: model,
                          make: make,
                          distribution_type: distribution_type,
                          device_platform_id: device_platform_id,
                          release_note: release_note,
                          additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} software_name: #{@software_name}, launch_date: #{@launch_date},"\
      " release_note: #{@release_note}, model: #{@model}, make: #{@make}, distribution_type:"\
      " #{@distribution_type}, device_platform_id: #{@device_platform_id}, additional_properties:"\
      " #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} software_name: #{@software_name.inspect}, launch_date:"\
      " #{@launch_date.inspect}, release_note: #{@release_note.inspect}, model: #{@model.inspect},"\
      " make: #{@make.inspect}, distribution_type: #{@distribution_type.inspect},"\
      " device_platform_id: #{@device_platform_id.inspect}, additional_properties:"\
      " #{@additional_properties}>"
    end
  end
end
