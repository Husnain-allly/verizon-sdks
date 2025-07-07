
# Trigger Value Response 2

*This model accepts additional fields of type object.*

## Structure

`TriggerValueResponse2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Triggers` | [`List<Triggervalues2>`](../../doc/models/triggervalues-2.md) | Optional | - |
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
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

