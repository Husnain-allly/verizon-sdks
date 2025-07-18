# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.license_device_list import LicenseDeviceList


class AssignLicenseRequest(object):

    """Implementation of the 'AssignLicenseRequest' model.

    Request to assign license.

    Attributes:
        account_name (str): The name of a billing account.This parameter is
            required only if the UWS account used for the current API session
            has access to multiple accounts. An account name is usually
            numeric, and must include any leading zeros.
        devices (List[LicenseDeviceList]): A list of 4G devices.
        sku_number (str): The Stock Keeping Unit (SKU). Valid skuNumbers for
            license types: “SIMSec-IoT-Lt”. (Lifetime) Once a license is
            assigned to a SIM, the SIM-Secure feature is enabled for the life
            of the SIM.“TS-BUNDLE-KTO-SIMSEC-MRC”. (Bundle) The SIM-Secure
            Flex license can be assigned to or removed from a SIM at any time.
            This SKU is bundled with other ThingSpace Services.“SIMSec-IoT”.
            (Flex) The SIM-Secure Flex license can be assigned to or removed
            from a SIM at any time. This SKU is purchased a la carte.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "account_name": 'accountName',
        "devices": 'devices',
        "sku_number": 'skuNumber'
    }

    _optionals = [
        'account_name',
        'devices',
        'sku_number',
    ]

    def __init__(self,
                 account_name=APIHelper.SKIP,
                 devices=APIHelper.SKIP,
                 sku_number=APIHelper.SKIP):
        """Constructor for the AssignLicenseRequest class"""

        # Initialize members of the class
        if account_name is not APIHelper.SKIP:
            self.account_name = account_name 
        if devices is not APIHelper.SKIP:
            self.devices = devices 
        if sku_number is not APIHelper.SKIP:
            self.sku_number = sku_number 

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
        devices = None
        if dictionary.get('devices') is not None:
            devices = [LicenseDeviceList.from_dictionary(x) for x in dictionary.get('devices')]
        else:
            devices = APIHelper.SKIP
        sku_number = dictionary.get("skuNumber") if dictionary.get("skuNumber") else APIHelper.SKIP
        # Return an object of this model
        return cls(account_name,
                   devices,
                   sku_number)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'account_name={(self.account_name if hasattr(self, "account_name") else None)!r}, '
                f'devices={(self.devices if hasattr(self, "devices") else None)!r}, '
                f'sku_number={(self.sku_number if hasattr(self, "sku_number") else None)!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'account_name={(self.account_name if hasattr(self, "account_name") else None)!s}, '
                f'devices={(self.devices if hasattr(self, "devices") else None)!s}, '
                f'sku_number={(self.sku_number if hasattr(self, "sku_number") else None)!s})')
