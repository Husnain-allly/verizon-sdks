# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.position_data import PositionData
from verizon.models.position_error import PositionError


class Location(object):

    """Implementation of the 'Location' model.

    Device location information.

    Attributes:
        msid (str): MDN.
        pd (PositionData): Position data.
        error (PositionError): Position error.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "msid": 'msid',
        "pd": 'pd',
        "error": 'error'
    }

    _optionals = [
        'msid',
        'pd',
        'error',
    ]

    def __init__(self,
                 msid=APIHelper.SKIP,
                 pd=APIHelper.SKIP,
                 error=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the Location class"""

        # Initialize members of the class
        if msid is not APIHelper.SKIP:
            self.msid = msid 
        if pd is not APIHelper.SKIP:
            self.pd = pd 
        if error is not APIHelper.SKIP:
            self.error = error 

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
        msid = dictionary.get("msid") if dictionary.get("msid") else APIHelper.SKIP
        pd = PositionData.from_dictionary(dictionary.get('pd')) if 'pd' in dictionary.keys() else APIHelper.SKIP
        error = PositionError.from_dictionary(dictionary.get('error')) if 'error' in dictionary.keys() else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(msid,
                   pd,
                   error,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'msid={(self.msid if hasattr(self, "msid") else None)!r}, '
                f'pd={(self.pd if hasattr(self, "pd") else None)!r}, '
                f'error={(self.error if hasattr(self, "error") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'msid={(self.msid if hasattr(self, "msid") else None)!s}, '
                f'pd={(self.pd if hasattr(self, "pd") else None)!s}, '
                f'error={(self.error if hasattr(self, "error") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
