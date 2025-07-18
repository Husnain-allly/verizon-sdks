# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper


class PositionError(object):

    """Implementation of the 'PositionError' model.

    Position error.

    Attributes:
        time (str): Time location obtained.
        utcoffset (str): UTC offset of time.
        mtype (str): Error type returned from location server.
        info (str): Additional information about the error.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "time": 'time',
        "utcoffset": 'utcoffset',
        "mtype": 'type',
        "info": 'info'
    }

    _optionals = [
        'time',
        'utcoffset',
        'mtype',
        'info',
    ]

    def __init__(self,
                 time=APIHelper.SKIP,
                 utcoffset=APIHelper.SKIP,
                 mtype=APIHelper.SKIP,
                 info=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the PositionError class"""

        # Initialize members of the class
        if time is not APIHelper.SKIP:
            self.time = time 
        if utcoffset is not APIHelper.SKIP:
            self.utcoffset = utcoffset 
        if mtype is not APIHelper.SKIP:
            self.mtype = mtype 
        if info is not APIHelper.SKIP:
            self.info = info 

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
        time = dictionary.get("time") if dictionary.get("time") else APIHelper.SKIP
        utcoffset = dictionary.get("utcoffset") if dictionary.get("utcoffset") else APIHelper.SKIP
        mtype = dictionary.get("type") if dictionary.get("type") else APIHelper.SKIP
        info = dictionary.get("info") if dictionary.get("info") else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(time,
                   utcoffset,
                   mtype,
                   info,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'time={(self.time if hasattr(self, "time") else None)!r}, '
                f'utcoffset={(self.utcoffset if hasattr(self, "utcoffset") else None)!r}, '
                f'mtype={(self.mtype if hasattr(self, "mtype") else None)!r}, '
                f'info={(self.info if hasattr(self, "info") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'time={(self.time if hasattr(self, "time") else None)!s}, '
                f'utcoffset={(self.utcoffset if hasattr(self, "utcoffset") else None)!s}, '
                f'mtype={(self.mtype if hasattr(self, "mtype") else None)!s}, '
                f'info={(self.info if hasattr(self, "info") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
