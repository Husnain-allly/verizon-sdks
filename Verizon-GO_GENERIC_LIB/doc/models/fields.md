
# Fields

List of fields affected by the event.

*This model accepts additional fields of type interface{}.*

## Structure

`Fields`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Configuration` | [`*models.Configuration`](../../doc/models/configuration.md) | Optional | List of the field names and values to set. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

