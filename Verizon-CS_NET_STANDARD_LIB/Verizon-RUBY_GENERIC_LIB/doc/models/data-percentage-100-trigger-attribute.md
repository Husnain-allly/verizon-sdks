
# Data Percentage 100 Trigger Attribute

Trigger attribute for when data percentage is over 100% used.

*This model accepts additional fields of type Object.*

## Structure

`DataPercentage100TriggerAttribute`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `key` | `String` | Optional | Key data percentage 100. |
| `value` | `TrueClass \| FalseClass` | Optional | DataPercentage100<br />True - Trigger on Data percentage is over 100% used<br />False - Do not trigger when over 100% used. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "key": "DataPercentage100",
  "value": false,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

