# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
import dateutil.parser

from verizon.api_helper import APIHelper
from verizon.models.v3_time_window import V3TimeWindow


class V3CampaignMetaInfo(object):

    """Implementation of the 'V3CampaignMetaInfo' model.

    Campaign and campaign details.

    Attributes:
        account_name (str): Account identifier.
        id (str): Campaign identifier.
        campaign_name (str): Campaign name.
        firmware_name (str): Firmware name.
        firmware_from (str): Old firmware version.
        firmware_to (str): New software version.
        protocol (CampaignMetaInfoProtocol): Firmware protocol. Valid values
            include: LWM2M, OMD-DM.
        make (str): Device make.
        model (str): Device model.
        start_date (date): Campaign start date.
        end_date (date): Campaign end date.
        campaign_time_window_list (List[V3TimeWindow]): List of allowed
            campaign time windows.
        status (str): Firmware upgrade status.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "account_name": 'accountName',
        "id": 'id',
        "make": 'make',
        "model": 'model',
        "start_date": 'startDate',
        "end_date": 'endDate',
        "status": 'status',
        "campaign_name": 'campaignName',
        "firmware_name": 'firmwareName',
        "firmware_from": 'firmwareFrom',
        "firmware_to": 'firmwareTo',
        "protocol": 'protocol',
        "campaign_time_window_list": 'campaignTimeWindowList'
    }

    _optionals = [
        'campaign_name',
        'firmware_name',
        'firmware_from',
        'firmware_to',
        'protocol',
        'campaign_time_window_list',
    ]

    def __init__(self,
                 account_name=None,
                 id=None,
                 make=None,
                 model=None,
                 start_date=None,
                 end_date=None,
                 status=None,
                 campaign_name=APIHelper.SKIP,
                 firmware_name=APIHelper.SKIP,
                 firmware_from=APIHelper.SKIP,
                 firmware_to=APIHelper.SKIP,
                 protocol='LWM2M',
                 campaign_time_window_list=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the V3CampaignMetaInfo class"""

        # Initialize members of the class
        self.account_name = account_name 
        self.id = id 
        if campaign_name is not APIHelper.SKIP:
            self.campaign_name = campaign_name 
        if firmware_name is not APIHelper.SKIP:
            self.firmware_name = firmware_name 
        if firmware_from is not APIHelper.SKIP:
            self.firmware_from = firmware_from 
        if firmware_to is not APIHelper.SKIP:
            self.firmware_to = firmware_to 
        self.protocol = protocol 
        self.make = make 
        self.model = model 
        self.start_date = start_date 
        self.end_date = end_date 
        if campaign_time_window_list is not APIHelper.SKIP:
            self.campaign_time_window_list = campaign_time_window_list 
        self.status = status 

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
        account_name = dictionary.get("accountName") if dictionary.get("accountName") else None
        id = dictionary.get("id") if dictionary.get("id") else None
        make = dictionary.get("make") if dictionary.get("make") else None
        model = dictionary.get("model") if dictionary.get("model") else None
        start_date = dateutil.parser.parse(dictionary.get('startDate')).date() if dictionary.get('startDate') else None
        end_date = dateutil.parser.parse(dictionary.get('endDate')).date() if dictionary.get('endDate') else None
        status = dictionary.get("status") if dictionary.get("status") else None
        campaign_name = dictionary.get("campaignName") if dictionary.get("campaignName") else APIHelper.SKIP
        firmware_name = dictionary.get("firmwareName") if dictionary.get("firmwareName") else APIHelper.SKIP
        firmware_from = dictionary.get("firmwareFrom") if dictionary.get("firmwareFrom") else APIHelper.SKIP
        firmware_to = dictionary.get("firmwareTo") if dictionary.get("firmwareTo") else APIHelper.SKIP
        protocol = dictionary.get("protocol") if dictionary.get("protocol") else 'LWM2M'
        campaign_time_window_list = None
        if dictionary.get('campaignTimeWindowList') is not None:
            campaign_time_window_list = [V3TimeWindow.from_dictionary(x) for x in dictionary.get('campaignTimeWindowList')]
        else:
            campaign_time_window_list = APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(account_name,
                   id,
                   make,
                   model,
                   start_date,
                   end_date,
                   status,
                   campaign_name,
                   firmware_name,
                   firmware_from,
                   firmware_to,
                   protocol,
                   campaign_time_window_list,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'account_name={self.account_name!r}, '
                f'id={self.id!r}, '
                f'campaign_name={(self.campaign_name if hasattr(self, "campaign_name") else None)!r}, '
                f'firmware_name={(self.firmware_name if hasattr(self, "firmware_name") else None)!r}, '
                f'firmware_from={(self.firmware_from if hasattr(self, "firmware_from") else None)!r}, '
                f'firmware_to={(self.firmware_to if hasattr(self, "firmware_to") else None)!r}, '
                f'protocol={(self.protocol if hasattr(self, "protocol") else None)!r}, '
                f'make={self.make!r}, '
                f'model={self.model!r}, '
                f'start_date={self.start_date!r}, '
                f'end_date={self.end_date!r}, '
                f'campaign_time_window_list={(self.campaign_time_window_list if hasattr(self, "campaign_time_window_list") else None)!r}, '
                f'status={self.status!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'account_name={self.account_name!s}, '
                f'id={self.id!s}, '
                f'campaign_name={(self.campaign_name if hasattr(self, "campaign_name") else None)!s}, '
                f'firmware_name={(self.firmware_name if hasattr(self, "firmware_name") else None)!s}, '
                f'firmware_from={(self.firmware_from if hasattr(self, "firmware_from") else None)!s}, '
                f'firmware_to={(self.firmware_to if hasattr(self, "firmware_to") else None)!s}, '
                f'protocol={(self.protocol if hasattr(self, "protocol") else None)!s}, '
                f'make={self.make!s}, '
                f'model={self.model!s}, '
                f'start_date={self.start_date!s}, '
                f'end_date={self.end_date!s}, '
                f'campaign_time_window_list={(self.campaign_time_window_list if hasattr(self, "campaign_time_window_list") else None)!s}, '
                f'status={self.status!s}, '
                f'additional_properties={self.additional_properties!s})')
