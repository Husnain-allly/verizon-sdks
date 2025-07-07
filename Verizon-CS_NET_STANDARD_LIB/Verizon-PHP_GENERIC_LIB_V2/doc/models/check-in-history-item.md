
# Check in History Item

Check-in history for a device.

*This model accepts additional fields of type array.*

## Structure

`CheckInHistoryItem`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceId` | `string` | Required | Device IMEI. | getDeviceId(): string | setDeviceId(string deviceId): void |
| `clientType` | `string` | Required | Type of client. | getClientType(): string | setClientType(string clientType): void |
| `result` | `string` | Required | - | getResult(): string | setResult(string result): void |
| `failureType` | `string` | Required | - | getFailureType(): string | setFailureType(string failureType): void |
| `timeCompleted` | `DateTime` | Required | - | getTimeCompleted(): \DateTime | setTimeCompleted(\DateTime timeCompleted): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "deviceId": "990013907835573",
  "clientType": "clientType6",
  "result": "result8",
  "failureType": "failureType8",
  "timeCompleted": "10/22/2020 19:35:07",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

