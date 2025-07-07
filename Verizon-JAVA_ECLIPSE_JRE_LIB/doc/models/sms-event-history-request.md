
# Sms Event History Request

## Structure

`SmsEventHistoryRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceId` | [`GioDeviceId`](../../doc/models/gio-device-id.md) | Required | - | GioDeviceId getDeviceId() | setDeviceId(GioDeviceId deviceId) |
| `Earliest` | `LocalDateTime` | Optional | - | LocalDateTime getEarliest() | setEarliest(LocalDateTime earliest) |
| `Latest` | `LocalDateTime` | Optional | - | LocalDateTime getLatest() | setLatest(LocalDateTime latest) |

## Example (as JSON)

```json
{
  "deviceId": {
    "kind": "eid",
    "id": "12345678901234567890123456789012"
  },
  "earliest": "2016-03-13T12:52:32.123Z",
  "latest": "2016-03-13T12:52:32.123Z"
}
```

