# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # RetrievesAvailableFilesResponse Model.
  class RetrievesAvailableFilesResponse < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # ThingSpace-generated name of the file. You will use this name when listing
    # or scheduling campaigns for the file.
    # @return [String]
    attr_accessor :file_name

    # Version of the file.
    # @return [String]
    attr_accessor :file_version

    # Software release note.
    # @return [String]
    attr_accessor :release_note

    # The software-applicable device make.
    # @return [String]
    attr_accessor :make

    # The software-applicable device model.
    # @return [String]
    attr_accessor :model

    # Local target path on the device.
    # @return [String]
    attr_accessor :local_target_path

    # Valid values
    # @return [String]
    attr_accessor :distribution_type

    # The platform (Android, iOS, etc.,) that the software can be applied to.
    # @return [String]
    attr_accessor :device_platform_id

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['file_name'] = 'fileName'
      @_hash['file_version'] = 'fileVersion'
      @_hash['release_note'] = 'releaseNote'
      @_hash['make'] = 'make'
      @_hash['model'] = 'model'
      @_hash['local_target_path'] = 'localTargetPath'
      @_hash['distribution_type'] = 'distributionType'
      @_hash['device_platform_id'] = 'devicePlatformId'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        file_name
        file_version
        release_note
        make
        model
        local_target_path
        distribution_type
        device_platform_id
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(file_name: SKIP, file_version: SKIP, release_note: SKIP,
                   make: SKIP, model: SKIP, local_target_path: SKIP,
                   distribution_type: SKIP, device_platform_id: SKIP,
                   additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @file_name = file_name unless file_name == SKIP
      @file_version = file_version unless file_version == SKIP
      @release_note = release_note unless release_note == SKIP
      @make = make unless make == SKIP
      @model = model unless model == SKIP
      @local_target_path = local_target_path unless local_target_path == SKIP
      @distribution_type = distribution_type unless distribution_type == SKIP
      @device_platform_id = device_platform_id unless device_platform_id == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      file_name = hash.key?('fileName') ? hash['fileName'] : SKIP
      file_version = hash.key?('fileVersion') ? hash['fileVersion'] : SKIP
      release_note = hash.key?('releaseNote') ? hash['releaseNote'] : SKIP
      make = hash.key?('make') ? hash['make'] : SKIP
      model = hash.key?('model') ? hash['model'] : SKIP
      local_target_path =
        hash.key?('localTargetPath') ? hash['localTargetPath'] : SKIP
      distribution_type =
        hash.key?('distributionType') ? hash['distributionType'] : SKIP
      device_platform_id =
        hash.key?('devicePlatformId') ? hash['devicePlatformId'] : SKIP

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      RetrievesAvailableFilesResponse.new(file_name: file_name,
                                          file_version: file_version,
                                          release_note: release_note,
                                          make: make,
                                          model: model,
                                          local_target_path: local_target_path,
                                          distribution_type: distribution_type,
                                          device_platform_id: device_platform_id,
                                          additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} file_name: #{@file_name}, file_version: #{@file_version}, release_note:"\
      " #{@release_note}, make: #{@make}, model: #{@model}, local_target_path:"\
      " #{@local_target_path}, distribution_type: #{@distribution_type}, device_platform_id:"\
      " #{@device_platform_id}, additional_properties: #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} file_name: #{@file_name.inspect}, file_version: #{@file_version.inspect},"\
      " release_note: #{@release_note.inspect}, make: #{@make.inspect}, model: #{@model.inspect},"\
      " local_target_path: #{@local_target_path.inspect}, distribution_type:"\
      " #{@distribution_type.inspect}, device_platform_id: #{@device_platform_id.inspect},"\
      " additional_properties: #{@additional_properties}>"
    end
  end
end
