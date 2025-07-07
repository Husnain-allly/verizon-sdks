
# Esim Profile Request

## Structure

`EsimProfileRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `devices` | [`Array<EsimDeviceList>`](../../doc/models/esim-device-list.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `carrier_name` | `String` | Optional | - |
| `account_name` | `String` | Optional | - |
| `service_plan` | `String` | Optional | - |
| `mdn_zip_code` | `String` | Optional | - |

## Example (as JSON)

```json
{
  "carrierName": "name of the mobile service provider",
  "accountName": "0000123456-00001",
  "servicePlan": "The service plan name (The value used for Consumer eSIM for Enterprise will be HybridESim)",
  "mdnZipCode": "five digit zip code",
  "devices": [
    {
      "deviceIds": [
        {
          "id": "id4",
          "kind": "kind2",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ]
    },
    {
      "deviceIds": [
        {
          "id": "id4",
          "kind": "kind2",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ]
    },
    {
      "deviceIds": [
        {
          "id": "id4",
          "kind": "kind2",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ]
    }
  ]
}
```

