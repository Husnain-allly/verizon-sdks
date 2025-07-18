# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.dto_profile import DtoProfile


class DtoConfigurationProfile(object):

    """Implementation of the 'dto.configurationProfile' model.

    Attributes:
        accountname (str): The numeric account name, which must include
            leading zeros
        profiles (List[DtoProfile]): The model property of type
            List[DtoProfile].
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "accountname": 'accountname',
        "profiles": 'profiles'
    }

    _optionals = [
        'accountname',
        'profiles',
    ]

    def __init__(self,
                 accountname=APIHelper.SKIP,
                 profiles=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the DtoConfigurationProfile class"""

        # Initialize members of the class
        if accountname is not APIHelper.SKIP:
            self.accountname = accountname 
        if profiles is not APIHelper.SKIP:
            self.profiles = profiles 

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
        accountname = dictionary.get("accountname") if dictionary.get("accountname") else APIHelper.SKIP
        profiles = None
        if dictionary.get('profiles') is not None:
            profiles = [DtoProfile.from_dictionary(x) for x in dictionary.get('profiles')]
        else:
            profiles = APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(accountname,
                   profiles,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'accountname={(self.accountname if hasattr(self, "accountname") else None)!r}, '
                f'profiles={(self.profiles if hasattr(self, "profiles") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'accountname={(self.accountname if hasattr(self, "accountname") else None)!s}, '
                f'profiles={(self.profiles if hasattr(self, "profiles") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
