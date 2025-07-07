
# M 5G Biaccount Nameobject

*This model accepts additional fields of type Object.*

## Structure

`M5GBiaccountNameobject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Optional | - |
| `billing_cycle_end_date` | `String` | Optional | - |
| `carrier_information` | [`Array<M5GBiCarrierInformation>`](../../doc/models/m-5g-bi-carrier-information.md) | Optional | - |
| `connected` | `TrueClass \| FalseClass` | Optional | - |
| `created_at` | `String` | Optional | - |
| `custom_fields` | [`Array<M5GBikeyValue1>`](../../doc/models/m-5g-bikey-value-1.md) | Optional | - |
| `device_ids` | [`Array<M5GBideviceId1>`](../../doc/models/m-5g-bidevice-id-1.md) | Optional | - |
| `extended_attributes` | [`Array<M5GBikeyValue1>`](../../doc/models/m-5g-bikey-value-1.md) | Optional | - |
| `group_names` | [`Array<GroupName>`](../../doc/models/group-name.md) | Optional | - |
| `ipaddress` | `String` | Optional | - |
| `last_activation_by` | `String` | Optional | - |
| `last_activation_date` | `String` | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

