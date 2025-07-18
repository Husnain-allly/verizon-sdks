# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper


class PropertyDeviceId(object):

    """Implementation of the 'PropertyDeviceId' model.

    Attributes:
        id (str): The model property of type str.
        kind (str): The type of the device identifier. Valid types of
            identifiers are:ESN (decimal),EID,ICCID (up to 20 digits),IMEI (up
            to 16 digits),MDN,MEID (hexadecimal),MSISDN.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "id": 'id',
        "kind": 'kind'
    }

    _optionals = [
        'id',
        'kind',
    ]

    def __init__(self,
                 id=APIHelper.SKIP,
                 kind=APIHelper.SKIP):
        """Constructor for the PropertyDeviceId class"""

        # Initialize members of the class
        if id is not APIHelper.SKIP:
            self.id = id 
        if kind is not APIHelper.SKIP:
            self.kind = kind 

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
        id = dictionary.get("id") if dictionary.get("id") else APIHelper.SKIP
        kind = dictionary.get("kind") if dictionary.get("kind") else APIHelper.SKIP
        # Return an object of this model
        return cls(id,
                   kind)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'id={(self.id if hasattr(self, "id") else None)!r}, '
                f'kind={(self.kind if hasattr(self, "kind") else None)!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'id={(self.id if hasattr(self, "id") else None)!s}, '
                f'kind={(self.kind if hasattr(self, "kind") else None)!s})')
