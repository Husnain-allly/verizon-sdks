# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.gio_device_id import GioDeviceId


class GetDeviceListWithProfilesRequest(object):

    """Implementation of the 'GetDeviceListWithProfilesRequest' model.

    Attributes:
        account_name (str): The model property of type str.
        provisioning_status_filter (str): The model property of type str.
        profile_status_filter (str): The model property of type str.
        carrier_name_filter (str): The model property of type str.
        device_filter (List[GioDeviceId]): The model property of type
            List[GioDeviceId].

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "account_name": 'accountName',
        "provisioning_status_filter": 'provisioningStatusFilter',
        "profile_status_filter": 'profileStatusFilter',
        "carrier_name_filter": 'carrierNameFilter',
        "device_filter": 'deviceFilter'
    }

    _optionals = [
        'provisioning_status_filter',
        'profile_status_filter',
        'carrier_name_filter',
        'device_filter',
    ]

    def __init__(self,
                 account_name=None,
                 provisioning_status_filter=APIHelper.SKIP,
                 profile_status_filter=APIHelper.SKIP,
                 carrier_name_filter=APIHelper.SKIP,
                 device_filter=APIHelper.SKIP):
        """Constructor for the GetDeviceListWithProfilesRequest class"""

        # Initialize members of the class
        self.account_name = account_name 
        if provisioning_status_filter is not APIHelper.SKIP:
            self.provisioning_status_filter = provisioning_status_filter 
        if profile_status_filter is not APIHelper.SKIP:
            self.profile_status_filter = profile_status_filter 
        if carrier_name_filter is not APIHelper.SKIP:
            self.carrier_name_filter = carrier_name_filter 
        if device_filter is not APIHelper.SKIP:
            self.device_filter = device_filter 

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
        account_name = dictionary.get("accountName") if dictionary.get("accountName") else None
        provisioning_status_filter = dictionary.get("provisioningStatusFilter") if dictionary.get("provisioningStatusFilter") else APIHelper.SKIP
        profile_status_filter = dictionary.get("profileStatusFilter") if dictionary.get("profileStatusFilter") else APIHelper.SKIP
        carrier_name_filter = dictionary.get("carrierNameFilter") if dictionary.get("carrierNameFilter") else APIHelper.SKIP
        device_filter = None
        if dictionary.get('deviceFilter') is not None:
            device_filter = [GioDeviceId.from_dictionary(x) for x in dictionary.get('deviceFilter')]
        else:
            device_filter = APIHelper.SKIP
        # Return an object of this model
        return cls(account_name,
                   provisioning_status_filter,
                   profile_status_filter,
                   carrier_name_filter,
                   device_filter)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'account_name={self.account_name!r}, '
                f'provisioning_status_filter={(self.provisioning_status_filter if hasattr(self, "provisioning_status_filter") else None)!r}, '
                f'profile_status_filter={(self.profile_status_filter if hasattr(self, "profile_status_filter") else None)!r}, '
                f'carrier_name_filter={(self.carrier_name_filter if hasattr(self, "carrier_name_filter") else None)!r}, '
                f'device_filter={(self.device_filter if hasattr(self, "device_filter") else None)!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'account_name={self.account_name!s}, '
                f'provisioning_status_filter={(self.provisioning_status_filter if hasattr(self, "provisioning_status_filter") else None)!s}, '
                f'profile_status_filter={(self.profile_status_filter if hasattr(self, "profile_status_filter") else None)!s}, '
                f'carrier_name_filter={(self.carrier_name_filter if hasattr(self, "carrier_name_filter") else None)!s}, '
                f'device_filter={(self.device_filter if hasattr(self, "device_filter") else None)!s})')
