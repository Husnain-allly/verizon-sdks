
# Request Body for Usage

*This model accepts additional fields of type interface{}.*

## Structure

`RequestBodyForUsage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountId` | `*string` | Optional | - |
| `DeviceId` | [`[]models.ReadySimDeviceId`](../../doc/models/ready-sim-device-id.md) | Optional | - |
| `StartTime` | `*time.Time` | Optional | - |
| `EndTime` | `*time.Time` | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "accountId": "0000123456-000001",
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
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

