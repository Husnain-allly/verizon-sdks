
# Trigger Attributes Options

*This model accepts additional fields of type object.*

## Structure

`TriggerAttributesOptions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Key` | `string` | Optional | If present, the NotificationGroupName will be listed here. |
| `MValue` | `bool?` | Optional | DataPercentage50<br />True - Trigger on Data percentage is over 50% used<br />False - Do not trigger when over 50% used. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

