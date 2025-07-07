
# Data Percentage 75 Trigger Attribute

Trigger attribute for when data percentage is over 75% used.

*This model accepts additional fields of type interface{}.*

## Structure

`DataPercentage75TriggerAttribute`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Key` | `*string` | Optional | Key data percentage 75. |
| `Value` | `*bool` | Optional | DataPercentage75<br />True - Trigger on Data percentage is over 75% used<br />False - Do not trigger when over 75% used. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "key": "DataPercentage75",
  "value": false,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

