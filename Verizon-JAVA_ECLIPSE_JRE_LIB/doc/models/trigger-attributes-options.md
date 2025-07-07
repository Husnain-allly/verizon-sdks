
# Trigger Attributes Options

*This model accepts additional fields of type Object.*

## Structure

`TriggerAttributesOptions`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Key` | `String` | Optional | If present, the NotificationGroupName will be listed here. | String getKey() | setKey(String key) |
| `Value` | `Boolean` | Optional | DataPercentage50<br />True - Trigger on Data percentage is over 50% used<br />False - Do not trigger when over 50% used. | Boolean getValue() | setValue(Boolean value) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

