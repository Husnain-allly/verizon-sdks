
# Data Percentage 75 Trigger Attribute

Trigger attribute for when data percentage is over 75% used.

*This model accepts additional fields of type Object.*

## Structure

`DataPercentage75TriggerAttribute`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Key` | `String` | Optional | Key data percentage 75. | String getKey() | setKey(String key) |
| `Value` | `Boolean` | Optional | DataPercentage75<br />True - Trigger on Data percentage is over 75% used<br />False - Do not trigger when over 75% used. | Boolean getValue() | setValue(Boolean value) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

