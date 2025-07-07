
# Sms Messages Response

## Structure

`SmsMessagesResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Messages` | [`List<GioSmsMessage>`](../../doc/models/gio-sms-message.md) | Optional | **Constraints**: *Maximum Items*: `5` | List<GioSmsMessage> getMessages() | setMessages(List<GioSmsMessage> messages) |
| `HasMoreData` | `Boolean` | Optional | - | Boolean getHasMoreData() | setHasMoreData(Boolean hasMoreData) |

## Example (as JSON)

```json
{
  "hasMoreData": false,
  "messages": [
    {
      "deviceIds": [
        {
          "kind": "kind8",
          "id": "id0"
        },
        {
          "kind": "kind8",
          "id": "id0"
        }
      ],
      "message": "message8",
      "timestamp": "2016-03-13T12:52:32.123Z",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "deviceIds": [
        {
          "kind": "kind8",
          "id": "id0"
        },
        {
          "kind": "kind8",
          "id": "id0"
        }
      ],
      "message": "message8",
      "timestamp": "2016-03-13T12:52:32.123Z",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ]
}
```

