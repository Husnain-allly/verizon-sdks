
# Service Plan Trigger Attribute

Key service plan trigger attribute.

*This model accepts additional fields of type object.*

## Structure

`ServicePlanTriggerAttribute`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Key` | `string` | Optional | The ServicePlan name will be listed here. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "key": "ServicePlan",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

