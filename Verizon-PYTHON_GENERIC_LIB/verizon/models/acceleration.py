# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper


class Acceleration(object):

    """Implementation of the 'acceleration' model.

    Attributes:
        x (str): The model property of type str.
        y (str): The model property of type str.
        z (str): The model property of type str.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "x": 'x',
        "y": 'y',
        "z": 'z'
    }

    _optionals = [
        'x',
        'y',
        'z',
    ]

    def __init__(self,
                 x=APIHelper.SKIP,
                 y=APIHelper.SKIP,
                 z=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the Acceleration class"""

        # Initialize members of the class
        if x is not APIHelper.SKIP:
            self.x = x 
        if y is not APIHelper.SKIP:
            self.y = y 
        if z is not APIHelper.SKIP:
            self.z = z 

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
        x = dictionary.get("x") if dictionary.get("x") else APIHelper.SKIP
        y = dictionary.get("y") if dictionary.get("y") else APIHelper.SKIP
        z = dictionary.get("z") if dictionary.get("z") else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(x,
                   y,
                   z,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'x={(self.x if hasattr(self, "x") else None)!r}, '
                f'y={(self.y if hasattr(self, "y") else None)!r}, '
                f'z={(self.z if hasattr(self, "z") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'x={(self.x if hasattr(self, "x") else None)!s}, '
                f'y={(self.y if hasattr(self, "y") else None)!s}, '
                f'z={(self.z if hasattr(self, "z") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
