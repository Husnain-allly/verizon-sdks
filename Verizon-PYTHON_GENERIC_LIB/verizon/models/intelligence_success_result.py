# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper


class IntelligenceSuccessResult(object):

    """Implementation of the 'IntelligenceSuccessResult' model.

    Success response.

    Attributes:
        status (str): Anomaly detection status.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "status": 'status'
    }

    _optionals = [
        'status',
    ]

    def __init__(self,
                 status=APIHelper.SKIP):
        """Constructor for the IntelligenceSuccessResult class"""

        # Initialize members of the class
        if status is not APIHelper.SKIP:
            self.status = status 

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
        status = dictionary.get("status") if dictionary.get("status") else APIHelper.SKIP
        # Return an object of this model
        return cls(status)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'status={(self.status if hasattr(self, "status") else None)!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'status={(self.status if hasattr(self, "status") else None)!s})')
