
# Response to Usage Query

*This model accepts additional fields of type Object.*

## Structure

`ResponseToUsageQuery`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Hasmoredata` | `Boolean` | Optional | - | Boolean getHasmoredata() | setHasmoredata(Boolean hasmoredata) |
| `DeviceId` | [`ReadySimDeviceId`](../../doc/models/ready-sim-device-id.md) | Optional | - | ReadySimDeviceId getDeviceId() | setDeviceId(ReadySimDeviceId deviceId) |
| `UsageHistory` | [`List<UsageHistory>`](../../doc/models/usage-history.md) | Optional | - | List<UsageHistory> getUsageHistory() | setUsageHistory(List<UsageHistory> usageHistory) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

