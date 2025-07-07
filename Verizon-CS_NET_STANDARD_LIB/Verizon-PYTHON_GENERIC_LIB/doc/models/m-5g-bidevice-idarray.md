
# M 5G Bidevice Idarray

*This model accepts additional fields of type Any.*

## Structure

`M5GBideviceIdarray`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_id` | List[[5gbideviceId1](../../doc/models/m-5g-bidevice-id-1.md)] \| None | Optional | This is List of a container for any-of cases. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
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
```

