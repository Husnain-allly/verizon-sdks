
# Trigger Value Response

*This model accepts additional fields of type Object.*

## Structure

`TriggerValueResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Triggers` | [`List<Triggervalues>`](../../doc/models/triggervalues.md) | Optional | - | List<Triggervalues> getTriggers() | setTriggers(List<Triggervalues> triggers) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "triggers": [
    {
      "triggerId": "triggerId0",
      "triggerName": "triggerName8",
      "accountName": "accountName4",
      "organizationName": "organizationName2",
      "triggerCategory": "triggerCategory2",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "triggerId": "triggerId0",
      "triggerName": "triggerName8",
      "accountName": "accountName4",
      "organizationName": "organizationName2",
      "triggerCategory": "triggerCategory2",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

