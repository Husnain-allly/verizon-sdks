
# Trigger Attributes Options

*This model accepts additional fields of type array.*

## Structure

`TriggerAttributesOptions`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `key` | `?string` | Optional | If present, the NotificationGroupName will be listed here. | getKey(): ?string | setKey(?string key): void |
| `value` | `?bool` | Optional | DataPercentage50<br />True - Trigger on Data percentage is over 50% used<br />False - Do not trigger when over 50% used. | getValue(): ?bool | setValue(?bool value): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

