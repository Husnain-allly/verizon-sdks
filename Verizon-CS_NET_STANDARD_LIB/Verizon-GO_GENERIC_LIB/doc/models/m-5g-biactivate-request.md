
# M 5G Biactivate Request

*This model accepts additional fields of type interface{}.*

## Structure

`M5GBiactivateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `*string` | Optional | - |
| `ServicePlan` | `*string` | Optional | - |
| `DeviceListWithServiceAddress` | [`[]models.M5GBiactivateRequestDeviceListWithServiceAddress`](../../doc/models/containers/m-5g-biactivate-request-device-list-with-service-address.md) | Optional | This is Array of a container for any-of cases. |
| `PublicIpRestriction` | `*string` | Optional | - |
| `CarrierName` | `*string` | Optional | - |
| `MdnZipCode` | `*string` | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

