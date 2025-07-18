# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.v2_device_status import V2DeviceStatus


class V2CampaignDevice(object):

    """Implementation of the 'V2CampaignDevice' model.

    List of devices in a campaign.

    Attributes:
        total_device (int): Total device count.
        has_more_data (bool): Has more report flag.
        last_seen_device_id (str): Device identifier.
        max_page_size (int): Maximum page size.
        device_list (List[V2DeviceStatus]): List of devices with id in IMEI.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "has_more_data": 'hasMoreData',
        "max_page_size": 'maxPageSize',
        "device_list": 'deviceList',
        "total_device": 'totalDevice',
        "last_seen_device_id": 'lastSeenDeviceId'
    }

    _optionals = [
        'total_device',
        'last_seen_device_id',
    ]

    def __init__(self,
                 has_more_data=None,
                 max_page_size=None,
                 device_list=None,
                 total_device=APIHelper.SKIP,
                 last_seen_device_id=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the V2CampaignDevice class"""

        # Initialize members of the class
        if total_device is not APIHelper.SKIP:
            self.total_device = total_device 
        self.has_more_data = has_more_data 
        if last_seen_device_id is not APIHelper.SKIP:
            self.last_seen_device_id = last_seen_device_id 
        self.max_page_size = max_page_size 
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
        has_more_data = dictionary.get("hasMoreData") if "hasMoreData" in dictionary.keys() else None
        max_page_size = dictionary.get("maxPageSize") if dictionary.get("maxPageSize") else None
        device_list = None
        if dictionary.get('deviceList') is not None:
            device_list = [V2DeviceStatus.from_dictionary(x) for x in dictionary.get('deviceList')]
        total_device = dictionary.get("totalDevice") if dictionary.get("totalDevice") else APIHelper.SKIP
        last_seen_device_id = dictionary.get("lastSeenDeviceId") if dictionary.get("lastSeenDeviceId") else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(has_more_data,
                   max_page_size,
                   device_list,
                   total_device,
                   last_seen_device_id,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'total_device={(self.total_device if hasattr(self, "total_device") else None)!r}, '
                f'has_more_data={self.has_more_data!r}, '
                f'last_seen_device_id={(self.last_seen_device_id if hasattr(self, "last_seen_device_id") else None)!r}, '
                f'max_page_size={self.max_page_size!r}, '
                f'device_list={self.device_list!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'total_device={(self.total_device if hasattr(self, "total_device") else None)!s}, '
                f'has_more_data={self.has_more_data!s}, '
                f'last_seen_device_id={(self.last_seen_device_id if hasattr(self, "last_seen_device_id") else None)!s}, '
                f'max_page_size={self.max_page_size!s}, '
                f'device_list={self.device_list!s}, '
                f'additional_properties={self.additional_properties!s})')
