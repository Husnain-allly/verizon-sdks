
# Search Sensor History Response List

A success response includes an array of all matching events.

*This model accepts additional fields of type unknown.*

## Structure

`SearchSensorHistoryResponseList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `searchSensorHistory` | [`SearchDeviceResponse[] \| undefined`](../../doc/models/search-device-response.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "SearchSensorHistory": [
    {
      "action": "action6",
      "createdon": "createdon6",
      "deviceid": "deviceid6",
      "fields": {
        "temperature": "temperature0",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "id": "id6",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "action": "action6",
      "createdon": "createdon6",
      "deviceid": "deviceid6",
      "fields": {
        "temperature": "temperature0",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "id": "id6",
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

