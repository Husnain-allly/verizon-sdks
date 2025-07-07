
# Data Percentage 90 Trigger Attribute

Trigger attribute for when data percentage is over 90% used.

*This model accepts additional fields of type Object.*

## Structure

`DataPercentage90TriggerAttribute`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `key` | `String` | Optional | Key data percentage 90. |
| `value` | `TrueClass \| FalseClass` | Optional | DataPercentage90<br />True - Trigger on Data percentage is over 90% used<br />False - Do not trigger when over 90% used. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "key": "DataPercentage90",
  "value": false,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

