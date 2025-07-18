# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.etx_geofence import EtxGeofence


class GeoFenceConfigurationUpdateRequest(object):

    """Implementation of the 'GeoFenceConfigurationUpdateRequest' model.

    Request for /api/v1/application/configurations/geofence PUT endpoint. It
    requires at least one of vendorId, name, description, geofence, messages
    and isActive fields to be populated.

    Attributes:
        name (str): Name of the configuration.
        description (str): Description of the configuration.
        geo_fence (EtxGeofence): The GeoJSON representation of geofence.
            Geofence supports the following geometry types: LineString,
            Polygon, MultiLineString, and MultiPolygon. The system only
            supports a single Feature in the FeatureCollection, so only one
            Line, Polygon, MultiLine or MultiPolygon can be defined within one
            Geofencing configuration.
        messages (List[Any]): List of predefined messages that belongs to the
            geofence. These are the messages that are sent out by the system
            when the Trigger Condition for the message is met.
        is_active (bool): The model property of type bool.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "name": 'name',
        "description": 'description',
        "geo_fence": 'geoFence',
        "messages": 'messages',
        "is_active": 'isActive'
    }

    _optionals = [
        'name',
        'description',
        'geo_fence',
        'messages',
        'is_active',
    ]

    def __init__(self,
                 name=APIHelper.SKIP,
                 description=APIHelper.SKIP,
                 geo_fence=APIHelper.SKIP,
                 messages=APIHelper.SKIP,
                 is_active=APIHelper.SKIP):
        """Constructor for the GeoFenceConfigurationUpdateRequest class"""

        # Initialize members of the class
        if name is not APIHelper.SKIP:
            self.name = name 
        if description is not APIHelper.SKIP:
            self.description = description 
        if geo_fence is not APIHelper.SKIP:
            self.geo_fence = geo_fence 
        if messages is not APIHelper.SKIP:
            self.messages = messages 
        if is_active is not APIHelper.SKIP:
            self.is_active = is_active 

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
        name = dictionary.get("name") if dictionary.get("name") else APIHelper.SKIP
        description = dictionary.get("description") if dictionary.get("description") else APIHelper.SKIP
        geo_fence = EtxGeofence.from_dictionary(dictionary.get('geoFence')) if 'geoFence' in dictionary.keys() else APIHelper.SKIP
        messages = dictionary.get("messages") if dictionary.get("messages") else APIHelper.SKIP
        is_active = dictionary.get("isActive") if "isActive" in dictionary.keys() else APIHelper.SKIP
        # Return an object of this model
        return cls(name,
                   description,
                   geo_fence,
                   messages,
                   is_active)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'name={(self.name if hasattr(self, "name") else None)!r}, '
                f'description={(self.description if hasattr(self, "description") else None)!r}, '
                f'geo_fence={(self.geo_fence if hasattr(self, "geo_fence") else None)!r}, '
                f'messages={(self.messages if hasattr(self, "messages") else None)!r}, '
                f'is_active={(self.is_active if hasattr(self, "is_active") else None)!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'name={(self.name if hasattr(self, "name") else None)!s}, '
                f'description={(self.description if hasattr(self, "description") else None)!s}, '
                f'geo_fence={(self.geo_fence if hasattr(self, "geo_fence") else None)!s}, '
                f'messages={(self.messages if hasattr(self, "messages") else None)!s}, '
                f'is_active={(self.is_active if hasattr(self, "is_active") else None)!s})')
