
# Request Body for Usage

*This model accepts additional fields of type array.*

## Structure

`RequestBodyForUsage`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountId` | `?string` | Optional | - | getAccountId(): ?string | setAccountId(?string accountId): void |
| `deviceId` | [`?(ReadySimDeviceId[])`](../../doc/models/ready-sim-device-id.md) | Optional | - | getDeviceId(): ?array | setDeviceId(?array deviceId): void |
| `startTime` | `?DateTime` | Optional | - | getStartTime(): ?\DateTime | setStartTime(?\DateTime startTime): void |
| `endTime` | `?DateTime` | Optional | - | getEndTime(): ?\DateTime | setEndTime(?\DateTime endTime): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

