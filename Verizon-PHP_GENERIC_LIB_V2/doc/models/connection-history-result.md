
# Connection History Result

Response containing the connection history. It is a list of Network Connection Events for a device.

*This model accepts additional fields of type array.*

## Structure

`ConnectionHistoryResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `connectionHistory` | [`?(ConnectionEvent[])`](../../doc/models/connection-event.md) | Optional | Device connection events, sorted by the occurredAt timestamp, oldest first. | getConnectionHistory(): ?array | setConnectionHistory(?array connectionHistory): void |
| `hasMoreData` | `?bool` | Optional | False for a status 200 response.True for a status 202 response, indicating that there is more data to be retrieved. Send another request, adjusting the earliest value in the request based on the occuredAt value for the last device in the current response. | getHasMoreData(): ?bool | setHasMoreData(?bool hasMoreData): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "connectionHistory": [
    {
      "connectionEventAttributes": [
        {
          "key": "BytesUsed",
          "value": "0",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "key": "Event",
          "value": "Start",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ],
      "extendedAttributes": [],
      "occurredAt": "2015-12-17T14:12:36-05:00",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "connectionEventAttributes": [
        {
          "key": "BytesUsed",
          "value": "419863234",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "key": "Event",
          "value": "Stop",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "key": "Msisdn",
          "value": "15086303371",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ],
      "extendedAttributes": [],
      "occurredAt": "2015-12-19T01:20:00-05:00",
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

