
# Sms Messages Query Result

Response to SMS messages sent by all M2M devices associated with a billing account.

*This model accepts additional fields of type Any.*

## Structure

`SmsMessagesQueryResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `has_more_data` | `bool` | Optional | False for a status 200 response.True for a status 202 response, indicating that there is more data to be retrieved. |
| `messages` | [`List[SmsMessage]`](../../doc/models/sms-message.md) | Optional | An array of up to 100 SMS messages that were sent by devices in the account. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "messages": [
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
    },
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
      "message": "testmessage2",
      "timestamp": "2016-01-01T12:31:02-08:00",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "hasMoreData": false,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

