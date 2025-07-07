
# Filtercriteria

*This model accepts additional fields of type interface{}.*

## Structure

`Filtercriteria`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FilterCriteria` | [`[]models.ReadySimServicePlan`](../../doc/models/ready-sim-service-plan.md) | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

