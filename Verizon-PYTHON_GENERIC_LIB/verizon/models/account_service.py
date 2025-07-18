# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.state import State


class AccountService(object):

    """Implementation of the 'AccountService' model.

    Service associated with the account.

    Attributes:
        name (str): The name of the service plan.
        description (str): The description of the service plan.
        states (List[State]): The state of the service plan.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "name": 'name',
        "description": 'description',
        "states": 'states'
    }

    _optionals = [
        'name',
        'description',
        'states',
    ]

    def __init__(self,
                 name=APIHelper.SKIP,
                 description=APIHelper.SKIP,
                 states=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the AccountService class"""

        # Initialize members of the class
        if name is not APIHelper.SKIP:
            self.name = name 
        if description is not APIHelper.SKIP:
            self.description = description 
        if states is not APIHelper.SKIP:
            self.states = states 

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
        name = dictionary.get("name") if dictionary.get("name") else APIHelper.SKIP
        description = dictionary.get("description") if dictionary.get("description") else APIHelper.SKIP
        states = None
        if dictionary.get('states') is not None:
            states = [State.from_dictionary(x) for x in dictionary.get('states')]
        else:
            states = APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(name,
                   description,
                   states,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'name={(self.name if hasattr(self, "name") else None)!r}, '
                f'description={(self.description if hasattr(self, "description") else None)!r}, '
                f'states={(self.states if hasattr(self, "states") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'name={(self.name if hasattr(self, "name") else None)!s}, '
                f'description={(self.description if hasattr(self, "description") else None)!s}, '
                f'states={(self.states if hasattr(self, "states") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
