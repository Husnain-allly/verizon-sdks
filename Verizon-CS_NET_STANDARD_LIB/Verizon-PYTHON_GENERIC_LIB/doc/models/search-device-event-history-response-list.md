
# Search Device Event History Response List

A success response includes an array of all matching events.

*This model accepts additional fields of type Any.*

## Structure

`SearchDeviceEventHistoryResponseList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `search_device_event_history` | [`List[SearchDeviceResponse]`](../../doc/models/search-device-response.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "SearchDeviceEventHistory": [
    {
      "action": "action4",
      "createdon": "createdon4",
      "deviceid": "deviceid8",
      "fields": {
        "temperature": "temperature0",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "id": "id8",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

