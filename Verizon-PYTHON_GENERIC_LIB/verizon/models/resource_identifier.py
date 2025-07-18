# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper


class ResourceIdentifier(object):

    """Implementation of the 'ResourceIdentifier' model.

    The ID of the target to delete, in the format {"id":
    "dd1682d3-2d80-cefc-f3ee-25154800beff"}.

    Attributes:
        id (str): Target ID.
        imei (str): Device IMEI.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "id": 'id',
        "imei": 'imei'
    }

    _optionals = [
        'id',
        'imei',
    ]

    def __init__(self,
                 id=APIHelper.SKIP,
                 imei=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the ResourceIdentifier class"""

        # Initialize members of the class
        if id is not APIHelper.SKIP:
            self.id = id 
        if imei is not APIHelper.SKIP:
            self.imei = imei 

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
        id = dictionary.get("id") if dictionary.get("id") else APIHelper.SKIP
        imei = dictionary.get("imei") if dictionary.get("imei") else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(id,
                   imei,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'id={(self.id if hasattr(self, "id") else None)!r}, '
                f'imei={(self.imei if hasattr(self, "imei") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'id={(self.id if hasattr(self, "id") else None)!s}, '
                f'imei={(self.imei if hasattr(self, "imei") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
