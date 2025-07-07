
# Filtercriteria

*This model accepts additional fields of type Any.*

## Structure

`Filtercriteria`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `filter_criteria` | [`List[ReadySimServicePlan]`](../../doc/models/ready-sim-service-plan.md) | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

