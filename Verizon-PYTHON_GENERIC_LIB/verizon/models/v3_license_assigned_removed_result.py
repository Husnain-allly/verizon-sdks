# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.v3_device_status import V3DeviceStatus


class V3LicenseAssignedRemovedResult(object):

    """Implementation of the 'V3LicenseAssignedRemovedResult' model.

    License assignment/removal response.

    Attributes:
        account_name (str): Account name.
        lic_count (int): Total license count.
        lic_used_count (int): Assigned license count.
        device_list (List[V3DeviceStatus]): List of devices with id in IMEI.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "account_name": 'accountName',
        "lic_count": 'licCount',
        "lic_used_count": 'licUsedCount',
        "device_list": 'deviceList'
    }

    def __init__(self,
                 account_name=None,
                 lic_count=None,
                 lic_used_count=None,
                 device_list=None,
                 additional_properties=None):
        """Constructor for the V3LicenseAssignedRemovedResult class"""

        # Initialize members of the class
        self.account_name = account_name 
        self.lic_count = lic_count 
        self.lic_used_count = lic_used_count 
        self.device_list = device_list 

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
        account_name = dictionary.get("accountName") if dictionary.get("accountName") else None
        lic_count = dictionary.get("licCount") if dictionary.get("licCount") else None
        lic_used_count = dictionary.get("licUsedCount") if dictionary.get("licUsedCount") else None
        device_list = None
        if dictionary.get('deviceList') is not None:
            device_list = [V3DeviceStatus.from_dictionary(x) for x in dictionary.get('deviceList')]
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(account_name,
                   lic_count,
                   lic_used_count,
                   device_list,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'account_name={self.account_name!r}, '
                f'lic_count={self.lic_count!r}, '
                f'lic_used_count={self.lic_used_count!r}, '
                f'device_list={self.device_list!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'account_name={self.account_name!s}, '
                f'lic_count={self.lic_count!s}, '
                f'lic_used_count={self.lic_used_count!s}, '
                f'device_list={self.device_list!s}, '
                f'additional_properties={self.additional_properties!s})')
