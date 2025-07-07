
# Gio Sms Message

*This model accepts additional fields of type Object.*

## Structure

`GioSmsMessage`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceIds` | [`List<GioDeviceId>`](../../doc/models/gio-device-id.md) | Optional | **Constraints**: *Maximum Items*: `100` | List<GioDeviceId> getDeviceIds() | setDeviceIds(List<GioDeviceId> deviceIds) |
| `Message` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `120`, *Pattern*: `^[A-Za-z0-9 ]{3,120}$` | String getMessage() | setMessage(String message) |
| `Timestamp` | `LocalDateTime` | Optional | - | LocalDateTime getTimestamp() | setTimestamp(LocalDateTime timestamp) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "message": "a text message",
  "deviceIds": [
    {
      "kind": "kind8",
      "id": "id0"
    }
  ],
  "timestamp": "2016-03-13T12:52:32.123Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

