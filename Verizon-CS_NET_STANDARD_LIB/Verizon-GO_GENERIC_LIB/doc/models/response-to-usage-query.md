
# Response to Usage Query

*This model accepts additional fields of type interface{}.*

## Structure

`ResponseToUsageQuery`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Hasmoredata` | `*bool` | Optional | - |
| `DeviceId` | [`*models.ReadySimDeviceId`](../../doc/models/ready-sim-device-id.md) | Optional | - |
| `UsageHistory` | [`[]models.UsageHistory`](../../doc/models/usage-history.md) | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "hasmoredata": false,
  "deviceId": {
    "kind": "kind8",
    "id": "id0",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "usageHistory": [
    {
      "bytesUsed": 76,
      "serviceplan": "serviceplan2",
      "smsUsed": 176,
      "moSMS": 230,
      "mtSMS": 18,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "bytesUsed": 76,
      "serviceplan": "serviceplan2",
      "smsUsed": 176,
      "moSMS": 230,
      "mtSMS": 18,
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

