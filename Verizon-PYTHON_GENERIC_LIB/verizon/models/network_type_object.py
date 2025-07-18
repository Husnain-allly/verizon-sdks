# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper


class NetworkTypeObject(object):

    """Implementation of the 'NetworkTypeObject' model.

    Network type.

    Attributes:
        network_type (str): The model property of type str.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "network_type": 'networkType'
    }

    _optionals = [
        'network_type',
    ]

    def __init__(self,
                 network_type=APIHelper.SKIP):
        """Constructor for the NetworkTypeObject class"""

        # Initialize members of the class
        if network_type is not APIHelper.SKIP:
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
        network_type = dictionary.get("networkType") if dictionary.get("networkType") else APIHelper.SKIP
        # Return an object of this model
        return cls(network_type)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'network_type={(self.network_type if hasattr(self, "network_type") else None)!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'network_type={(self.network_type if hasattr(self, "network_type") else None)!s})')
