# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper


class MecPlatformsAdditionalSupportInfoData(object):

    """Implementation of the 'MECPlatformsAdditionalSupportInfoData' model.

    Data about additional service support information for the MEC platform.

    Attributes:
        additional_info (str): The model property of type str.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "additional_info": 'additionalInfo'
    }

    _optionals = [
        'additional_info',
    ]

    def __init__(self,
                 additional_info=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the MecPlatformsAdditionalSupportInfoData class"""

        # Initialize members of the class
        if additional_info is not APIHelper.SKIP:
            self.additional_info = additional_info 

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
        additional_info = dictionary.get("additionalInfo") if dictionary.get("additionalInfo") else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(additional_info,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'additional_info={(self.additional_info if hasattr(self, "additional_info") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'additional_info={(self.additional_info if hasattr(self, "additional_info") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
