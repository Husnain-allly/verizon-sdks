# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.device import Device


class DeviceResetRequest(object):

    """Implementation of the 'DeviceResetRequest' model.

    Request body to Performs a device reboot.

    Attributes:
        account_name (str): The name of the account. An account name is
            usually numeric, and must include any leading zeros.
        action (str): The action you want to take on the device.
        devices (List[Device]): The devices for which you want to perform a
            factory reset or reboot.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "account_name": 'accountName',
        "action": 'action',
        "devices": 'devices'
    }

    _optionals = [
        'account_name',
        'action',
        'devices',
    ]

    def __init__(self,
                 account_name=APIHelper.SKIP,
                 action=APIHelper.SKIP,
                 devices=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the DeviceResetRequest class"""

        # Initialize members of the class
        if account_name is not APIHelper.SKIP:
            self.account_name = account_name 
        if action is not APIHelper.SKIP:
            self.action = action 
        if devices is not APIHelper.SKIP:
            self.devices = devices 

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
        action = dictionary.get("action") if dictionary.get("action") else APIHelper.SKIP
        devices = None
        if dictionary.get('devices') is not None:
            devices = [Device.from_dictionary(x) for x in dictionary.get('devices')]
        else:
            devices = APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(account_name,
                   action,
                   devices,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'account_name={(self.account_name if hasattr(self, "account_name") else None)!r}, '
                f'action={(self.action if hasattr(self, "action") else None)!r}, '
                f'devices={(self.devices if hasattr(self, "devices") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'account_name={(self.account_name if hasattr(self, "account_name") else None)!s}, '
                f'action={(self.action if hasattr(self, "action") else None)!s}, '
                f'devices={(self.devices if hasattr(self, "devices") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
