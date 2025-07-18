# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.actionobject import Actionobject
from verizon.models.allowance_threshold import AllowanceThreshold
from verizon.models.device_group_filter_criteria import DeviceGroupFilterCriteria


class DataTrigger2(object):

    """Implementation of the 'DataTrigger2' model.

    Attributes:
        device_group (DeviceGroupFilterCriteria): The model property of type
            DeviceGroupFilterCriteria.
        condition_type (ConditionType): The condition type being monitored
        comparitor (Comparitor): The boolean of the comparison. `gt` is
            Greater Than, `lt` is Less Than and `eq` is Equal To
        threshold (int): The threshold value the trigger monitors for
        threshold_unit (ThresholdUnit): The units of the threshold. This can
            be KB, Kilobits, MB, Megabits, or GB, Gigabits
        cycle_type (RulesCycleType): The interval to monitor for the
            threshold. This can be Daily, Weekly or Monthly
        allowance_threshold (AllowanceThreshold): The model property of type
            AllowanceThreshold.
        action (Actionobject): The model property of type Actionobject.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "device_group": 'deviceGroup',
        "condition_type": 'conditionType',
        "comparitor": 'comparitor',
        "threshold": 'threshold',
        "threshold_unit": 'thresholdUnit',
        "cycle_type": 'cycleType',
        "allowance_threshold": 'allowanceThreshold',
        "action": 'action'
    }

    _optionals = [
        'device_group',
        'condition_type',
        'comparitor',
        'threshold',
        'threshold_unit',
        'cycle_type',
        'allowance_threshold',
        'action',
    ]

    def __init__(self,
                 device_group=APIHelper.SKIP,
                 condition_type=APIHelper.SKIP,
                 comparitor=APIHelper.SKIP,
                 threshold=APIHelper.SKIP,
                 threshold_unit=APIHelper.SKIP,
                 cycle_type=APIHelper.SKIP,
                 allowance_threshold=APIHelper.SKIP,
                 action=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the DataTrigger2 class"""

        # Initialize members of the class
        if device_group is not APIHelper.SKIP:
            self.device_group = device_group 
        if condition_type is not APIHelper.SKIP:
            self.condition_type = condition_type 
        if comparitor is not APIHelper.SKIP:
            self.comparitor = comparitor 
        if threshold is not APIHelper.SKIP:
            self.threshold = threshold 
        if threshold_unit is not APIHelper.SKIP:
            self.threshold_unit = threshold_unit 
        if cycle_type is not APIHelper.SKIP:
            self.cycle_type = cycle_type 
        if allowance_threshold is not APIHelper.SKIP:
            self.allowance_threshold = allowance_threshold 
        if action is not APIHelper.SKIP:
            self.action = action 

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
        device_group = DeviceGroupFilterCriteria.from_dictionary(dictionary.get('deviceGroup')) if 'deviceGroup' in dictionary.keys() else APIHelper.SKIP
        condition_type = dictionary.get("conditionType") if dictionary.get("conditionType") else APIHelper.SKIP
        comparitor = dictionary.get("comparitor") if dictionary.get("comparitor") else APIHelper.SKIP
        threshold = dictionary.get("threshold") if dictionary.get("threshold") else APIHelper.SKIP
        threshold_unit = dictionary.get("thresholdUnit") if dictionary.get("thresholdUnit") else APIHelper.SKIP
        cycle_type = dictionary.get("cycleType") if dictionary.get("cycleType") else APIHelper.SKIP
        allowance_threshold = AllowanceThreshold.from_dictionary(dictionary.get('allowanceThreshold')) if 'allowanceThreshold' in dictionary.keys() else APIHelper.SKIP
        action = Actionobject.from_dictionary(dictionary.get('action')) if 'action' in dictionary.keys() else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(device_group,
                   condition_type,
                   comparitor,
                   threshold,
                   threshold_unit,
                   cycle_type,
                   allowance_threshold,
                   action,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'device_group={(self.device_group if hasattr(self, "device_group") else None)!r}, '
                f'condition_type={(self.condition_type if hasattr(self, "condition_type") else None)!r}, '
                f'comparitor={(self.comparitor if hasattr(self, "comparitor") else None)!r}, '
                f'threshold={(self.threshold if hasattr(self, "threshold") else None)!r}, '
                f'threshold_unit={(self.threshold_unit if hasattr(self, "threshold_unit") else None)!r}, '
                f'cycle_type={(self.cycle_type if hasattr(self, "cycle_type") else None)!r}, '
                f'allowance_threshold={(self.allowance_threshold if hasattr(self, "allowance_threshold") else None)!r}, '
                f'action={(self.action if hasattr(self, "action") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'device_group={(self.device_group if hasattr(self, "device_group") else None)!s}, '
                f'condition_type={(self.condition_type if hasattr(self, "condition_type") else None)!s}, '
                f'comparitor={(self.comparitor if hasattr(self, "comparitor") else None)!s}, '
                f'threshold={(self.threshold if hasattr(self, "threshold") else None)!s}, '
                f'threshold_unit={(self.threshold_unit if hasattr(self, "threshold_unit") else None)!s}, '
                f'cycle_type={(self.cycle_type if hasattr(self, "cycle_type") else None)!s}, '
                f'allowance_threshold={(self.allowance_threshold if hasattr(self, "allowance_threshold") else None)!s}, '
                f'action={(self.action if hasattr(self, "action") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
