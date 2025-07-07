
# M 5G Biaccount Nameobject

*This model accepts additional fields of type object.*

## Structure

`M5GBiaccountNameobject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | - |
| `BillingCycleEndDate` | `string` | Optional | - |
| `CarrierInformation` | [`List<M5GBiCarrierInformation>`](../../doc/models/m-5g-bi-carrier-information.md) | Optional | - |
| `Connected` | `bool?` | Optional | - |
| `CreatedAt` | `string` | Optional | - |
| `CustomFields` | [`List<M5GBiaccountNameobjectCustomFields>`](../../doc/models/containers/m-5g-biaccount-nameobject-custom-fields.md) | Optional | This is List of a container for any-of cases. |
| `DeviceIds` | [`List<M5GBiaccountNameobjectDeviceIds>`](../../doc/models/containers/m-5g-biaccount-nameobject-device-ids.md) | Optional | This is List of a container for any-of cases. |
| `ExtendedAttributes` | [`List<M5GBiaccountNameobjectExtendedAttributes>`](../../doc/models/containers/m-5g-biaccount-nameobject-extended-attributes.md) | Optional | This is List of a container for any-of cases. |
| `GroupNames` | [`List<GroupName>`](../../doc/models/group-name.md) | Optional | - |
| `Ipaddress` | `string` | Optional | - |
| `LastActivationBy` | `string` | Optional | - |
| `LastActivationDate` | `string` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "billingCycleEndDate": "11/10/2022 00:00:00",
  "connected": false,
  "createdAt": "10/20/2022 18:23:41",
  "ipAddress": "0.0.0.0",
  "lastActivationBy": "User Name",
  "lastActivationDate": "2022-11-02 T21:36:18Z",
  "carrierInformation": [
    {
      "carrierName": "carrierName4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "carrierName": "carrierName4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "carrierName": "carrierName4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

