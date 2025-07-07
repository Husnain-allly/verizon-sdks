
# Trigger Value Response 2

*This model accepts additional fields of type Any.*

## Structure

`TriggerValueResponse2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggers` | [`List[Triggervalues2]`](../../doc/models/triggervalues-2.md) | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

