# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.m_5g_bidevice_id_1 import M5GBideviceId1


class M5GBideviceId(object):

    """Implementation of the '5gbideviceId' model.

    Attributes:
        device_id (M5GBideviceId1): The model property of type M5GBideviceId1.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "device_id": 'deviceId'
    }

    _optionals = [
        'device_id',
    ]

    def __init__(self,
                 device_id=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the M5GBideviceId class"""

        # Initialize members of the class
        if device_id is not APIHelper.SKIP:
            self.device_id = device_id 

        # Add additional model properties to the instance
        if additional_properties is None:
            additional_properties = {}
        self.additional_properties = additional_properties

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
        device_id = M5GBideviceId1.from_dictionary(dictionary.get('deviceId')) if 'deviceId' in dictionary.keys() else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(device_id,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'device_id={(self.device_id if hasattr(self, "device_id") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'device_id={(self.device_id if hasattr(self, "device_id") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
