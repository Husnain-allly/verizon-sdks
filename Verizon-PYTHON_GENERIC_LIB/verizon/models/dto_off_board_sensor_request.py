# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.sensorinsightsconfig import Sensorinsightsconfig


class DtoOffBoardSensorRequest(object):

    """Implementation of the 'dto.OffBoardSensorRequest' model.

    Attributes:
        accountname (str): The numeric account name, which must include
            leading zeros
        configuration (Sensorinsightsconfig): The configuration of the remove
            request

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "accountname": 'accountname',
        "configuration": 'configuration'
    }

    _optionals = [
        'accountname',
        'configuration',
    ]

    def __init__(self,
                 accountname=APIHelper.SKIP,
                 configuration=APIHelper.SKIP):
        """Constructor for the DtoOffBoardSensorRequest class"""

        # Initialize members of the class
        if accountname is not APIHelper.SKIP:
            self.accountname = accountname 
        if configuration is not APIHelper.SKIP:
            self.configuration = configuration 

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
        accountname = dictionary.get("accountname") if dictionary.get("accountname") else APIHelper.SKIP
        configuration = Sensorinsightsconfig.from_dictionary(dictionary.get('configuration')) if 'configuration' in dictionary.keys() else APIHelper.SKIP
        # Return an object of this model
        return cls(accountname,
                   configuration)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'accountname={(self.accountname if hasattr(self, "accountname") else None)!r}, '
                f'configuration={(self.configuration if hasattr(self, "configuration") else None)!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'accountname={(self.accountname if hasattr(self, "accountname") else None)!s}, '
                f'configuration={(self.configuration if hasattr(self, "configuration") else None)!s})')
