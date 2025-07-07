
# Fields 2

List of fields affected by the event.

*This model accepts additional fields of type Object.*

## Structure

`Fields2`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Temperature` | `String` | Optional | - | String getTemperature() | setTemperature(String temperature) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "temperature": "18.4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

