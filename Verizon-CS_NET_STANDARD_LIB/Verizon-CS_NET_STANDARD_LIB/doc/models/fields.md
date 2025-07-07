
# Fields

List of fields affected by the event.

*This model accepts additional fields of type object.*

## Structure

`Fields`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Configuration` | [`Configuration`](../../doc/models/configuration.md) | Optional | List of the field names and values to set. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

