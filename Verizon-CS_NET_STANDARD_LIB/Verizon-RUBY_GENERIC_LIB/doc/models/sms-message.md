
# Sms Message

SMS messages sent by all M2M devices associated with a billing account.

*This model accepts additional fields of type Object.*

## Structure

`SmsMessage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_ids` | [`Array<DeviceId>`](../../doc/models/device-id.md) | Optional | One or more IDs of the device that sent the message. |
| `message` | `String` | Optional | The contents of the SMS message. |
| `timestamp` | `String` | Optional | The date and time that the message was received by the Verizon ThingSpace Platform. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "deviceIds": [
    {
      "id": "09623489171",
      "kind": "esn",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "message": "testmessage1",
  "timestamp": "2016-01-01T12:29:49-08:00",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

