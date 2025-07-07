
# Esim Profile Request 2

## Structure

`EsimProfileRequest2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Devices` | [`List<EsimDeviceList>`](../../doc/models/esim-device-list.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `AccountName` | `string` | Optional | - |
| `ServicePlan` | `string` | Optional | - |
| `MdnZipCode` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "servicePlan": "The service plan name",
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
    }
  ]
}
```

