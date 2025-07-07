
# Aggregate Usage

*This model accepts additional fields of type array.*

## Structure

`AggregateUsage`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceId` | [`?GioDeviceId`](../../doc/models/gio-device-id.md) | Optional | - | getDeviceId(): ?GioDeviceId | setDeviceId(?GioDeviceId deviceId): void |
| `accountName` | `?string` | Optional | The numeric name of the account, in the format "0000123456-00001". Leading zeros must be included.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | getAccountName(): ?string | setAccountName(?string accountName): void |
| `startTime` | `?string` | Optional | The start date of the time period queried as "$datetime"<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | getStartTime(): ?string | setStartTime(?string startTime): void |
| `endTime` | `?string` | Optional | The end date of the time period being queried as "$datetime"<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | getEndTime(): ?string | setEndTime(?string endTime): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "deviceId": {
    "kind": "kind8",
    "id": "id0"
  },
  "accountName": "accountName6",
  "startTime": "startTime8",
  "endTime": "endTime4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

