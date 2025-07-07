
# Connection Event

Network connection events for a device during a specified time period.

*This model accepts additional fields of type interface{}.*

## Structure

`ConnectionEvent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ConnectionEventAttributes` | [`[]models.CustomFields`](../../doc/models/custom-fields.md) | Optional | The attributes that describe the connection event. |
| `ExtendedAttributes` | [`[]models.CustomFields`](../../doc/models/custom-fields.md) | Optional | Currently not used. |
| `OccurredAt` | `*string` | Optional | The date and time when the connection event occured. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
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
}
```

