
# Trigger Value Response 2

*This model accepts additional fields of type array.*

## Structure

`TriggerValueResponse2`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `triggers` | [`?(Triggervalues2[])`](../../doc/models/triggervalues-2.md) | Optional | - | getTriggers(): ?array | setTriggers(?array triggers): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

