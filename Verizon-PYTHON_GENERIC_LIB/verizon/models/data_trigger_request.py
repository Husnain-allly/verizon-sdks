# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper


class DataTriggerRequest(object):

    """Implementation of the 'DataTriggerRequest' model.

    Attributes:
        comparator (str): The model property of type str.
        threshold (int): The model property of type int.
        threshold_unit (str): The model property of type str.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "comparator": 'comparator',
        "threshold": 'threshold',
        "threshold_unit": 'thresholdUnit'
    }

    _optionals = [
        'comparator',
        'threshold',
        'threshold_unit',
    ]

    def __init__(self,
                 comparator=APIHelper.SKIP,
                 threshold=APIHelper.SKIP,
                 threshold_unit=APIHelper.SKIP):
        """Constructor for the DataTriggerRequest class"""

        # Initialize members of the class
        if comparator is not APIHelper.SKIP:
            self.comparator = comparator 
        if threshold is not APIHelper.SKIP:
            self.threshold = threshold 
        if threshold_unit is not APIHelper.SKIP:
            self.threshold_unit = threshold_unit 

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
        comparator = dictionary.get("comparator") if dictionary.get("comparator") else APIHelper.SKIP
        threshold = dictionary.get("threshold") if dictionary.get("threshold") else APIHelper.SKIP
        threshold_unit = dictionary.get("thresholdUnit") if dictionary.get("thresholdUnit") else APIHelper.SKIP
        # Return an object of this model
        return cls(comparator,
                   threshold,
                   threshold_unit)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'comparator={(self.comparator if hasattr(self, "comparator") else None)!r}, '
                f'threshold={(self.threshold if hasattr(self, "threshold") else None)!r}, '
                f'threshold_unit={(self.threshold_unit if hasattr(self, "threshold_unit") else None)!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'comparator={(self.comparator if hasattr(self, "comparator") else None)!s}, '
                f'threshold={(self.threshold if hasattr(self, "threshold") else None)!s}, '
                f'threshold_unit={(self.threshold_unit if hasattr(self, "threshold_unit") else None)!s})')
