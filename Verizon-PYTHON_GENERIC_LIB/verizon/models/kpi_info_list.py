# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.kpi_info import KpiInfo


class KpiInfoList(object):

    """Implementation of the 'KPIInfoList' model.

    Attributes:
        kpi_info_list (List[KpiInfo]): The model property of type
            List[KpiInfo].
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "kpi_info_list": 'KpiInfoList'
    }

    _optionals = [
        'kpi_info_list',
    ]

    def __init__(self,
                 kpi_info_list=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the KpiInfoList class"""

        # Initialize members of the class
        if kpi_info_list is not APIHelper.SKIP:
            self.kpi_info_list = kpi_info_list 

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
        kpi_info_list = None
        if dictionary.get('KpiInfoList') is not None:
            kpi_info_list = [KpiInfo.from_dictionary(x) for x in dictionary.get('KpiInfoList')]
        else:
            kpi_info_list = APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(kpi_info_list,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'kpi_info_list={(self.kpi_info_list if hasattr(self, "kpi_info_list") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'kpi_info_list={(self.kpi_info_list if hasattr(self, "kpi_info_list") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
