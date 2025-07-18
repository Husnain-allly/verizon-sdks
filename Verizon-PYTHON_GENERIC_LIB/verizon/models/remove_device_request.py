# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.account_identifier import AccountIdentifier
from verizon.models.resource_identifier import ResourceIdentifier


class RemoveDeviceRequest(object):

    """Implementation of the 'RemoveDeviceRequest' model.

    The request body identifies the device to delete.

    Attributes:
        accountidentifier (AccountIdentifier): The ID of the authenticating
            billing account, in the format
            `{"billingaccountid":"1234567890-12345"}`.
        resourceidentifier (ResourceIdentifier): The ID of the target to
            delete, in the format {"id":
            "dd1682d3-2d80-cefc-f3ee-25154800beff"}.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "accountidentifier": 'accountidentifier',
        "resourceidentifier": 'resourceidentifier'
    }

    def __init__(self,
                 accountidentifier=None,
                 resourceidentifier=None,
                 additional_properties=None):
        """Constructor for the RemoveDeviceRequest class"""

        # Initialize members of the class
        self.accountidentifier = accountidentifier 
        self.resourceidentifier = resourceidentifier 

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
        accountidentifier = AccountIdentifier.from_dictionary(dictionary.get('accountidentifier')) if dictionary.get('accountidentifier') else None
        resourceidentifier = ResourceIdentifier.from_dictionary(dictionary.get('resourceidentifier')) if dictionary.get('resourceidentifier') else None
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(accountidentifier,
                   resourceidentifier,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'accountidentifier={self.accountidentifier!r}, '
                f'resourceidentifier={self.resourceidentifier!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'accountidentifier={self.accountidentifier!s}, '
                f'resourceidentifier={self.resourceidentifier!s}, '
                f'additional_properties={self.additional_properties!s})')
