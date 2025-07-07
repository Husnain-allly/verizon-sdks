
# Search Device Event History Response List

A success response includes an array of all matching events.

*This model accepts additional fields of type array.*

## Structure

`SearchDeviceEventHistoryResponseList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `searchDeviceEventHistory` | [`?(SearchDeviceResponse[])`](../../doc/models/search-device-response.md) | Optional | **Constraints**: *Maximum Items*: `100` | getSearchDeviceEventHistory(): ?array | setSearchDeviceEventHistory(?array searchDeviceEventHistory): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

