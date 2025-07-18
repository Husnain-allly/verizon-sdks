# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.connection_event import ConnectionEvent


class ConnectionHistoryResult(object):

    """Implementation of the 'ConnectionHistoryResult' model.

    Response containing the connection history. It is a list of Network
    Connection Events for a device.

    Attributes:
        connection_history (List[ConnectionEvent]): Device connection events,
            sorted by the occurredAt timestamp, oldest first.
        has_more_data (bool): False for a status 200 response.True for a
            status 202 response, indicating that there is more data to be
            retrieved. Send another request, adjusting the earliest value in
            the request based on the occuredAt value for the last device in
            the current response.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "connection_history": 'connectionHistory',
        "has_more_data": 'hasMoreData'
    }

    _optionals = [
        'connection_history',
        'has_more_data',
    ]

    def __init__(self,
                 connection_history=APIHelper.SKIP,
                 has_more_data=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the ConnectionHistoryResult class"""

        # Initialize members of the class
        if connection_history is not APIHelper.SKIP:
            self.connection_history = connection_history 
        if has_more_data is not APIHelper.SKIP:
            self.has_more_data = has_more_data 

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
        connection_history = None
        if dictionary.get('connectionHistory') is not None:
            connection_history = [ConnectionEvent.from_dictionary(x) for x in dictionary.get('connectionHistory')]
        else:
            connection_history = APIHelper.SKIP
        has_more_data = dictionary.get("hasMoreData") if "hasMoreData" in dictionary.keys() else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(connection_history,
                   has_more_data,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'connection_history={(self.connection_history if hasattr(self, "connection_history") else None)!r}, '
                f'has_more_data={(self.has_more_data if hasattr(self, "has_more_data") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'connection_history={(self.connection_history if hasattr(self, "connection_history") else None)!s}, '
                f'has_more_data={(self.has_more_data if hasattr(self, "has_more_data") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
