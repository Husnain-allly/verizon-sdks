
# Trigger Attributes Options

*This model accepts additional fields of type Any.*

## Structure

`TriggerAttributesOptions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `key` | `str` | Optional | If present, the NotificationGroupName will be listed here. |
| `value` | `bool` | Optional | DataPercentage50<br />True - Trigger on Data percentage is over 50% used<br />False - Do not trigger when over 50% used. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

