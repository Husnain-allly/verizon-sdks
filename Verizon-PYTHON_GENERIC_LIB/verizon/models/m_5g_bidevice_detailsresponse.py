# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.m_5g_biaccount_nameobject import M5GBiaccountNameobject


class M5GBideviceDetailsresponse(object):

    """Implementation of the '5gbideviceDetailsresponse' model.

    Attributes:
        has_more_data (bool): The model property of type bool.
        devices (List[M5GBiaccountNameobject]): The model property of type
            List[M5GBiaccountNameobject].
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "has_more_data": 'hasMoreData',
        "devices": 'devices'
    }

    _optionals = [
        'has_more_data',
        'devices',
    ]

    def __init__(self,
                 has_more_data=APIHelper.SKIP,
                 devices=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the M5GBideviceDetailsresponse class"""

        # Initialize members of the class
        if has_more_data is not APIHelper.SKIP:
            self.has_more_data = has_more_data 
        if devices is not APIHelper.SKIP:
            self.devices = devices 

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
        has_more_data = dictionary.get("hasMoreData") if "hasMoreData" in dictionary.keys() else APIHelper.SKIP
        devices = None
        if dictionary.get('devices') is not None:
            devices = [M5GBiaccountNameobject.from_dictionary(x) for x in dictionary.get('devices')]
        else:
            devices = APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(has_more_data,
                   devices,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'has_more_data={(self.has_more_data if hasattr(self, "has_more_data") else None)!r}, '
                f'devices={(self.devices if hasattr(self, "devices") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'has_more_data={(self.has_more_data if hasattr(self, "has_more_data") else None)!s}, '
                f'devices={(self.devices if hasattr(self, "devices") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
