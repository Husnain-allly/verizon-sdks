# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper


class DtoHealthScoreMetric(object):

    """Implementation of the 'dto.HealthScoreMetric' model.

    Attributes:
        metrictype (str): The type of measurement and can be overallscore,
            networkscore, gatewayscore, sensorscore, networkstatus,
            averagesignalstrength or networkavailabilitylast30
        metricvalue (str): the value of the `metrictype` as a percentage

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "metrictype": 'metrictype',
        "metricvalue": 'metricvalue'
    }

    _optionals = [
        'metrictype',
        'metricvalue',
    ]

    def __init__(self,
                 metrictype=APIHelper.SKIP,
                 metricvalue=APIHelper.SKIP):
        """Constructor for the DtoHealthScoreMetric class"""

        # Initialize members of the class
        if metrictype is not APIHelper.SKIP:
            self.metrictype = metrictype 
        if metricvalue is not APIHelper.SKIP:
            self.metricvalue = metricvalue 

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
        metrictype = dictionary.get("metrictype") if dictionary.get("metrictype") else APIHelper.SKIP
        metricvalue = dictionary.get("metricvalue") if dictionary.get("metricvalue") else APIHelper.SKIP
        # Return an object of this model
        return cls(metrictype,
                   metricvalue)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'metrictype={(self.metrictype if hasattr(self, "metrictype") else None)!r}, '
                f'metricvalue={(self.metricvalue if hasattr(self, "metricvalue") else None)!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'metrictype={(self.metrictype if hasattr(self, "metrictype") else None)!s}, '
                f'metricvalue={(self.metricvalue if hasattr(self, "metricvalue") else None)!s})')
