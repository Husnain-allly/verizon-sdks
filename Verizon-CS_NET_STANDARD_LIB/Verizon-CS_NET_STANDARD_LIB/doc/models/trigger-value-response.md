
# Trigger Value Response

*This model accepts additional fields of type object.*

## Structure

`TriggerValueResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Triggers` | [`List<Triggervalues>`](../../doc/models/triggervalues.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

