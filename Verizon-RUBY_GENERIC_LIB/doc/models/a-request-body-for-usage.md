
# A Request Body for Usage

*This model accepts additional fields of type Object.*

## Structure

`ARequestBodyForUsage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_id` | [`Array<ReadySimDeviceId>`](../../doc/models/ready-sim-device-id.md) | Optional | - |
| `start_time` | `DateTime` | Optional | - |
| `end_time` | `DateTime` | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "startTime": "08/15/2021 00:00:00",
  "endTime": "08/16/2021 00:00:00",
  "deviceId": [
    {
      "kind": "kind8",
      "id": "id0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "kind": "kind8",
      "id": "id0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "kind": "kind8",
      "id": "id0",
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

