
# Data Percentage 90 Trigger Attribute

Trigger attribute for when data percentage is over 90% used.

## Structure

`DataPercentage90TriggerAttribute`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Key` | `String` | Optional | Key data percentage 90. | String getKey() | setKey(String key) |
| `Value` | `Boolean` | Optional | DataPercentage90<br />True - Trigger on Data percentage is over 90% used<br />False - Do not trigger when over 90% used. | Boolean getValue() | setValue(Boolean value) |

## Example (as JSON)

```json
{
  "key": "DataPercentage90",
  "value": false
}
```

