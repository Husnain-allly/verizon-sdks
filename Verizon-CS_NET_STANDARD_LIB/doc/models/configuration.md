
# Configuration

List of the field names and values to set.

*This model accepts additional fields of type object.*

## Structure

`Configuration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Frequency` | `string` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "frequency": "Low",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

