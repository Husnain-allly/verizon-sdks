# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.flow_info import FlowInfo
from verizon.models.qos_device_id import QosDeviceId


class QosDeviceInfo(object):

    """Implementation of the 'QOSdeviceInfo' model.

    Attributes:
        device_id (QosDeviceId): The model property of type QosDeviceId.
        device_i_pv_6_addr (str): The model property of type str.
        flow_info (List[FlowInfo]): The model property of type List[FlowInfo].
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "device_id": 'deviceId',
        "flow_info": 'flowInfo',
        "device_i_pv_6_addr": 'deviceIPv6Addr'
    }

    _optionals = [
        'device_i_pv_6_addr',
    ]

    def __init__(self,
                 device_id=None,
                 flow_info=None,
                 device_i_pv_6_addr=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the QosDeviceInfo class"""

        # Initialize members of the class
        self.device_id = device_id 
        if device_i_pv_6_addr is not APIHelper.SKIP:
            self.device_i_pv_6_addr = device_i_pv_6_addr 
        self.flow_info = flow_info 

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
        device_id = QosDeviceId.from_dictionary(dictionary.get('deviceId')) if dictionary.get('deviceId') else None
        flow_info = None
        if dictionary.get('flowInfo') is not None:
            flow_info = [FlowInfo.from_dictionary(x) for x in dictionary.get('flowInfo')]
        device_i_pv_6_addr = dictionary.get("deviceIPv6Addr") if dictionary.get("deviceIPv6Addr") else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(device_id,
                   flow_info,
                   device_i_pv_6_addr,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'device_id={self.device_id!r}, '
                f'device_i_pv_6_addr={(self.device_i_pv_6_addr if hasattr(self, "device_i_pv_6_addr") else None)!r}, '
                f'flow_info={self.flow_info!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'device_id={self.device_id!s}, '
                f'device_i_pv_6_addr={(self.device_i_pv_6_addr if hasattr(self, "device_i_pv_6_addr") else None)!s}, '
                f'flow_info={self.flow_info!s}, '
                f'additional_properties={self.additional_properties!s})')
