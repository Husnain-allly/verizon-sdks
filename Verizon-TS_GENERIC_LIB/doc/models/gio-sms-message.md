
# Gio Sms Message

*This model accepts additional fields of type unknown.*

## Structure

`GioSmsMessage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deviceIds` | [`GioDeviceId[] \| undefined`](../../doc/models/gio-device-id.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `message` | `string \| undefined` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `120`, *Pattern*: `^[A-Za-z0-9 ]{3,120}$` |
| `timestamp` | `string \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

