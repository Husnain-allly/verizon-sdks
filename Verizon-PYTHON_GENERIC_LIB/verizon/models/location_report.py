# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.location import Location


class LocationReport(object):

    """Implementation of the 'LocationReport' model.

    Location information for up to 1,000 devices.

    Attributes:
        dev_location_list (List[Location]): Device location information.
        has_more_data (bool): True if there are more device locations to
            retrieve.
        start_index (str): The zero-based number of the first record to
            return. Set startIndex=0 for the first request. If there are more
            than 1,000 devices to be returned (hasMoreData=true), set
            startIndex=1000 for the second request, 2000 for the third
            request, etc.
        total_count (int): The total number of devices in the original request
            and in the report.
        txid (str): The transaction ID of the report.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "dev_location_list": 'devLocationList',
        "has_more_data": 'hasMoreData',
        "start_index": 'startIndex',
        "total_count": 'totalCount',
        "txid": 'txid'
    }

    _optionals = [
        'dev_location_list',
        'has_more_data',
        'start_index',
        'total_count',
        'txid',
    ]

    def __init__(self,
                 dev_location_list=APIHelper.SKIP,
                 has_more_data=APIHelper.SKIP,
                 start_index=APIHelper.SKIP,
                 total_count=APIHelper.SKIP,
                 txid=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the LocationReport class"""

        # Initialize members of the class
        if dev_location_list is not APIHelper.SKIP:
            self.dev_location_list = dev_location_list 
        if has_more_data is not APIHelper.SKIP:
            self.has_more_data = has_more_data 
        if start_index is not APIHelper.SKIP:
            self.start_index = start_index 
        if total_count is not APIHelper.SKIP:
            self.total_count = total_count 
        if txid is not APIHelper.SKIP:
            self.txid = txid 

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
        dev_location_list = None
        if dictionary.get('devLocationList') is not None:
            dev_location_list = [Location.from_dictionary(x) for x in dictionary.get('devLocationList')]
        else:
            dev_location_list = APIHelper.SKIP
        has_more_data = dictionary.get("hasMoreData") if "hasMoreData" in dictionary.keys() else APIHelper.SKIP
        start_index = dictionary.get("startIndex") if dictionary.get("startIndex") else APIHelper.SKIP
        total_count = dictionary.get("totalCount") if dictionary.get("totalCount") else APIHelper.SKIP
        txid = dictionary.get("txid") if dictionary.get("txid") else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(dev_location_list,
                   has_more_data,
                   start_index,
                   total_count,
                   txid,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'dev_location_list={(self.dev_location_list if hasattr(self, "dev_location_list") else None)!r}, '
                f'has_more_data={(self.has_more_data if hasattr(self, "has_more_data") else None)!r}, '
                f'start_index={(self.start_index if hasattr(self, "start_index") else None)!r}, '
                f'total_count={(self.total_count if hasattr(self, "total_count") else None)!r}, '
                f'txid={(self.txid if hasattr(self, "txid") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'dev_location_list={(self.dev_location_list if hasattr(self, "dev_location_list") else None)!s}, '
                f'has_more_data={(self.has_more_data if hasattr(self, "has_more_data") else None)!s}, '
                f'start_index={(self.start_index if hasattr(self, "start_index") else None)!s}, '
                f'total_count={(self.total_count if hasattr(self, "total_count") else None)!s}, '
                f'txid={(self.txid if hasattr(self, "txid") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
