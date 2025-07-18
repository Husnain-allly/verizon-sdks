# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.device_id import DeviceId


class DeviceProvisioningHistoryListRequest(object):

    """Implementation of the 'DeviceProvisioningHistoryListRequest' model.

    Request to return the provisioning history of a specified device during a
    specified time period.

    Attributes:
        device_id (DeviceId): An identifier for a single device.
        earliest (str): The earliest date and time for which you want
            provisioning data.
        latest (str): The last date and time for which you want provisioning
            data.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "device_id": 'deviceId',
        "earliest": 'earliest',
        "latest": 'latest'
    }

    def __init__(self,
                 device_id=None,
                 earliest=None,
                 latest=None,
                 additional_properties=None):
        """Constructor for the DeviceProvisioningHistoryListRequest class"""

        # Initialize members of the class
        self.device_id = device_id 
        self.earliest = earliest 
        self.latest = latest 

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
        device_id = DeviceId.from_dictionary(dictionary.get('deviceId')) if dictionary.get('deviceId') else None
        earliest = dictionary.get("earliest") if dictionary.get("earliest") else None
        latest = dictionary.get("latest") if dictionary.get("latest") else None
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(device_id,
                   earliest,
                   latest,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'device_id={self.device_id!r}, '
                f'earliest={self.earliest!r}, '
                f'latest={self.latest!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'device_id={self.device_id!s}, '
                f'earliest={self.earliest!s}, '
                f'latest={self.latest!s}, '
                f'additional_properties={self.additional_properties!s})')
