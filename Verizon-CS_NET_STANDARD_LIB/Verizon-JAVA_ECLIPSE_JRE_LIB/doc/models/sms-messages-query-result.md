
# Sms Messages Query Result

Response to SMS messages sent by all M2M devices associated with a billing account.

*This model accepts additional fields of type Object.*

## Structure

`SmsMessagesQueryResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `HasMoreData` | `Boolean` | Optional | False for a status 200 response.True for a status 202 response, indicating that there is more data to be retrieved. | Boolean getHasMoreData() | setHasMoreData(Boolean hasMoreData) |
| `Messages` | [`List<SmsMessage>`](../../doc/models/sms-message.md) | Optional | An array of up to 100 SMS messages that were sent by devices in the account. | List<SmsMessage> getMessages() | setMessages(List<SmsMessage> messages) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

