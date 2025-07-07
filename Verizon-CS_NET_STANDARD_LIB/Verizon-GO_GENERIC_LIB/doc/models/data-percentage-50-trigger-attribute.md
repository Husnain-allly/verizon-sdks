
# Data Percentage 50 Trigger Attribute

Trigger attribute for when data percentage is over 50% used.

*This model accepts additional fields of type interface{}.*

## Structure

`DataPercentage50TriggerAttribute`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Key` | `*string` | Optional | Key data percentage 50. |
| `Value` | `*bool` | Optional | DataPercentage50<br />True - Trigger on Data percentage is over 50% used<br />False - Do not trigger when over 50% used. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "key": "DataPercentage50",
  "value": false,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

