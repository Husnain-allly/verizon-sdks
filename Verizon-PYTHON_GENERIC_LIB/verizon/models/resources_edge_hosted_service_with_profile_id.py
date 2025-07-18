# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper
from verizon.models.resources_service_endpoint import ResourcesServiceEndpoint


class ResourcesEdgeHostedServiceWithProfileId(object):

    """Implementation of the 'ResourcesEdgeHostedServiceWithProfileId' model.

    Edge hosted service represented by Service Endpoint definition.

    Attributes:
        ern (str): Edge Resource Name. A string identifier for a set of edge
            resources.
        service_endpoint (ResourcesServiceEndpoint): Service Endpoint path,
            address, and port.
        application_server_provider_id (str): Unique ID representing the Edge
            Application Provider.
        application_id (str): Unique ID representing the Edge Application.
        service_description (str): The model property of type str.
        service_profile_id (str): The system assigned ID of the service
            profile.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "ern": 'ern',
        "service_endpoint": 'serviceEndpoint',
        "application_server_provider_id": 'applicationServerProviderId',
        "application_id": 'applicationId',
        "service_description": 'serviceDescription',
        "service_profile_id": 'serviceProfileID'
    }

    _optionals = [
        'ern',
        'service_endpoint',
        'application_server_provider_id',
        'application_id',
        'service_description',
        'service_profile_id',
    ]

    def __init__(self,
                 ern=APIHelper.SKIP,
                 service_endpoint=APIHelper.SKIP,
                 application_server_provider_id=APIHelper.SKIP,
                 application_id=APIHelper.SKIP,
                 service_description=APIHelper.SKIP,
                 service_profile_id=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the ResourcesEdgeHostedServiceWithProfileId class"""

        # Initialize members of the class
        if ern is not APIHelper.SKIP:
            self.ern = ern 
        if service_endpoint is not APIHelper.SKIP:
            self.service_endpoint = service_endpoint 
        if application_server_provider_id is not APIHelper.SKIP:
            self.application_server_provider_id = application_server_provider_id 
        if application_id is not APIHelper.SKIP:
            self.application_id = application_id 
        if service_description is not APIHelper.SKIP:
            self.service_description = service_description 
        if service_profile_id is not APIHelper.SKIP:
            self.service_profile_id = service_profile_id 

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
        ern = dictionary.get("ern") if dictionary.get("ern") else APIHelper.SKIP
        service_endpoint = ResourcesServiceEndpoint.from_dictionary(dictionary.get('serviceEndpoint')) if 'serviceEndpoint' in dictionary.keys() else APIHelper.SKIP
        application_server_provider_id = dictionary.get("applicationServerProviderId") if dictionary.get("applicationServerProviderId") else APIHelper.SKIP
        application_id = dictionary.get("applicationId") if dictionary.get("applicationId") else APIHelper.SKIP
        service_description = dictionary.get("serviceDescription") if dictionary.get("serviceDescription") else APIHelper.SKIP
        service_profile_id = dictionary.get("serviceProfileID") if dictionary.get("serviceProfileID") else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(ern,
                   service_endpoint,
                   application_server_provider_id,
                   application_id,
                   service_description,
                   service_profile_id,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'ern={(self.ern if hasattr(self, "ern") else None)!r}, '
                f'service_endpoint={(self.service_endpoint if hasattr(self, "service_endpoint") else None)!r}, '
                f'application_server_provider_id={(self.application_server_provider_id if hasattr(self, "application_server_provider_id") else None)!r}, '
                f'application_id={(self.application_id if hasattr(self, "application_id") else None)!r}, '
                f'service_description={(self.service_description if hasattr(self, "service_description") else None)!r}, '
                f'service_profile_id={(self.service_profile_id if hasattr(self, "service_profile_id") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'ern={(self.ern if hasattr(self, "ern") else None)!s}, '
                f'service_endpoint={(self.service_endpoint if hasattr(self, "service_endpoint") else None)!s}, '
                f'application_server_provider_id={(self.application_server_provider_id if hasattr(self, "application_server_provider_id") else None)!s}, '
                f'application_id={(self.application_id if hasattr(self, "application_id") else None)!s}, '
                f'service_description={(self.service_description if hasattr(self, "service_description") else None)!s}, '
                f'service_profile_id={(self.service_profile_id if hasattr(self, "service_profile_id") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
