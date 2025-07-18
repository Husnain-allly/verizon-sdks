# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper


class LogInRequest(object):

    """Implementation of the 'LogInRequest' model.

    Request to initiate a Connectivity Management session and returns a VZ-M2M
    session token that is required in subsequent API requests.

    Attributes:
        username (str): The username for authentication.
        password (str): The password for authentication.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "username": 'username',
        "password": 'password'
    }

    def __init__(self,
                 username=None,
                 password=None,
                 additional_properties=None):
        """Constructor for the LogInRequest class"""

        # Initialize members of the class
        self.username = username 
        self.password = password 

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
        username = dictionary.get("username") if dictionary.get("username") else None
        password = dictionary.get("password") if dictionary.get("password") else None
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(username,
                   password,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'username={self.username!r}, '
                f'password={self.password!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'username={self.username!s}, '
                f'password={self.password!s}, '
                f'additional_properties={self.additional_properties!s})')
