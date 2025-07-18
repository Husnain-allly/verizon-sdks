# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper


class CreateIoTApplicationRequest(object):

    """Implementation of the 'CreateIoTApplicationRequest' model.

    The request body must include the UUID of the subscription that you want
    to update plus any properties that you want to change.

    Attributes:
        app_name (str): A user defined name for the application being deployed
            in Azure IoT Central.
        billing_account_id (str): The ThingSpace ID of the authenticating
            billing account
        client_id (str): The Azure ClientID of the associated Azure target
            account
        client_secret (str): The Azure Client Secret of the associated Azure
            target account
        email_i_ds (str): The “email IDs” to be added to/sent to with this API.
        resourcegroup (str): The Azure Resource group of the associated Azure
            target account
        sample_io_tc_app (str): This is the reference Azure IoT Central
            application developed by Verizon.
        subscription_id (str): The Azure Subscription ID of the associated
            Azure target account
        tenant_id (str): The Azure Tenant ID of the associated Azure target
            account
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "app_name": 'appName',
        "billing_account_id": 'billingAccountID',
        "client_id": 'clientID',
        "client_secret": 'clientSecret',
        "email_i_ds": 'emailIDs',
        "resourcegroup": 'resourcegroup',
        "sample_io_tc_app": 'sampleIOTcApp',
        "subscription_id": 'subscriptionID',
        "tenant_id": 'tenantID'
    }

    _optionals = [
        'app_name',
        'billing_account_id',
        'client_id',
        'client_secret',
        'email_i_ds',
        'resourcegroup',
        'sample_io_tc_app',
        'subscription_id',
        'tenant_id',
    ]

    def __init__(self,
                 app_name=APIHelper.SKIP,
                 billing_account_id=APIHelper.SKIP,
                 client_id=APIHelper.SKIP,
                 client_secret=APIHelper.SKIP,
                 email_i_ds=APIHelper.SKIP,
                 resourcegroup=APIHelper.SKIP,
                 sample_io_tc_app=APIHelper.SKIP,
                 subscription_id=APIHelper.SKIP,
                 tenant_id=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the CreateIoTApplicationRequest class"""

        # Initialize members of the class
        if app_name is not APIHelper.SKIP:
            self.app_name = app_name 
        if billing_account_id is not APIHelper.SKIP:
            self.billing_account_id = billing_account_id 
        if client_id is not APIHelper.SKIP:
            self.client_id = client_id 
        if client_secret is not APIHelper.SKIP:
            self.client_secret = client_secret 
        if email_i_ds is not APIHelper.SKIP:
            self.email_i_ds = email_i_ds 
        if resourcegroup is not APIHelper.SKIP:
            self.resourcegroup = resourcegroup 
        if sample_io_tc_app is not APIHelper.SKIP:
            self.sample_io_tc_app = sample_io_tc_app 
        if subscription_id is not APIHelper.SKIP:
            self.subscription_id = subscription_id 
        if tenant_id is not APIHelper.SKIP:
            self.tenant_id = tenant_id 

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
        app_name = dictionary.get("appName") if dictionary.get("appName") else APIHelper.SKIP
        billing_account_id = dictionary.get("billingAccountID") if dictionary.get("billingAccountID") else APIHelper.SKIP
        client_id = dictionary.get("clientID") if dictionary.get("clientID") else APIHelper.SKIP
        client_secret = dictionary.get("clientSecret") if dictionary.get("clientSecret") else APIHelper.SKIP
        email_i_ds = dictionary.get("emailIDs") if dictionary.get("emailIDs") else APIHelper.SKIP
        resourcegroup = dictionary.get("resourcegroup") if dictionary.get("resourcegroup") else APIHelper.SKIP
        sample_io_tc_app = dictionary.get("sampleIOTcApp") if dictionary.get("sampleIOTcApp") else APIHelper.SKIP
        subscription_id = dictionary.get("subscriptionID") if dictionary.get("subscriptionID") else APIHelper.SKIP
        tenant_id = dictionary.get("tenantID") if dictionary.get("tenantID") else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(app_name,
                   billing_account_id,
                   client_id,
                   client_secret,
                   email_i_ds,
                   resourcegroup,
                   sample_io_tc_app,
                   subscription_id,
                   tenant_id,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'app_name={(self.app_name if hasattr(self, "app_name") else None)!r}, '
                f'billing_account_id={(self.billing_account_id if hasattr(self, "billing_account_id") else None)!r}, '
                f'client_id={(self.client_id if hasattr(self, "client_id") else None)!r}, '
                f'client_secret={(self.client_secret if hasattr(self, "client_secret") else None)!r}, '
                f'email_i_ds={(self.email_i_ds if hasattr(self, "email_i_ds") else None)!r}, '
                f'resourcegroup={(self.resourcegroup if hasattr(self, "resourcegroup") else None)!r}, '
                f'sample_io_tc_app={(self.sample_io_tc_app if hasattr(self, "sample_io_tc_app") else None)!r}, '
                f'subscription_id={(self.subscription_id if hasattr(self, "subscription_id") else None)!r}, '
                f'tenant_id={(self.tenant_id if hasattr(self, "tenant_id") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'app_name={(self.app_name if hasattr(self, "app_name") else None)!s}, '
                f'billing_account_id={(self.billing_account_id if hasattr(self, "billing_account_id") else None)!s}, '
                f'client_id={(self.client_id if hasattr(self, "client_id") else None)!s}, '
                f'client_secret={(self.client_secret if hasattr(self, "client_secret") else None)!s}, '
                f'email_i_ds={(self.email_i_ds if hasattr(self, "email_i_ds") else None)!s}, '
                f'resourcegroup={(self.resourcegroup if hasattr(self, "resourcegroup") else None)!s}, '
                f'sample_io_tc_app={(self.sample_io_tc_app if hasattr(self, "sample_io_tc_app") else None)!s}, '
                f'subscription_id={(self.subscription_id if hasattr(self, "subscription_id") else None)!s}, '
                f'tenant_id={(self.tenant_id if hasattr(self, "tenant_id") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
