# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.device import Device
from verizon.models.history_attribute_value import HistoryAttributeValue


class History(object):

    """Implementation of the 'History' model.

    History data for a selected device and its attributes at a specific time.

    Attributes:
        account_name (str): The name of the billing account for which you want
            retrieve history data. An account name is usually numeric, and
            must include any leading zeros.
        device (Device): Identifies a particular IoT device.
        attributes (HistoryAttributeValue): Streaming RF parameter for which
            you want to retrieve history data.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "account_name": 'accountName',
        "device": 'device',
        "attributes": 'attributes'
    }

    _optionals = [
        'attributes',
    ]

    def __init__(self,
                 account_name=None,
                 device=None,
                 attributes=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the History class"""

        # Initialize members of the class
        self.account_name = account_name 
        self.device = device 
        if attributes is not APIHelper.SKIP:
            self.attributes = attributes 

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
        device = Device.from_dictionary(dictionary.get('device')) if dictionary.get('device') else None
        attributes = HistoryAttributeValue.from_dictionary(dictionary.get('attributes')) if 'attributes' in dictionary.keys() else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(account_name,
                   device,
                   attributes,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'account_name={self.account_name!r}, '
                f'device={self.device!r}, '
                f'attributes={(self.attributes if hasattr(self, "attributes") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'account_name={self.account_name!s}, '
                f'device={self.device!s}, '
                f'attributes={(self.attributes if hasattr(self, "attributes") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
