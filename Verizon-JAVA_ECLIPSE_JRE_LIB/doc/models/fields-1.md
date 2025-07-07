
# Fields 1

*This model accepts additional fields of type Object.*

## Structure

`Fields1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Item` | [`SearchDeviceByPropertyFields`](../../doc/models/search-device-by-property-fields.md) | Optional | List of device sensors and their most recently reported values. | SearchDeviceByPropertyFields getItem() | setItem(SearchDeviceByPropertyFields item) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "item": {
    "acceleration": {
      "x": "x6",
      "y": "y4",
      "z": "z6",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "battery": "battery0",
    "humidity": "humidity4",
    "light": "light6",
    "pressure": "pressure2",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

