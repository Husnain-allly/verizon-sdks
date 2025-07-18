
# M 5G Biaccount Nameobject

*This model accepts additional fields of type Any.*

## Structure

`M5GBiaccountNameobject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Optional | - |
| `billing_cycle_end_date` | `str` | Optional | - |
| `carrier_information` | [`List[M5GBiCarrierInformation]`](../../doc/models/m-5g-bi-carrier-information.md) | Optional | - |
| `connected` | `bool` | Optional | - |
| `created_at` | `str` | Optional | - |
| `custom_fields` | [`List[M5GBikeyValue1]`](../../doc/models/m-5g-bikey-value-1.md) | Optional | - |
| `device_ids` | [`List[M5GBideviceId1]`](../../doc/models/m-5g-bidevice-id-1.md) | Optional | - |
| `extended_attributes` | [`List[M5GBikeyValue1]`](../../doc/models/m-5g-bikey-value-1.md) | Optional | - |
| `group_names` | [`List[GroupName]`](../../doc/models/group-name.md) | Optional | - |
| `ipaddress` | `str` | Optional | - |
| `last_activation_by` | `str` | Optional | - |
| `last_activation_date` | `str` | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

