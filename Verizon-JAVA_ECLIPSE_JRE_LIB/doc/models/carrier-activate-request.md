
# Carrier Activate Request

Request for carrier activation.

*This model accepts additional fields of type Object.*

## Structure

`CarrierActivateRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Devices` | [`List<AccountDeviceList>`](../../doc/models/account-device-list.md) | Required | Up to 10,000 devices for which you want to activate service, specified by device identifier. | List<AccountDeviceList> getDevices() | setDevices(List<AccountDeviceList> devices) |
| `ServicePlan` | `String` | Required | The service plan code that you want to assign to all specified devices. | String getServicePlan() | setServicePlan(String servicePlan) |
| `MdnZipCode` | `String` | Required | The Zip code of the location where the line of service will primarily be used, or a Zip code that you have been told to use with these devices. For accounts that are configured for geographic numbering, this is the ZIP code from which the MDN will be derived. | String getMdnZipCode() | setMdnZipCode(String mdnZipCode) |
| `AccountName` | `String` | Optional | The name of a billing account. | String getAccountName() | setAccountName(String accountName) |
| `CarrierIpPoolName` | `String` | Optional | The private IP pool (Carrier Group Name) from which your device IP addresses will be derived. | String getCarrierIpPoolName() | setCarrierIpPoolName(String carrierIpPoolName) |
| `CarrierName` | `String` | Optional | The carrier that will perform the activation. | String getCarrierName() | setCarrierName(String carrierName) |
| `CostCenterCode` | `String` | Optional | A string to identify the cost center that the device is associated with. | String getCostCenterCode() | setCostCenterCode(String costCenterCode) |
| `CustomFields` | [`List<CustomFields>`](../../doc/models/custom-fields.md) | Optional | A user-defined descriptive field, limited to 50 characters. | List<CustomFields> getCustomFields() | setCustomFields(List<CustomFields> customFields) |
| `GroupName` | `String` | Optional | If you specify devices by ID in the devices parameters, this is the name of a device group that the devices should be added to.If you don't specify individual devices with the devices parameter, you can provide the name of a device group to activate all devices in that group. | String getGroupName() | setGroupName(String groupName) |
| `LeadId` | `String` | Optional | The ID of a “Qualified” or “Closed - Won” VPP customer lead, which is used with other values to determine MDN assignment, taxation, and compensation. | String getLeadId() | setLeadId(String leadId) |
| `PrimaryPlaceOfUse` | [`PlaceOfUse`](../../doc/models/place-of-use.md) | Optional | The customer name and the address of the device's primary place of use. Leave these fields empty to use the account profile address as the primary place of use. These values will be applied to all devices in the request.If the account is enabled for non-geographic MDNs and the device supports it, the primaryPlaceOfUse address will also be used to derive the MDN for the device. | PlaceOfUse getPrimaryPlaceOfUse() | setPrimaryPlaceOfUse(PlaceOfUse primaryPlaceOfUse) |
| `PublicIpRestriction` | `String` | Optional | For devices with static IP addresses on the public network, this specifies whether the devices have general access to the Internet. | String getPublicIpRestriction() | setPublicIpRestriction(String publicIpRestriction) |
| `SkuNumber` | `String` | Optional | The Stock Keeping Unit (SKU) of a 4G device type can be used with ICCID device identifiers in lieu of an IMEI when activating 4G devices. The SkuNumber will be used with all devices in the request, so all devices must be of the same type. | String getSkuNumber() | setSkuNumber(String skuNumber) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "devices": [
    {
      "deviceIds": [
        {
          "kind": "imei",
          "id": "990013907835573",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "kind": "iccid",
          "id": "89141390780800784259",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ],
      "ipAddress": "ipAddress4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "deviceIds": [
        {
          "kind": "imei",
          "id": "990013907884259",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "kind": "iccid",
          "id": "89141390780800735573",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ],
      "ipAddress": "ipAddress4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "accountName": "0868924207-00001",
  "servicePlan": "m2m_4G",
  "mdnZipCode": "98801",
  "customFields": [
    {
      "key": "CustomField2",
      "value": "SuperVend",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "groupName": "4G West",
  "primaryPlaceOfUse": {
    "customerName": {
      "title": "President",
      "firstName": "Zaffod",
      "lastName": "Beeblebrox"
    },
    "address": {
      "addressLine1": "1600 Pennsylvania Ave NW",
      "city": "Washington",
      "state": "DC",
      "zip": "20500",
      "country": "USA"
    }
  },
  "carrierIpPoolName": "carrierIpPoolName8",
  "carrierName": "carrierName2",
  "costCenterCode": "costCenterCode0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

