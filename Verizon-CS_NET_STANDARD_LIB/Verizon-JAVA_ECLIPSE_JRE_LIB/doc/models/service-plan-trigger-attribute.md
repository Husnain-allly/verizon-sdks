
# Service Plan Trigger Attribute

Key service plan trigger attribute.

*This model accepts additional fields of type Object.*

## Structure

`ServicePlanTriggerAttribute`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Key` | `String` | Optional | The ServicePlan name will be listed here. | String getKey() | setKey(String key) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

