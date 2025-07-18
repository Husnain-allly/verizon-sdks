# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper


class KeyServicePlan(object):

    """Implementation of the 'keyServicePlan' model.

    Attributes:
        key (str): The model property of type str.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "key": 'key'
    }

    _optionals = [
        'key',
    ]

    def __init__(self,
                 key=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the KeyServicePlan class"""

        # Initialize members of the class
        if key is not APIHelper.SKIP:
            self.key = key 

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
        key = dictionary.get("key") if dictionary.get("key") else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(key,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'key={(self.key if hasattr(self, "key") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'key={(self.key if hasattr(self, "key") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
