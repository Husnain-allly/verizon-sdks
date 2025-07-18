# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper


class Keyschunk2(object):

    """Implementation of the 'keyschunk2' model.

    Attributes:
        data_percentage_50 (bool): The model property of type bool.
        data_percentage_75 (bool): The model property of type bool.
        data_percentage_90 (bool): The model property of type bool.
        data_percentage_100 (bool): The model property of type bool.
        sms_percentage_50 (bool): The model property of type bool.
        sms_percentage_75 (bool): The model property of type bool.
        sms_percentage_90 (bool): The model property of type bool.
        sms_percentage_100 (bool): The model property of type bool.
        no_of_days_b_4_promo_exp (int): The model property of type int.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "data_percentage_50": 'dataPercentage50',
        "data_percentage_75": 'dataPercentage75',
        "data_percentage_90": 'dataPercentage90',
        "data_percentage_100": 'dataPercentage100',
        "sms_percentage_50": 'smsPercentage50',
        "sms_percentage_75": 'smsPercentage75',
        "sms_percentage_90": 'smsPercentage90',
        "sms_percentage_100": 'smsPercentage100',
        "no_of_days_b_4_promo_exp": 'NoOfDaysB4PromoExp'
    }

    _optionals = [
        'data_percentage_50',
        'data_percentage_75',
        'data_percentage_90',
        'data_percentage_100',
        'sms_percentage_50',
        'sms_percentage_75',
        'sms_percentage_90',
        'sms_percentage_100',
        'no_of_days_b_4_promo_exp',
    ]

    def __init__(self,
                 data_percentage_50=APIHelper.SKIP,
                 data_percentage_75=APIHelper.SKIP,
                 data_percentage_90=APIHelper.SKIP,
                 data_percentage_100=APIHelper.SKIP,
                 sms_percentage_50=APIHelper.SKIP,
                 sms_percentage_75=APIHelper.SKIP,
                 sms_percentage_90=APIHelper.SKIP,
                 sms_percentage_100=APIHelper.SKIP,
                 no_of_days_b_4_promo_exp=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the Keyschunk2 class"""

        # Initialize members of the class
        if data_percentage_50 is not APIHelper.SKIP:
            self.data_percentage_50 = data_percentage_50 
        if data_percentage_75 is not APIHelper.SKIP:
            self.data_percentage_75 = data_percentage_75 
        if data_percentage_90 is not APIHelper.SKIP:
            self.data_percentage_90 = data_percentage_90 
        if data_percentage_100 is not APIHelper.SKIP:
            self.data_percentage_100 = data_percentage_100 
        if sms_percentage_50 is not APIHelper.SKIP:
            self.sms_percentage_50 = sms_percentage_50 
        if sms_percentage_75 is not APIHelper.SKIP:
            self.sms_percentage_75 = sms_percentage_75 
        if sms_percentage_90 is not APIHelper.SKIP:
            self.sms_percentage_90 = sms_percentage_90 
        if sms_percentage_100 is not APIHelper.SKIP:
            self.sms_percentage_100 = sms_percentage_100 
        if no_of_days_b_4_promo_exp is not APIHelper.SKIP:
            self.no_of_days_b_4_promo_exp = no_of_days_b_4_promo_exp 

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
        data_percentage_50 = dictionary.get("dataPercentage50") if "dataPercentage50" in dictionary.keys() else APIHelper.SKIP
        data_percentage_75 = dictionary.get("dataPercentage75") if "dataPercentage75" in dictionary.keys() else APIHelper.SKIP
        data_percentage_90 = dictionary.get("dataPercentage90") if "dataPercentage90" in dictionary.keys() else APIHelper.SKIP
        data_percentage_100 = dictionary.get("dataPercentage100") if "dataPercentage100" in dictionary.keys() else APIHelper.SKIP
        sms_percentage_50 = dictionary.get("smsPercentage50") if "smsPercentage50" in dictionary.keys() else APIHelper.SKIP
        sms_percentage_75 = dictionary.get("smsPercentage75") if "smsPercentage75" in dictionary.keys() else APIHelper.SKIP
        sms_percentage_90 = dictionary.get("smsPercentage90") if "smsPercentage90" in dictionary.keys() else APIHelper.SKIP
        sms_percentage_100 = dictionary.get("smsPercentage100") if "smsPercentage100" in dictionary.keys() else APIHelper.SKIP
        no_of_days_b_4_promo_exp = dictionary.get("NoOfDaysB4PromoExp") if dictionary.get("NoOfDaysB4PromoExp") else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(data_percentage_50,
                   data_percentage_75,
                   data_percentage_90,
                   data_percentage_100,
                   sms_percentage_50,
                   sms_percentage_75,
                   sms_percentage_90,
                   sms_percentage_100,
                   no_of_days_b_4_promo_exp,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'data_percentage_50={(self.data_percentage_50 if hasattr(self, "data_percentage_50") else None)!r}, '
                f'data_percentage_75={(self.data_percentage_75 if hasattr(self, "data_percentage_75") else None)!r}, '
                f'data_percentage_90={(self.data_percentage_90 if hasattr(self, "data_percentage_90") else None)!r}, '
                f'data_percentage_100={(self.data_percentage_100 if hasattr(self, "data_percentage_100") else None)!r}, '
                f'sms_percentage_50={(self.sms_percentage_50 if hasattr(self, "sms_percentage_50") else None)!r}, '
                f'sms_percentage_75={(self.sms_percentage_75 if hasattr(self, "sms_percentage_75") else None)!r}, '
                f'sms_percentage_90={(self.sms_percentage_90 if hasattr(self, "sms_percentage_90") else None)!r}, '
                f'sms_percentage_100={(self.sms_percentage_100 if hasattr(self, "sms_percentage_100") else None)!r}, '
                f'no_of_days_b_4_promo_exp={(self.no_of_days_b_4_promo_exp if hasattr(self, "no_of_days_b_4_promo_exp") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'data_percentage_50={(self.data_percentage_50 if hasattr(self, "data_percentage_50") else None)!s}, '
                f'data_percentage_75={(self.data_percentage_75 if hasattr(self, "data_percentage_75") else None)!s}, '
                f'data_percentage_90={(self.data_percentage_90 if hasattr(self, "data_percentage_90") else None)!s}, '
                f'data_percentage_100={(self.data_percentage_100 if hasattr(self, "data_percentage_100") else None)!s}, '
                f'sms_percentage_50={(self.sms_percentage_50 if hasattr(self, "sms_percentage_50") else None)!s}, '
                f'sms_percentage_75={(self.sms_percentage_75 if hasattr(self, "sms_percentage_75") else None)!s}, '
                f'sms_percentage_90={(self.sms_percentage_90 if hasattr(self, "sms_percentage_90") else None)!s}, '
                f'sms_percentage_100={(self.sms_percentage_100 if hasattr(self, "sms_percentage_100") else None)!s}, '
                f'no_of_days_b_4_promo_exp={(self.no_of_days_b_4_promo_exp if hasattr(self, "no_of_days_b_4_promo_exp") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
