# verizon
#
# This file was automatically generated by APIMATIC v2.0
# ( https://apimatic.io ).

module Verizon
  # Response for /v2/clients/registration. It provides a generated device ID and
  # the certificates needed to connect the ETX Message Exchange.
  class ClientPersistenceResponse < BaseModel
    SKIP = Object.new
    private_constant :SKIP

    # The generated ID (UUID v4) for the device. It can be used as:
    #   - the MQTT Client ID when connecting to the Message Exchange system
    #   - a parameter when asking for the connection endpoint
    #   - a parameter when finishing the device registration
    #   - a parameter when unregistering the device
    # @return [UUID | String]
    attr_accessor :device_id

    # Structure for the credentials required to connect to the ETX MQTT Message
    # Exchange.
    # @return [Certificate]
    attr_accessor :certificate

    # The type of the client that is to be registered. This is one of the major
    # traffic participant groups considered in V2X communication. The system
    # uses this value to define which topics the client will be able to publish
    # and subscribe to.
    # Values:
    # - **Vehicle** - Vehicle with an enclosure around the passengers.
    # (Subtypes: PassengerCar, Truck, Bus, EmergencyVehicle, SchoolBus,
    # MaintenanceVehicle)
    # - **VulnerableRoadUser** - Traffic participants without a protecting
    # enclosure. (Subtypes: Motorcycle, Bicycle, Pedestrian, Scooter)
    # - **TrafficLightController** - A Traffic light controller system.
    # (Subtypes: NA)
    # - **InfrastructureSensor** - Sensors that are deployed in the
    # infrastructure. (Subtypes: RoadSideUnit, Camera, Lidar, Radar,
    # InductiveLoop, MagneticSensor)
    # - **OnboardSensor** - Sensors that are onboard on a vehicle(Subtypes:
    # Camera, Lidar, Radar)
    # - **Software** - A software system or application. (Subtypes: Platform,
    # Application, NA)
    # @return [EtxClientType]
    attr_accessor :client_type

    # The subtype or subgroup of the client type. This further specifies the
    # client type. For example it will specify if the client is a passenger car
    # or a truck. See the ClientType description for the supported Subtypes for
    # each client type.
    # @return [ClientSubtype]
    attr_accessor :client_subtype

    # The ID the vendor wants its devices to be registered under. E.g. Verizon,
    # GM, Ford, etc.
    # @return [String]
    attr_accessor :vendor_id

    # A mapping from model property names to API property names.
    def self.names
      @_hash = {} if @_hash.nil?
      @_hash['device_id'] = 'DeviceID'
      @_hash['certificate'] = 'Certificate'
      @_hash['client_type'] = 'ClientType'
      @_hash['client_subtype'] = 'ClientSubtype'
      @_hash['vendor_id'] = 'VendorID'
      @_hash
    end

    # An array for optional fields
    def self.optionals
      %w[
        device_id
        certificate
        client_type
        client_subtype
        vendor_id
      ]
    end

    # An array for nullable fields
    def self.nullables
      []
    end

    def initialize(device_id: SKIP, certificate: SKIP, client_type: SKIP,
                   client_subtype: SKIP, vendor_id: SKIP)
      @device_id = device_id unless device_id == SKIP
      @certificate = certificate unless certificate == SKIP
      @client_type = client_type unless client_type == SKIP
      @client_subtype = client_subtype unless client_subtype == SKIP
      @vendor_id = vendor_id unless vendor_id == SKIP
    end

    # Creates an instance of the object from a hash.
    def self.from_hash(hash)
      return nil unless hash

      # Extract variables from the hash.
      device_id = hash.key?('DeviceID') ? hash['DeviceID'] : SKIP
      certificate = Certificate.from_hash(hash['Certificate']) if hash['Certificate']
      client_type = hash.key?('ClientType') ? hash['ClientType'] : SKIP
      client_subtype = hash.key?('ClientSubtype') ? hash['ClientSubtype'] : SKIP
      vendor_id = hash.key?('VendorID') ? hash['VendorID'] : SKIP

      # Create object from extracted values.
      ClientPersistenceResponse.new(device_id: device_id,
                                    certificate: certificate,
                                    client_type: client_type,
                                    client_subtype: client_subtype,
                                    vendor_id: vendor_id)
    end

    # Provides a human-readable string representation of the object.
    def to_s
      class_name = self.class.name.split('::').last
      "<#{class_name} device_id: #{@device_id}, certificate: #{@certificate}, client_type:"\
      " #{@client_type}, client_subtype: #{@client_subtype}, vendor_id: #{@vendor_id}>"
    end

    # Provides a debugging-friendly string with detailed object information.
    def inspect
      class_name = self.class.name.split('::').last
      "<#{class_name} device_id: #{@device_id.inspect}, certificate: #{@certificate.inspect},"\
      " client_type: #{@client_type.inspect}, client_subtype: #{@client_subtype.inspect},"\
      " vendor_id: #{@vendor_id.inspect}>"
    end
  end
end
