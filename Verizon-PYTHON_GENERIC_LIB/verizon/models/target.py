# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper


class Target(object):

    """Implementation of the 'Target' model.

    Target resource definition.

    Attributes:
        address (str): The endpoint for data streams.
        addressscheme (str): The transport format.
        billingaccountid (str): The billing account ID.
        createdon (str): The date the resource was created.
        externalid (str): Security identification string.
        id (str): ThingSpace unique ID for the target that was created.
        kind (str): Identifies the resource kind. Targets are ts.target.
        lastupdated (str): The date the resource was last updated.
        name (str): Name of the target.
        region (str): AWS region value.
        version (str): Version of the underlying schema resource.
        versionid (str): The version of the resource.
        description (str): Description of the target.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "address": 'address',
        "addressscheme": 'addressscheme',
        "billingaccountid": 'billingaccountid',
        "createdon": 'createdon',
        "externalid": 'externalid',
        "id": 'id',
        "kind": 'kind',
        "lastupdated": 'lastupdated',
        "name": 'name',
        "region": 'region',
        "version": 'version',
        "versionid": 'versionid',
        "description": 'description'
    }

    _optionals = [
        'address',
        'addressscheme',
        'billingaccountid',
        'createdon',
        'externalid',
        'id',
        'kind',
        'lastupdated',
        'name',
        'region',
        'version',
        'versionid',
        'description',
    ]

    def __init__(self,
                 address=APIHelper.SKIP,
                 addressscheme=APIHelper.SKIP,
                 billingaccountid=APIHelper.SKIP,
                 createdon=APIHelper.SKIP,
                 externalid=APIHelper.SKIP,
                 id=APIHelper.SKIP,
                 kind=APIHelper.SKIP,
                 lastupdated=APIHelper.SKIP,
                 name=APIHelper.SKIP,
                 region=APIHelper.SKIP,
                 version=APIHelper.SKIP,
                 versionid=APIHelper.SKIP,
                 description=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the Target class"""

        # Initialize members of the class
        if address is not APIHelper.SKIP:
            self.address = address 
        if addressscheme is not APIHelper.SKIP:
            self.addressscheme = addressscheme 
        if billingaccountid is not APIHelper.SKIP:
            self.billingaccountid = billingaccountid 
        if createdon is not APIHelper.SKIP:
            self.createdon = createdon 
        if externalid is not APIHelper.SKIP:
            self.externalid = externalid 
        if id is not APIHelper.SKIP:
            self.id = id 
        if kind is not APIHelper.SKIP:
            self.kind = kind 
        if lastupdated is not APIHelper.SKIP:
            self.lastupdated = lastupdated 
        if name is not APIHelper.SKIP:
            self.name = name 
        if region is not APIHelper.SKIP:
            self.region = region 
        if version is not APIHelper.SKIP:
            self.version = version 
        if versionid is not APIHelper.SKIP:
            self.versionid = versionid 
        if description is not APIHelper.SKIP:
            self.description = description 

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
        address = dictionary.get("address") if dictionary.get("address") else APIHelper.SKIP
        addressscheme = dictionary.get("addressscheme") if dictionary.get("addressscheme") else APIHelper.SKIP
        billingaccountid = dictionary.get("billingaccountid") if dictionary.get("billingaccountid") else APIHelper.SKIP
        createdon = dictionary.get("createdon") if dictionary.get("createdon") else APIHelper.SKIP
        externalid = dictionary.get("externalid") if dictionary.get("externalid") else APIHelper.SKIP
        id = dictionary.get("id") if dictionary.get("id") else APIHelper.SKIP
        kind = dictionary.get("kind") if dictionary.get("kind") else APIHelper.SKIP
        lastupdated = dictionary.get("lastupdated") if dictionary.get("lastupdated") else APIHelper.SKIP
        name = dictionary.get("name") if dictionary.get("name") else APIHelper.SKIP
        region = dictionary.get("region") if dictionary.get("region") else APIHelper.SKIP
        version = dictionary.get("version") if dictionary.get("version") else APIHelper.SKIP
        versionid = dictionary.get("versionid") if dictionary.get("versionid") else APIHelper.SKIP
        description = dictionary.get("description") if dictionary.get("description") else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(address,
                   addressscheme,
                   billingaccountid,
                   createdon,
                   externalid,
                   id,
                   kind,
                   lastupdated,
                   name,
                   region,
                   version,
                   versionid,
                   description,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'address={(self.address if hasattr(self, "address") else None)!r}, '
                f'addressscheme={(self.addressscheme if hasattr(self, "addressscheme") else None)!r}, '
                f'billingaccountid={(self.billingaccountid if hasattr(self, "billingaccountid") else None)!r}, '
                f'createdon={(self.createdon if hasattr(self, "createdon") else None)!r}, '
                f'externalid={(self.externalid if hasattr(self, "externalid") else None)!r}, '
                f'id={(self.id if hasattr(self, "id") else None)!r}, '
                f'kind={(self.kind if hasattr(self, "kind") else None)!r}, '
                f'lastupdated={(self.lastupdated if hasattr(self, "lastupdated") else None)!r}, '
                f'name={(self.name if hasattr(self, "name") else None)!r}, '
                f'region={(self.region if hasattr(self, "region") else None)!r}, '
                f'version={(self.version if hasattr(self, "version") else None)!r}, '
                f'versionid={(self.versionid if hasattr(self, "versionid") else None)!r}, '
                f'description={(self.description if hasattr(self, "description") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'address={(self.address if hasattr(self, "address") else None)!s}, '
                f'addressscheme={(self.addressscheme if hasattr(self, "addressscheme") else None)!s}, '
                f'billingaccountid={(self.billingaccountid if hasattr(self, "billingaccountid") else None)!s}, '
                f'createdon={(self.createdon if hasattr(self, "createdon") else None)!s}, '
                f'externalid={(self.externalid if hasattr(self, "externalid") else None)!s}, '
                f'id={(self.id if hasattr(self, "id") else None)!s}, '
                f'kind={(self.kind if hasattr(self, "kind") else None)!s}, '
                f'lastupdated={(self.lastupdated if hasattr(self, "lastupdated") else None)!s}, '
                f'name={(self.name if hasattr(self, "name") else None)!s}, '
                f'region={(self.region if hasattr(self, "region") else None)!s}, '
                f'version={(self.version if hasattr(self, "version") else None)!s}, '
                f'versionid={(self.versionid if hasattr(self, "versionid") else None)!s}, '
                f'description={(self.description if hasattr(self, "description") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
