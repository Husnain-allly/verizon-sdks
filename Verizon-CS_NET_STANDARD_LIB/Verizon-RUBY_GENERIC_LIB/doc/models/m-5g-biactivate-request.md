
# M 5G Biactivate Request

*This model accepts additional fields of type Object.*

## Structure

`M5GBiactivateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Optional | - |
| `service_plan` | `String` | Optional | - |
| `device_list_with_service_address` | Array[[5gbideviceIdarray](../../doc/models/m-5g-bidevice-idarray.md) \| [5gbiaddressAndcustomerinfo](../../doc/models/m-5g-biaddress-andcustomerinfo.md)] \| nil | Optional | This is Array of a container for any-of cases. |
| `public_ip_restriction` | `String` | Optional | - |
| `carrier_name` | `String` | Optional | - |
| `mdn_zip_code` | `String` | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "servicePlan": "service plan name",
  "publicIpRestriction": "Unrestricted",
  "carrierName": "Verizon Wireless",
  "mdnZipCode": "5-digit zip code",
  "deviceListWithServiceAddress": [
    {
      "deviceId": [
        {
          "id": "id0",
          "kind": "kind8",
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
    },
    {
      "deviceId": [
        {
          "id": "id0",
          "kind": "kind8",
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
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

