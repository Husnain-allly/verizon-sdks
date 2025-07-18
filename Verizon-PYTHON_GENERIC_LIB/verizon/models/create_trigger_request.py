# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.anomaly_trigger_request import AnomalyTriggerRequest
from verizon.models.data_trigger_request import DataTriggerRequest
from verizon.models.session_trigger_request import SessionTriggerRequest
from verizon.models.sms_trigger_request import SmsTriggerRequest


class CreateTriggerRequest(object):

    """Implementation of the 'CreateTriggerRequest' model.

    Attributes:
        account_name (str): The model property of type str.
        anomaly_trigger_request (AnomalyTriggerRequest): The details of the
            UsageAnomaly trigger.
        data_trigger_request (DataTriggerRequest): The model property of type
            DataTriggerRequest.
        group_name (str): The model property of type str.
        name (str): The model property of type str.
        session_trigger_request (SessionTriggerRequest): The model property of
            type SessionTriggerRequest.
        sms_trigger_request (SmsTriggerRequest): The model property of type
            SmsTriggerRequest.
        trigger_category (str): The model property of type str.
        trigger_cycle (str): The model property of type str.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "account_name": 'accountName',
        "anomaly_trigger_request": 'anomalyTriggerRequest',
        "data_trigger_request": 'dataTriggerRequest',
        "group_name": 'groupName',
        "name": 'name',
        "session_trigger_request": 'sessionTriggerRequest',
        "sms_trigger_request": 'smsTriggerRequest',
        "trigger_category": 'triggerCategory',
        "trigger_cycle": 'triggerCycle'
    }

    _optionals = [
        'account_name',
        'anomaly_trigger_request',
        'data_trigger_request',
        'group_name',
        'name',
        'session_trigger_request',
        'sms_trigger_request',
        'trigger_category',
        'trigger_cycle',
    ]

    def __init__(self,
                 account_name=APIHelper.SKIP,
                 anomaly_trigger_request=APIHelper.SKIP,
                 data_trigger_request=APIHelper.SKIP,
                 group_name=APIHelper.SKIP,
                 name=APIHelper.SKIP,
                 session_trigger_request=APIHelper.SKIP,
                 sms_trigger_request=APIHelper.SKIP,
                 trigger_category=APIHelper.SKIP,
                 trigger_cycle=APIHelper.SKIP):
        """Constructor for the CreateTriggerRequest class"""

        # Initialize members of the class
        if account_name is not APIHelper.SKIP:
            self.account_name = account_name 
        if anomaly_trigger_request is not APIHelper.SKIP:
            self.anomaly_trigger_request = anomaly_trigger_request 
        if data_trigger_request is not APIHelper.SKIP:
            self.data_trigger_request = data_trigger_request 
        if group_name is not APIHelper.SKIP:
            self.group_name = group_name 
        if name is not APIHelper.SKIP:
            self.name = name 
        if session_trigger_request is not APIHelper.SKIP:
            self.session_trigger_request = session_trigger_request 
        if sms_trigger_request is not APIHelper.SKIP:
            self.sms_trigger_request = sms_trigger_request 
        if trigger_category is not APIHelper.SKIP:
            self.trigger_category = trigger_category 
        if trigger_cycle is not APIHelper.SKIP:
            self.trigger_cycle = trigger_cycle 

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
        anomaly_trigger_request = AnomalyTriggerRequest.from_dictionary(dictionary.get('anomalyTriggerRequest')) if 'anomalyTriggerRequest' in dictionary.keys() else APIHelper.SKIP
        data_trigger_request = DataTriggerRequest.from_dictionary(dictionary.get('dataTriggerRequest')) if 'dataTriggerRequest' in dictionary.keys() else APIHelper.SKIP
        group_name = dictionary.get("groupName") if dictionary.get("groupName") else APIHelper.SKIP
        name = dictionary.get("name") if dictionary.get("name") else APIHelper.SKIP
        session_trigger_request = SessionTriggerRequest.from_dictionary(dictionary.get('sessionTriggerRequest')) if 'sessionTriggerRequest' in dictionary.keys() else APIHelper.SKIP
        sms_trigger_request = SmsTriggerRequest.from_dictionary(dictionary.get('smsTriggerRequest')) if 'smsTriggerRequest' in dictionary.keys() else APIHelper.SKIP
        trigger_category = dictionary.get("triggerCategory") if dictionary.get("triggerCategory") else APIHelper.SKIP
        trigger_cycle = dictionary.get("triggerCycle") if dictionary.get("triggerCycle") else APIHelper.SKIP
        # Return an object of this model
        return cls(account_name,
                   anomaly_trigger_request,
                   data_trigger_request,
                   group_name,
                   name,
                   session_trigger_request,
                   sms_trigger_request,
                   trigger_category,
                   trigger_cycle)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'account_name={(self.account_name if hasattr(self, "account_name") else None)!r}, '
                f'anomaly_trigger_request={(self.anomaly_trigger_request if hasattr(self, "anomaly_trigger_request") else None)!r}, '
                f'data_trigger_request={(self.data_trigger_request if hasattr(self, "data_trigger_request") else None)!r}, '
                f'group_name={(self.group_name if hasattr(self, "group_name") else None)!r}, '
                f'name={(self.name if hasattr(self, "name") else None)!r}, '
                f'session_trigger_request={(self.session_trigger_request if hasattr(self, "session_trigger_request") else None)!r}, '
                f'sms_trigger_request={(self.sms_trigger_request if hasattr(self, "sms_trigger_request") else None)!r}, '
                f'trigger_category={(self.trigger_category if hasattr(self, "trigger_category") else None)!r}, '
                f'trigger_cycle={(self.trigger_cycle if hasattr(self, "trigger_cycle") else None)!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'account_name={(self.account_name if hasattr(self, "account_name") else None)!s}, '
                f'anomaly_trigger_request={(self.anomaly_trigger_request if hasattr(self, "anomaly_trigger_request") else None)!s}, '
                f'data_trigger_request={(self.data_trigger_request if hasattr(self, "data_trigger_request") else None)!s}, '
                f'group_name={(self.group_name if hasattr(self, "group_name") else None)!s}, '
                f'name={(self.name if hasattr(self, "name") else None)!s}, '
                f'session_trigger_request={(self.session_trigger_request if hasattr(self, "session_trigger_request") else None)!s}, '
                f'sms_trigger_request={(self.sms_trigger_request if hasattr(self, "sms_trigger_request") else None)!s}, '
                f'trigger_category={(self.trigger_category if hasattr(self, "trigger_category") else None)!s}, '
                f'trigger_cycle={(self.trigger_cycle if hasattr(self, "trigger_cycle") else None)!s})')
