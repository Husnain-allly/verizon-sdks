
# Filtercriteria 2

*This model accepts additional fields of type object.*

## Structure

`Filtercriteria2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FilterCriteria` | `object` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "filterCriteria": [
    {
      "key1": "val1",
      "key2": "val2"
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

