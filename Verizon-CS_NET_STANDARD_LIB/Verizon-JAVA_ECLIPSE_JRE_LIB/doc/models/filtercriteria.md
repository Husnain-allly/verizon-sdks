
# Filtercriteria

*This model accepts additional fields of type Object.*

## Structure

`Filtercriteria`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `FilterCriteria` | [`List<ReadySimServicePlan>`](../../doc/models/ready-sim-service-plan.md) | Optional | - | List<ReadySimServicePlan> getFilterCriteria() | setFilterCriteria(List<ReadySimServicePlan> filterCriteria) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "filterCriteria": [
    {
      "servicePlan": "servicePlan4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

