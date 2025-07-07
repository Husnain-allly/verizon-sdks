
# Filtercriteria 2

*This model accepts additional fields of type Object.*

## Structure

`Filtercriteria2`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `FilterCriteria` | `List<Object>` | Optional | - | List<Object> getFilterCriteria() | setFilterCriteria(List<Object> filterCriteria) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

