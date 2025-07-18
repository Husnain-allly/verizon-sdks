# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper


class UpdateServiceProfileResult(object):

    """Implementation of the 'UpdateServiceProfileResult' model.

    Response on successful update of service profile.

    Attributes:
        status (str): HTTP status code.
        message (str): Service Profile that are updated or error details in
            case of an error.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "status": 'status',
        "message": 'message'
    }

    _optionals = [
        'status',
        'message',
    ]

    def __init__(self,
                 status=APIHelper.SKIP,
                 message=APIHelper.SKIP):
        """Constructor for the UpdateServiceProfileResult class"""

        # Initialize members of the class
        if status is not APIHelper.SKIP:
            self.status = status 
        if message is not APIHelper.SKIP:
            self.message = message 

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
        message = dictionary.get("message") if dictionary.get("message") else APIHelper.SKIP
        # Return an object of this model
        return cls(status,
                   message)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'status={(self.status if hasattr(self, "status") else None)!r}, '
                f'message={(self.message if hasattr(self, "message") else None)!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'status={(self.status if hasattr(self, "status") else None)!s}, '
                f'message={(self.message if hasattr(self, "message") else None)!s})')
