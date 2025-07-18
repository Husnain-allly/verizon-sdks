# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.dto_profile import DtoProfile
from verizon.models.dto_resourceidentifier import DtoResourceidentifier


class DtoConfigurationProfilePath(object):

    """Implementation of the 'dto.configurationProfilePath' model.

    Attributes:
        account_name (str): The numeric account name, which must include
            leading zeros
        resourceidentifier (DtoResourceidentifier): The model property of type
            DtoResourceidentifier.
        profile (DtoProfile): The model property of type DtoProfile.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "account_name": 'accountName',
        "resourceidentifier": 'resourceidentifier',
        "profile": 'profile'
    }

    _optionals = [
        'account_name',
        'resourceidentifier',
        'profile',
    ]

    def __init__(self,
                 account_name=APIHelper.SKIP,
                 resourceidentifier=APIHelper.SKIP,
                 profile=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the DtoConfigurationProfilePath class"""

        # Initialize members of the class
        if account_name is not APIHelper.SKIP:
            self.account_name = account_name 
        if resourceidentifier is not APIHelper.SKIP:
            self.resourceidentifier = resourceidentifier 
        if profile is not APIHelper.SKIP:
            self.profile = profile 

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
        account_name = dictionary.get("accountName") if dictionary.get("accountName") else APIHelper.SKIP
        resourceidentifier = DtoResourceidentifier.from_dictionary(dictionary.get('resourceidentifier')) if 'resourceidentifier' in dictionary.keys() else APIHelper.SKIP
        profile = DtoProfile.from_dictionary(dictionary.get('profile')) if 'profile' in dictionary.keys() else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(account_name,
                   resourceidentifier,
                   profile,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'account_name={(self.account_name if hasattr(self, "account_name") else None)!r}, '
                f'resourceidentifier={(self.resourceidentifier if hasattr(self, "resourceidentifier") else None)!r}, '
                f'profile={(self.profile if hasattr(self, "profile") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'account_name={(self.account_name if hasattr(self, "account_name") else None)!s}, '
                f'resourceidentifier={(self.resourceidentifier if hasattr(self, "resourceidentifier") else None)!s}, '
                f'profile={(self.profile if hasattr(self, "profile") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
