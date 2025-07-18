# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.v3_campaign_meta_info import V3CampaignMetaInfo


class V3CampaignHistory(object):

    """Implementation of the 'V3CampaignHistory' model.

    Campaign history.

    Attributes:
        has_more_data (bool): Has more report flag?
        last_seen_campaign_id (str): Campaign identifier.
        campaign_list (List[V3CampaignMetaInfo]): Firmware upgrade list.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "has_more_data": 'hasMoreData',
        "campaign_list": 'campaignList',
        "last_seen_campaign_id": 'lastSeenCampaignId'
    }

    _optionals = [
        'last_seen_campaign_id',
    ]

    _nullables = [
        'campaign_list',
    ]

    def __init__(self,
                 has_more_data=None,
                 campaign_list=None,
                 last_seen_campaign_id=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the V3CampaignHistory class"""

        # Initialize members of the class
        self.has_more_data = has_more_data 
        if last_seen_campaign_id is not APIHelper.SKIP:
            self.last_seen_campaign_id = last_seen_campaign_id 
        self.campaign_list = campaign_list 

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
        has_more_data = dictionary.get("hasMoreData") if "hasMoreData" in dictionary.keys() else None
        campaign_list = None
        if dictionary.get('campaignList') is not None:
            campaign_list = [V3CampaignMetaInfo.from_dictionary(x) for x in dictionary.get('campaignList')]
        last_seen_campaign_id = dictionary.get("lastSeenCampaignId") if dictionary.get("lastSeenCampaignId") else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(has_more_data,
                   campaign_list,
                   last_seen_campaign_id,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'has_more_data={self.has_more_data!r}, '
                f'last_seen_campaign_id={(self.last_seen_campaign_id if hasattr(self, "last_seen_campaign_id") else None)!r}, '
                f'campaign_list={self.campaign_list!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'has_more_data={self.has_more_data!s}, '
                f'last_seen_campaign_id={(self.last_seen_campaign_id if hasattr(self, "last_seen_campaign_id") else None)!s}, '
                f'campaign_list={self.campaign_list!s}, '
                f'additional_properties={self.additional_properties!s})')
