
# Fields

List of fields affected by the event.

*This model accepts additional fields of type Object.*

## Structure

`Fields`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Configuration` | [`Configuration`](../../doc/models/configuration.md) | Optional | List of the field names and values to set. | Configuration getConfiguration() | setConfiguration(Configuration configuration) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "configuration": {
    "frequency": "Low",
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

