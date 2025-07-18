# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.search_device_response import SearchDeviceResponse


class SearchDeviceEventHistoryResponseList(object):

    """Implementation of the 'SearchDeviceEventHistoryResponseList' model.

    A success response includes an array of all matching events.

    Attributes:
        search_device_event_history (List[SearchDeviceResponse]): The model
            property of type List[SearchDeviceResponse].
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "search_device_event_history": 'SearchDeviceEventHistory'
    }

    _optionals = [
        'search_device_event_history',
    ]

    def __init__(self,
                 search_device_event_history=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the SearchDeviceEventHistoryResponseList class"""

        # Initialize members of the class
        if search_device_event_history is not APIHelper.SKIP:
            self.search_device_event_history = search_device_event_history 

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
        search_device_event_history = None
        if dictionary.get('SearchDeviceEventHistory') is not None:
            search_device_event_history = [SearchDeviceResponse.from_dictionary(x) for x in dictionary.get('SearchDeviceEventHistory')]
        else:
            search_device_event_history = APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(search_device_event_history,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'search_device_event_history={(self.search_device_event_history if hasattr(self, "search_device_event_history") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'search_device_event_history={(self.search_device_event_history if hasattr(self, "search_device_event_history") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
