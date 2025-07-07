
# Service Plan Trigger Attribute

Key service plan trigger attribute.

*This model accepts additional fields of type unknown.*

## Structure

`ServicePlanTriggerAttribute`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `key` | `string \| undefined` | Optional | The ServicePlan name will be listed here. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

