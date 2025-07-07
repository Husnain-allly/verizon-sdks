
# Response to Usage Query

*This model accepts additional fields of type array.*

## Structure

`ResponseToUsageQuery`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `hasmoredata` | `?bool` | Optional | - | getHasmoredata(): ?bool | setHasmoredata(?bool hasmoredata): void |
| `deviceId` | [`?ReadySimDeviceId`](../../doc/models/ready-sim-device-id.md) | Optional | - | getDeviceId(): ?ReadySimDeviceId | setDeviceId(?ReadySimDeviceId deviceId): void |
| `usageHistory` | [`?(UsageHistory[])`](../../doc/models/usage-history.md) | Optional | - | getUsageHistory(): ?array | setUsageHistory(?array usageHistory): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

