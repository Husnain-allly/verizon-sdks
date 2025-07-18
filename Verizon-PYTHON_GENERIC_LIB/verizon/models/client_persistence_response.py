# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.certificate import Certificate


class ClientPersistenceResponse(object):

    """Implementation of the 'ClientPersistenceResponse' model.

    Response for /v2/clients/registration. It provides a generated device ID
    and the certificates needed to connect the ETX Message Exchange.

    Attributes:
        device_id (uuid|str): The generated ID (UUID v4) for the device. It
            can be used as:   - the MQTT Client ID when connecting to the
            Message Exchange system   - a parameter when asking for the
            connection endpoint   - a parameter when finishing the device
            registration   - a parameter when unregistering the device
        certificate (Certificate): Structure for the credentials required to
            connect to the ETX MQTT Message Exchange.
        client_type (EtxClientType): The type of the client that is to be
            registered. This is one of the major traffic participant groups
            considered in V2X communication. The system uses this value to
            define which topics the client will be able to publish and
            subscribe to.  Values: - **Vehicle** - Vehicle with an enclosure
            around the passengers. (Subtypes: PassengerCar, Truck, Bus,
            EmergencyVehicle, SchoolBus, MaintenanceVehicle) -
            **VulnerableRoadUser** - Traffic participants without a protecting
            enclosure. (Subtypes: Motorcycle, Bicycle, Pedestrian, Scooter) -
            **TrafficLightController** - A Traffic light controller system.
            (Subtypes: NA) - **InfrastructureSensor** - Sensors that are
            deployed in the infrastructure. (Subtypes: RoadSideUnit, Camera,
            Lidar, Radar, InductiveLoop, MagneticSensor) - **OnboardSensor** -
            Sensors that are onboard on a vehicle(Subtypes: Camera, Lidar,
            Radar) - **Software** - A software system or application.
            (Subtypes: Platform, Application, NA)
        client_subtype (ClientSubtype): The subtype or subgroup of the client
            type. This further specifies the client type. For example it will
            specify if the client is a passenger car or a truck. See the
            ClientType description for the supported Subtypes for each client
            type.
        vendor_id (str): The ID the vendor wants its devices to be registered
            under. E.g. Verizon, GM, Ford, etc.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "device_id": 'DeviceID',
        "certificate": 'Certificate',
        "client_type": 'ClientType',
        "client_subtype": 'ClientSubtype',
        "vendor_id": 'VendorID'
    }

    _optionals = [
        'device_id',
        'certificate',
        'client_type',
        'client_subtype',
        'vendor_id',
    ]

    def __init__(self,
                 device_id=APIHelper.SKIP,
                 certificate=APIHelper.SKIP,
                 client_type=APIHelper.SKIP,
                 client_subtype=APIHelper.SKIP,
                 vendor_id=APIHelper.SKIP):
        """Constructor for the ClientPersistenceResponse class"""

        # Initialize members of the class
        if device_id is not APIHelper.SKIP:
            self.device_id = device_id 
        if certificate is not APIHelper.SKIP:
            self.certificate = certificate 
        if client_type is not APIHelper.SKIP:
            self.client_type = client_type 
        if client_subtype is not APIHelper.SKIP:
            self.client_subtype = client_subtype 
        if vendor_id is not APIHelper.SKIP:
            self.vendor_id = vendor_id 

    @classmethod
    def from_dictionary(cls,
                        dictionary):
        """Creates an instance of this model from a dictionary

        Args:
            dictionary (dictionary): A dictionary representation of the object
            as obtained from the deserialization of the server's response. The
            keys MUST match property names in the API description.

        Returns:
            object: An instance of this structure class.

        """

        if not isinstance(dictionary, dict) or dictionary is None:
            return None

        # Extract variables from the dictionary
        device_id = dictionary.get("DeviceID") if dictionary.get("DeviceID") else APIHelper.SKIP
        certificate = Certificate.from_dictionary(dictionary.get('Certificate')) if 'Certificate' in dictionary.keys() else APIHelper.SKIP
        client_type = dictionary.get("ClientType") if dictionary.get("ClientType") else APIHelper.SKIP
        client_subtype = dictionary.get("ClientSubtype") if dictionary.get("ClientSubtype") else APIHelper.SKIP
        vendor_id = dictionary.get("VendorID") if dictionary.get("VendorID") else APIHelper.SKIP
        # Return an object of this model
        return cls(device_id,
                   certificate,
                   client_type,
                   client_subtype,
                   vendor_id)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'device_id={(self.device_id if hasattr(self, "device_id") else None)!r}, '
                f'certificate={(self.certificate if hasattr(self, "certificate") else None)!r}, '
                f'client_type={(self.client_type if hasattr(self, "client_type") else None)!r}, '
                f'client_subtype={(self.client_subtype if hasattr(self, "client_subtype") else None)!r}, '
                f'vendor_id={(self.vendor_id if hasattr(self, "vendor_id") else None)!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'device_id={(self.device_id if hasattr(self, "device_id") else None)!s}, '
                f'certificate={(self.certificate if hasattr(self, "certificate") else None)!s}, '
                f'client_type={(self.client_type if hasattr(self, "client_type") else None)!s}, '
                f'client_subtype={(self.client_subtype if hasattr(self, "client_subtype") else None)!s}, '
                f'vendor_id={(self.vendor_id if hasattr(self, "vendor_id") else None)!s})')
