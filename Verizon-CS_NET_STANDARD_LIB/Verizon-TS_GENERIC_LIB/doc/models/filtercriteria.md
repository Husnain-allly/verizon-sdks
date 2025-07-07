
# Filtercriteria

*This model accepts additional fields of type unknown.*

## Structure

`Filtercriteria`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `filterCriteria` | [`ReadySimServicePlan[] \| undefined`](../../doc/models/ready-sim-service-plan.md) | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

