# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.managed_acc_added_list import ManagedAccAddedList
from verizon.models.managed_acc_provisioned_list import ManagedAccProvisionedList


class ManagedAccountsGetAllResponse(object):

    """Implementation of the 'ManagedAccountsGetAllResponse' model.

    Attributes:
        account_name (str): Account Name
        managed_acc_added_list (List[ManagedAccAddedList]): The model property
            of type List[ManagedAccAddedList].
        managed_acc_provisioned_list (List[ManagedAccProvisionedList]): The
            model property of type List[ManagedAccProvisionedList].
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "account_name": 'accountName',
        "managed_acc_added_list": 'ManagedAccAddedList',
        "managed_acc_provisioned_list": 'managedAccProvisionedList'
    }

    _optionals = [
        'account_name',
        'managed_acc_added_list',
        'managed_acc_provisioned_list',
    ]

    def __init__(self,
                 account_name=APIHelper.SKIP,
                 managed_acc_added_list=APIHelper.SKIP,
                 managed_acc_provisioned_list=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the ManagedAccountsGetAllResponse class"""

        # Initialize members of the class
        if account_name is not APIHelper.SKIP:
            self.account_name = account_name 
        if managed_acc_added_list is not APIHelper.SKIP:
            self.managed_acc_added_list = managed_acc_added_list 
        if managed_acc_provisioned_list is not APIHelper.SKIP:
            self.managed_acc_provisioned_list = managed_acc_provisioned_list 

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
        account_name = dictionary.get("accountName") if dictionary.get("accountName") else APIHelper.SKIP
        managed_acc_added_list = None
        if dictionary.get('ManagedAccAddedList') is not None:
            managed_acc_added_list = [ManagedAccAddedList.from_dictionary(x) for x in dictionary.get('ManagedAccAddedList')]
        else:
            managed_acc_added_list = APIHelper.SKIP
        managed_acc_provisioned_list = None
        if dictionary.get('managedAccProvisionedList') is not None:
            managed_acc_provisioned_list = [ManagedAccProvisionedList.from_dictionary(x) for x in dictionary.get('managedAccProvisionedList')]
        else:
            managed_acc_provisioned_list = APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(account_name,
                   managed_acc_added_list,
                   managed_acc_provisioned_list,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'account_name={(self.account_name if hasattr(self, "account_name") else None)!r}, '
                f'managed_acc_added_list={(self.managed_acc_added_list if hasattr(self, "managed_acc_added_list") else None)!r}, '
                f'managed_acc_provisioned_list={(self.managed_acc_provisioned_list if hasattr(self, "managed_acc_provisioned_list") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'account_name={(self.account_name if hasattr(self, "account_name") else None)!s}, '
                f'managed_acc_added_list={(self.managed_acc_added_list if hasattr(self, "managed_acc_added_list") else None)!s}, '
                f'managed_acc_provisioned_list={(self.managed_acc_provisioned_list if hasattr(self, "managed_acc_provisioned_list") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
