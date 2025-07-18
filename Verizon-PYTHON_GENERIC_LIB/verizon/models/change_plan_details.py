# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper


class ChangePlanDetails(object):

    """Implementation of the 'changePlanDetails' model.

    The service plan code to switch to

    Attributes:
        to_carrier_service_plan_code (str): The model property of type str.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "to_carrier_service_plan_code": 'toCarrierServicePlanCode'
    }

    _optionals = [
        'to_carrier_service_plan_code',
    ]

    def __init__(self,
                 to_carrier_service_plan_code=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the ChangePlanDetails class"""

        # Initialize members of the class
        if to_carrier_service_plan_code is not APIHelper.SKIP:
            self.to_carrier_service_plan_code = to_carrier_service_plan_code 

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
        to_carrier_service_plan_code = dictionary.get("toCarrierServicePlanCode") if dictionary.get("toCarrierServicePlanCode") else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(to_carrier_service_plan_code,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'to_carrier_service_plan_code={(self.to_carrier_service_plan_code if hasattr(self, "to_carrier_service_plan_code") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'to_carrier_service_plan_code={(self.to_carrier_service_plan_code if hasattr(self, "to_carrier_service_plan_code") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
