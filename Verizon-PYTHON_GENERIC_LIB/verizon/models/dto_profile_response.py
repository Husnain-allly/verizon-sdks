# -*- coding: utf-8 -*-

"""
verizon

This file was automatically generated by APIMATIC v3.0 (
 https://www.apimatic.io ).
"""
from verizon.api_helper import APIHelper


class DtoProfileResponse(object):

    """Implementation of the 'dto.profileResponse' model.

    Attributes:
        id (str): The model property of type str.
        kind (str): the user defined profile kind
        version (str): The resource version
        versionid (str): The model property of type str.
        createdon (datetime): Timestamp of the record
        lastupdated (datetime): Timestamp of the record
        name (str): user defined profile name
        foreignid (str): UUID of the ECPD account the user belongs to
        billingaccountid (str): The billing account ID. This is the same value
            as the Account ID
        modelid (str): device model id
        configuration (Any): The model property of type Any.
        additional_properties (Dict[str, Any]): The additional properties for
            the model.

    """

    # Create a mapping from Model property names to API property names
    _names = {
        "id": 'id',
        "kind": 'kind',
        "version": 'version',
        "versionid": 'versionid',
        "createdon": 'createdon',
        "lastupdated": 'lastupdated',
        "name": 'name',
        "foreignid": 'foreignid',
        "billingaccountid": 'billingaccountid',
        "modelid": 'modelid',
        "configuration": 'configuration'
    }

    _optionals = [
        'id',
        'kind',
        'version',
        'versionid',
        'createdon',
        'lastupdated',
        'name',
        'foreignid',
        'billingaccountid',
        'modelid',
        'configuration',
    ]

    def __init__(self,
                 id=APIHelper.SKIP,
                 kind=APIHelper.SKIP,
                 version=APIHelper.SKIP,
                 versionid=APIHelper.SKIP,
                 createdon=APIHelper.SKIP,
                 lastupdated=APIHelper.SKIP,
                 name=APIHelper.SKIP,
                 foreignid=APIHelper.SKIP,
                 billingaccountid=APIHelper.SKIP,
                 modelid=APIHelper.SKIP,
                 configuration=APIHelper.SKIP,
                 additional_properties=None):
        """Constructor for the DtoProfileResponse class"""

        # Initialize members of the class
        if id is not APIHelper.SKIP:
            self.id = id 
        if kind is not APIHelper.SKIP:
            self.kind = kind 
        if version is not APIHelper.SKIP:
            self.version = version 
        if versionid is not APIHelper.SKIP:
            self.versionid = versionid 
        if createdon is not APIHelper.SKIP:
            self.createdon = APIHelper.apply_datetime_converter(createdon, APIHelper.RFC3339DateTime) if createdon else None 
        if lastupdated is not APIHelper.SKIP:
            self.lastupdated = APIHelper.apply_datetime_converter(lastupdated, APIHelper.RFC3339DateTime) if lastupdated else None 
        if name is not APIHelper.SKIP:
            self.name = name 
        if foreignid is not APIHelper.SKIP:
            self.foreignid = foreignid 
        if billingaccountid is not APIHelper.SKIP:
            self.billingaccountid = billingaccountid 
        if modelid is not APIHelper.SKIP:
            self.modelid = modelid 
        if configuration is not APIHelper.SKIP:
            self.configuration = configuration 

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
        id = dictionary.get("id") if dictionary.get("id") else APIHelper.SKIP
        kind = dictionary.get("kind") if dictionary.get("kind") else APIHelper.SKIP
        version = dictionary.get("version") if dictionary.get("version") else APIHelper.SKIP
        versionid = dictionary.get("versionid") if dictionary.get("versionid") else APIHelper.SKIP
        createdon = APIHelper.RFC3339DateTime.from_value(dictionary.get("createdon")).datetime if dictionary.get("createdon") else APIHelper.SKIP
        lastupdated = APIHelper.RFC3339DateTime.from_value(dictionary.get("lastupdated")).datetime if dictionary.get("lastupdated") else APIHelper.SKIP
        name = dictionary.get("name") if dictionary.get("name") else APIHelper.SKIP
        foreignid = dictionary.get("foreignid") if dictionary.get("foreignid") else APIHelper.SKIP
        billingaccountid = dictionary.get("billingaccountid") if dictionary.get("billingaccountid") else APIHelper.SKIP
        modelid = dictionary.get("modelid") if dictionary.get("modelid") else APIHelper.SKIP
        configuration = dictionary.get("configuration") if dictionary.get("configuration") else APIHelper.SKIP
        additional_properties = APIHelper.get_additional_properties(
            dictionary={k: v for k, v in dictionary.items() if k not in cls._names.values()},
            unboxing_function=lambda value: value)
        # Return an object of this model
        return cls(id,
                   kind,
                   version,
                   versionid,
                   createdon,
                   lastupdated,
                   name,
                   foreignid,
                   billingaccountid,
                   modelid,
                   configuration,
                   additional_properties)

    def __repr__(self):
        return (f'{self.__class__.__name__}('
                f'id={(self.id if hasattr(self, "id") else None)!r}, '
                f'kind={(self.kind if hasattr(self, "kind") else None)!r}, '
                f'version={(self.version if hasattr(self, "version") else None)!r}, '
                f'versionid={(self.versionid if hasattr(self, "versionid") else None)!r}, '
                f'createdon={(self.createdon if hasattr(self, "createdon") else None)!r}, '
                f'lastupdated={(self.lastupdated if hasattr(self, "lastupdated") else None)!r}, '
                f'name={(self.name if hasattr(self, "name") else None)!r}, '
                f'foreignid={(self.foreignid if hasattr(self, "foreignid") else None)!r}, '
                f'billingaccountid={(self.billingaccountid if hasattr(self, "billingaccountid") else None)!r}, '
                f'modelid={(self.modelid if hasattr(self, "modelid") else None)!r}, '
                f'configuration={(self.configuration if hasattr(self, "configuration") else None)!r}, '
                f'additional_properties={self.additional_properties!r})')

    def __str__(self):
        return (f'{self.__class__.__name__}('
                f'id={(self.id if hasattr(self, "id") else None)!s}, '
                f'kind={(self.kind if hasattr(self, "kind") else None)!s}, '
                f'version={(self.version if hasattr(self, "version") else None)!s}, '
                f'versionid={(self.versionid if hasattr(self, "versionid") else None)!s}, '
                f'createdon={(self.createdon if hasattr(self, "createdon") else None)!s}, '
                f'lastupdated={(self.lastupdated if hasattr(self, "lastupdated") else None)!s}, '
                f'name={(self.name if hasattr(self, "name") else None)!s}, '
                f'foreignid={(self.foreignid if hasattr(self, "foreignid") else None)!s}, '
                f'billingaccountid={(self.billingaccountid if hasattr(self, "billingaccountid") else None)!s}, '
                f'modelid={(self.modelid if hasattr(self, "modelid") else None)!s}, '
                f'configuration={(self.configuration if hasattr(self, "configuration") else None)!s}, '
                f'additional_properties={self.additional_properties!s})')
