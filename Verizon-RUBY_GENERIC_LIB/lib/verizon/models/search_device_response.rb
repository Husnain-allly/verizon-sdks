# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # A success response includes an array of all matching events. Each event
  # includes the full event resource definition.
  class SearchDeviceResponse < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # The action requested in this event; “change” for device configuration
    # changes.
    # @return [String]
    attr_accessor :action

    # The date and time of the change request.
    # @return [String]
    attr_accessor :createdon

    # The device’s ThingSpace UUID.
    # @return [String]
    attr_accessor :deviceid

    # List of fields affected by the event.
    # @return [Fields2]
    attr_accessor :fields

    # The unique ID of this ts.event.configuration event.
    # @return [String]
    attr_accessor :id

    # The kind of the ThingSpace resource that is being reported;
    # “ts.event.configuration” for device configuration changes.
    # @return [String]
    attr_accessor :kind

    # The date and time that the event was last updated.
    # @return [String]
    attr_accessor :lastupdated

    # The name of the event
    # @return [String]
    attr_accessor :name

    # The current status of the request.
    # @return [String]
    attr_accessor :state

    # UUIDs of tag resources that are applied to this device.
    # @return [Array[String]]
    attr_accessor :tagids

    # transaction id
    # @return [String]
    attr_accessor :transactionid

    # The version of the resource.
    # @return [String]
    attr_accessor :version

    # The version of the resource.
    # @return [String]
    attr_accessor :versionid

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['action'] = 'action'
      @_hash['createdon'] = 'createdon'
      @_hash['deviceid'] = 'deviceid'
      @_hash['fields'] = 'fields'
      @_hash['id'] = 'id'
      @_hash['kind'] = 'kind'
      @_hash['lastupdated'] = 'lastupdated'
      @_hash['name'] = 'name'
      @_hash['state'] = 'state'
      @_hash['tagids'] = 'tagids'
      @_hash['transactionid'] = 'transactionid'
      @_hash['version'] = 'version'
      @_hash['versionid'] = 'versionid'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        action
        createdon
        deviceid
        fields
        id
        kind
        lastupdated
        name
        state
        tagids
        transactionid
        version
        versionid
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(action: SKIP, createdon: SKIP, deviceid: SKIP, fields: SKIP,
                   id: SKIP, kind: SKIP, lastupdated: SKIP, name: SKIP,
                   state: SKIP, tagids: SKIP, transactionid: SKIP,
                   version: SKIP, versionid: SKIP, additional_properties: nil)
      # Add additional model properties to the instance
      additional_properties = {} if additional_properties.nil?

      @action = action unless action == SKIP
      @createdon = createdon unless createdon == SKIP
      @deviceid = deviceid unless deviceid == SKIP
      @fields = fields unless fields == SKIP
      @id = id unless id == SKIP
      @kind = kind unless kind == SKIP
      @lastupdated = lastupdated unless lastupdated == SKIP
      @name = name unless name == SKIP
      @state = state unless state == SKIP
      @tagids = tagids unless tagids == SKIP
      @transactionid = transactionid unless transactionid == SKIP
      @version = version unless version == SKIP
      @versionid = versionid unless versionid == SKIP
      @additional_properties = additional_properties
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      action = hash.key?('action') ? hash['action'] : SKIP
      createdon = hash.key?('createdon') ? hash['createdon'] : SKIP
      deviceid = hash.key?('deviceid') ? hash['deviceid'] : SKIP
      fields = Fields2.from_hash(hash['fields']) if hash['fields']
      id = hash.key?('id') ? hash['id'] : SKIP
      kind = hash.key?('kind') ? hash['kind'] : SKIP
      lastupdated = hash.key?('lastupdated') ? hash['lastupdated'] : SKIP
      name = hash.key?('name') ? hash['name'] : SKIP
      state = hash.key?('state') ? hash['state'] : SKIP
      tagids = hash.key?('tagids') ? hash['tagids'] : SKIP
      transactionid = hash.key?('transactionid') ? hash['transactionid'] : SKIP
      version = hash.key?('version') ? hash['version'] : SKIP
      versionid = hash.key?('versionid') ? hash['versionid'] : SKIP

      # Create a new hash for additional properties, removing known properties.
      new_hash = hash.reject { |k, _| names.value?(k) }

      additional_properties = APIHelper.get_additional_properties(
        new_hash, proc { |value| value }
      )

      # Create object from extracted values.
      SearchDeviceResponse.new(action: action,
                               createdon: createdon,
                               deviceid: deviceid,
                               fields: fields,
                               id: id,
                               kind: kind,
                               lastupdated: lastupdated,
                               name: name,
                               state: state,
                               tagids: tagids,
                               transactionid: transactionid,
                               version: version,
                               versionid: versionid,
                               additional_properties: additional_properties)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} action: #{@action}, createdon: #{@createdon}, deviceid: #{@deviceid},"\
      " fields: #{@fields}, id: #{@id}, kind: #{@kind}, lastupdated: #{@lastupdated}, name:"\
      " #{@name}, state: #{@state}, tagids: #{@tagids}, transactionid: #{@transactionid}, version:"\
      " #{@version}, versionid: #{@versionid}, additional_properties: #{@additional_properties}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} action: #{@action.inspect}, createdon: #{@createdon.inspect}, deviceid:"\
      " #{@deviceid.inspect}, fields: #{@fields.inspect}, id: #{@id.inspect}, kind:"\
      " #{@kind.inspect}, lastupdated: #{@lastupdated.inspect}, name: #{@name.inspect}, state:"\
      " #{@state.inspect}, tagids: #{@tagids.inspect}, transactionid: #{@transactionid.inspect},"\
      " version: #{@version.inspect}, versionid: #{@versionid.inspect}, additional_properties:"\
      " #{@additional_properties}>"
    end
  end
end
