# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper


class Cellphonenumber(object):

    """Implementation of the 'cellphonenumber' model.

    Attributes:
        number (str): The model property of type str.
        carrier (str): The model property of type str.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "number": 'number',
        "carrier": 'carrier'
    }

    _optionals = [
        'number',
        'carrier',
    ]

    def __init__(self,
                 number=APIHelper.SKIP,
                 carrier=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the Cellphonenumber class"""

        # Initialize members of the class
        if number is not APIHelper.SKIP:
            self.number = number 
        if carrier is not APIHelper.SKIP:
            self.carrier = carrier 

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
        number = dictionary.get("number") if dictionary.get("number") else APIHelper.SKIP
        carrier = dictionary.get("carrier") if dictionary.get("carrier") else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(number,
                   carrier,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'number={(self.number if hasattr(self, "number") else None)!r}, '
                f'carrier={(self.carrier if hasattr(self, "carrier") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'number={(self.number if hasattr(self, "number") else None)!s}, '
                f'carrier={(self.carrier if hasattr(self, "carrier") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
