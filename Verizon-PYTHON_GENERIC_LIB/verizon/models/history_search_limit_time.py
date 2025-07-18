# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.numerical_data import NumericalData


class HistorySearchLimitTime(object):

    """Implementation of the 'HistorySearchLimitTime' model.

    The time period for which a request should retrieve data, beginning with
    the limitTime.startOn and proceeding with the limitTime.duration.

    Attributes:
        start_on (datetime): The starting date-time for this request.
        duration (NumericalData): Describes value and unit of time.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "start_on": 'startOn',
        "duration": 'duration'
    }

    _optionals = [
        'start_on',
        'duration',
    ]

    def __init__(self,
                 start_on=APIHelper.SKIP,
                 duration=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the HistorySearchLimitTime class"""

        # Initialize members of the class
        if start_on is not APIHelper.SKIP:
            self.start_on = APIHelper.apply_datetime_converter(start_on, APIHelper.RFC3339DateTime) if start_on else None 
        if duration is not APIHelper.SKIP:
            self.duration = duration 

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
        start_on = APIHelper.RFC3339DateTime.from_value(dictionary.get("startOn")).datetime if dictionary.get("startOn") else APIHelper.SKIP
        duration = NumericalData.from_dictionary(dictionary.get('duration')) if 'duration' in dictionary.keys() else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(start_on,
                   duration,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'start_on={(self.start_on if hasattr(self, "start_on") else None)!r}, '
                f'duration={(self.duration if hasattr(self, "duration") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'start_on={(self.start_on if hasattr(self, "start_on") else None)!s}, '
                f'duration={(self.duration if hasattr(self, "duration") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
