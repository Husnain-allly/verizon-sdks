# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.gatewayidentifier import Gatewayidentifier
from verizon.models.onboarding import Onboarding


class DtoSensorOnBoardStatusRequest(object):

    """Implementation of the 'dto.SensorOnBoardStatusRequest' model.

    Attributes:
        accountname (str): The numeric account name, which must include
            leading zeros
        gatewayidentifier (Gatewayidentifier): The model property of type
            Gatewayidentifier.
        onboarding (Onboarding): The model property of type Onboarding.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "accountname": 'accountname',
        "gatewayidentifier": 'gatewayidentifier',
        "onboarding": 'onboarding'
    }

    _optionals = [
        'accountname',
        'gatewayidentifier',
        'onboarding',
    ]

    def __init__(self,
                 accountname=APIHelper.SKIP,
                 gatewayidentifier=APIHelper.SKIP,
                 onboarding=APIHelper.SKIP):
        """Constructor for the DtoSensorOnBoardStatusRequest class"""

        # Initialize members of the class
        if accountname is not APIHelper.SKIP:
            self.accountname = accountname 
        if gatewayidentifier is not APIHelper.SKIP:
            self.gatewayidentifier = gatewayidentifier 
        if onboarding is not APIHelper.SKIP:
            self.onboarding = onboarding 

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
        gatewayidentifier = Gatewayidentifier.from_dictionary(dictionary.get('gatewayidentifier')) if 'gatewayidentifier' in dictionary.keys() else APIHelper.SKIP
        onboarding = Onboarding.from_dictionary(dictionary.get('onboarding')) if 'onboarding' in dictionary.keys() else APIHelper.SKIP
        # Return an object of this model
        return cls(accountname,
                   gatewayidentifier,
                   onboarding)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'accountname={(self.accountname if hasattr(self, "accountname") else None)!r}, '
                f'gatewayidentifier={(self.gatewayidentifier if hasattr(self, "gatewayidentifier") else None)!r}, '
                f'onboarding={(self.onboarding if hasattr(self, "onboarding") else None)!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'accountname={(self.accountname if hasattr(self, "accountname") else None)!s}, '
                f'gatewayidentifier={(self.gatewayidentifier if hasattr(self, "gatewayidentifier") else None)!s}, '
                f'onboarding={(self.onboarding if hasattr(self, "onboarding") else None)!s})')
