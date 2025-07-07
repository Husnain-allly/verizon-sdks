
# Sms Message

SMS messages sent by all M2M devices associated with a billing account.

*This model accepts additional fields of type Any.*

## Structure

`SmsMessage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_ids` | [`List[DeviceId]`](../../doc/models/device-id.md) | Optional | One or more IDs of the device that sent the message. |
| `message` | `str` | Optional | The contents of the SMS message. |
| `timestamp` | `str` | Optional | The date and time that the message was received by the Verizon ThingSpace Platform. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

