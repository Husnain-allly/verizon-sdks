# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.account_device_list import AccountDeviceList
from verizon.models.custom_fields import CustomFields


class ServicePlanUpdateRequest(object):

    """Implementation of the 'ServicePlanUpdateRequest' model.

    Request to update service plan.

    Attributes:
        service_plan (str): The service plan code that you want to assign to
            all specified devices.
        account_name (str): The name of a billing account.
        current_service_plan (str): The name of a service plan, if you want to
            only include devices that have that service plan.
        custom_fields (List[CustomFields]): Custom field names and values, if
            you want to only include devices that have matching values.
        devices (List[AccountDeviceList]): A list of the devices that you want
            to change, specified by device identifier.
        group_name (str): The name of a device group, if you want to restore
            service for all devices in that group.
        carrier_ip_pool_name (str): The model property of type str.
        take_effect (datetime): The model property of type datetime.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "service_plan": 'servicePlan',
        "account_name": 'accountName',
        "current_service_plan": 'currentServicePlan',
        "custom_fields": 'customFields',
        "devices": 'devices',
        "group_name": 'groupName',
        "carrier_ip_pool_name": 'carrierIpPoolName',
        "take_effect": 'takeEffect'
    }

    _optionals = [
        'account_name',
        'current_service_plan',
        'custom_fields',
        'devices',
        'group_name',
        'carrier_ip_pool_name',
        'take_effect',
    ]

    def __init__(self,
                 service_plan=None,
                 account_name=APIHelper.SKIP,
                 current_service_plan=APIHelper.SKIP,
                 custom_fields=APIHelper.SKIP,
                 devices=APIHelper.SKIP,
                 group_name=APIHelper.SKIP,
                 carrier_ip_pool_name=APIHelper.SKIP,
                 take_effect=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the ServicePlanUpdateRequest class"""

        # Initialize members of the class
        self.service_plan = service_plan 
        if account_name is not APIHelper.SKIP:
            self.account_name = account_name 
        if current_service_plan is not APIHelper.SKIP:
            self.current_service_plan = current_service_plan 
        if custom_fields is not APIHelper.SKIP:
            self.custom_fields = custom_fields 
        if devices is not APIHelper.SKIP:
            self.devices = devices 
        if group_name is not APIHelper.SKIP:
            self.group_name = group_name 
        if carrier_ip_pool_name is not APIHelper.SKIP:
            self.carrier_ip_pool_name = carrier_ip_pool_name 
        if take_effect is not APIHelper.SKIP:
            self.take_effect = APIHelper.apply_datetime_converter(take_effect, APIHelper.RFC3339DateTime) if take_effect else None 

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
        service_plan = dictionary.get("servicePlan") if dictionary.get("servicePlan") else None
        account_name = dictionary.get("accountName") if dictionary.get("accountName") else APIHelper.SKIP
        current_service_plan = dictionary.get("currentServicePlan") if dictionary.get("currentServicePlan") else APIHelper.SKIP
        custom_fields = None
        if dictionary.get('customFields') is not None:
            custom_fields = [CustomFields.from_dictionary(x) for x in dictionary.get('customFields')]
        else:
            custom_fields = APIHelper.SKIP
        devices = None
        if dictionary.get('devices') is not None:
            devices = [AccountDeviceList.from_dictionary(x) for x in dictionary.get('devices')]
        else:
            devices = APIHelper.SKIP
        group_name = dictionary.get("groupName") if dictionary.get("groupName") else APIHelper.SKIP
        carrier_ip_pool_name = dictionary.get("carrierIpPoolName") if dictionary.get("carrierIpPoolName") else APIHelper.SKIP
        take_effect = APIHelper.RFC3339DateTime.from_value(dictionary.get("takeEffect")).datetime if dictionary.get("takeEffect") else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(service_plan,
                   account_name,
                   current_service_plan,
                   custom_fields,
                   devices,
                   group_name,
                   carrier_ip_pool_name,
                   take_effect,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'service_plan={self.service_plan!r}, '
                f'account_name={(self.account_name if hasattr(self, "account_name") else None)!r}, '
                f'current_service_plan={(self.current_service_plan if hasattr(self, "current_service_plan") else None)!r}, '
                f'custom_fields={(self.custom_fields if hasattr(self, "custom_fields") else None)!r}, '
                f'devices={(self.devices if hasattr(self, "devices") else None)!r}, '
                f'group_name={(self.group_name if hasattr(self, "group_name") else None)!r}, '
                f'carrier_ip_pool_name={(self.carrier_ip_pool_name if hasattr(self, "carrier_ip_pool_name") else None)!r}, '
                f'take_effect={(self.take_effect if hasattr(self, "take_effect") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'service_plan={self.service_plan!s}, '
                f'account_name={(self.account_name if hasattr(self, "account_name") else None)!s}, '
                f'current_service_plan={(self.current_service_plan if hasattr(self, "current_service_plan") else None)!s}, '
                f'custom_fields={(self.custom_fields if hasattr(self, "custom_fields") else None)!s}, '
                f'devices={(self.devices if hasattr(self, "devices") else None)!s}, '
                f'group_name={(self.group_name if hasattr(self, "group_name") else None)!s}, '
                f'carrier_ip_pool_name={(self.carrier_ip_pool_name if hasattr(self, "carrier_ip_pool_name") else None)!s}, '
                f'take_effect={(self.take_effect if hasattr(self, "take_effect") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
