
# Connection Event

Network connection events for a device during a specified time period.

*This model accepts additional fields of type Object.*

## Structure

`ConnectionEvent`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ConnectionEventAttributes` | [`List<CustomFields>`](../../doc/models/custom-fields.md) | Optional | The attributes that describe the connection event. | List<CustomFields> getConnectionEventAttributes() | setConnectionEventAttributes(List<CustomFields> connectionEventAttributes) |
| `ExtendedAttributes` | [`List<CustomFields>`](../../doc/models/custom-fields.md) | Optional | Currently not used. | List<CustomFields> getExtendedAttributes() | setExtendedAttributes(List<CustomFields> extendedAttributes) |
| `OccurredAt` | `String` | Optional | The date and time when the connection event occured. | String getOccurredAt() | setOccurredAt(String occurredAt) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

