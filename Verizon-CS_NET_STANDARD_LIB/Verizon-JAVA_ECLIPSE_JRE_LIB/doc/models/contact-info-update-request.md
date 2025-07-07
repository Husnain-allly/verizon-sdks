
# Contact Info Update Request

Request to update contact information.

*This model accepts additional fields of type Object.*

## Structure

`ContactInfoUpdateRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `PrimaryPlaceOfUse` | [`PlaceOfUse`](../../doc/models/place-of-use.md) | Required | The customer name and the address of the device's primary place of use. Leave these fields empty to use the account profile address as the primary place of use. These values will be applied to all devices in the request.If the account is enabled for non-geographic MDNs and the device supports it, the primaryPlaceOfUse address will also be used to derive the MDN for the device. | PlaceOfUse getPrimaryPlaceOfUse() | setPrimaryPlaceOfUse(PlaceOfUse primaryPlaceOfUse) |
| `AccountName` | `String` | Optional | The name of the billing account that the devices belong to. An account name is usually numeric, and must include any leading zeros. | String getAccountName() | setAccountName(String accountName) |
| `Devices` | [`List<AccountDeviceList>`](../../doc/models/account-device-list.md) | Optional | A list of the devices that you want to change, specified by device identifier. You only need to provide one identifier per device. Do not include accountName, groupName, customFields, or servicePlan if you use this parameter. | List<AccountDeviceList> getDevices() | setDevices(List<AccountDeviceList> devices) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "devices": [
    {
      "deviceIds": [
        {
          "kind": "ESN",
          "id": "19110173057",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "kind": "ESN",
          "id": "19110173057",
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
  "accountName": "0212345678-00001",
  "primaryPlaceOfUse": {
    "address": {
      "addressLine1": "9868 Scranton Rd",
      "addressLine2": "Suite A",
      "city": "San Diego",
      "state": "CA",
      "country": "USA",
      "zip": "92121",
      "zip4": "0001",
      "phone": "1234567890",
      "phoneType": "H",
      "emailAddress": "zaffod@theinternet.com",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "customerName": {
      "firstName": "Zaffod",
      "lastName": "Beeblebrox",
      "middleName": "P",
      "title": "President",
      "suffix": "I",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

