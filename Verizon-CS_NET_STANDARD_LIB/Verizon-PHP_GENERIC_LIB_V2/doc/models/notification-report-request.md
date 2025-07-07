
# Notification Report Request

*This model accepts additional fields of type array.*

## Structure

`NotificationReportRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `string` | Required | - | getAccountName(): string | setAccountName(string accountName): void |
| `requestType` | `string` | Required | - | getRequestType(): string | setRequestType(string requestType): void |
| `devices` | [`DeviceList[]`](../../doc/models/device-list.md) | Required | - | getDevices(): array | setDevices(array devices): void |
| `monitorExpirationTime` | `string` | Required | - | getMonitorExpirationTime(): string | setMonitorExpirationTime(string monitorExpirationTime): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "0242072320-00001",
  "requestType": "REACHABLE_FOR_DATA",
  "devices": [
    {
      "deviceIds": [
        {
          "id": "id0",
          "kind": "kind8",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ]
    }
  ],
  "monitorExpirationTime": "2019-12-02T15:00:00-08:00Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

