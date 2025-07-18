# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.models.geolocation import Geolocation


class ConnectionRequest(object):

    """Implementation of the 'ConnectionRequest' model.

    Request for /clients/connection. It requires the device ID acquired in the
    registration request call; the geolocation of the device at the time of
    the request; and the network type (Verizon or non-Verizon). The system
    uses this information to determine with MQTT endpoint the device should
    use to connect the ETX Message Exchange.

    Attributes:
        device_id (uuid|str): The generated ID (UUID v4) for the device. It
            can be used as:   - the MQTT Client ID when connecting to the
            Message Exchange system   - a parameter when asking for the
            connection endpoint   - a parameter when finishing the device
            registration   - a parameter when unregistering the device
        geolocation (Geolocation): Geolocation of the device at the time of
            the connection request in GPS coordinates.
        network_type (EtxNetworkType): The type of the device's network
            connection at the time of the request. If the device is on the
            Verizon cellular network it should use the "VZ" value otherwise
            the "non-VZ" value.  Devices on the Verizon network can directly
            access the ETX Message Exchange on the MEC (Mobile Edge Compute
            server)

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "device_id": 'DeviceID',
        "geolocation": 'Geolocation',
        "network_type": 'NetworkType'
    }

    def __init__(self,
                 device_id=None,
                 geolocation=None,
                 network_type=None):
        """Constructor for the ConnectionRequest class"""

        # Initialize members of the class
        self.device_id = device_id 
        self.geolocation = geolocation 
        self.network_type = network_type 

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
        device_id = dictionary.get("DeviceID") if dictionary.get("DeviceID") else None
        geolocation = Geolocation.from_dictionary(dictionary.get('Geolocation')) if dictionary.get('Geolocation') else None
        network_type = dictionary.get("NetworkType") if dictionary.get("NetworkType") else None
        # Return an object of this model
        return cls(device_id,
                   geolocation,
                   network_type)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'device_id={self.device_id!r}, '
                f'geolocation={self.geolocation!r}, '
                f'network_type={self.network_type!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'device_id={self.device_id!s}, '
                f'geolocation={self.geolocation!s}, '
                f'network_type={self.network_type!s})')
