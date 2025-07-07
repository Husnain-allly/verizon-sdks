
# Configuration

List of the field names and values to set.

*This model accepts additional fields of type array.*

## Structure

`Configuration`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `frequency` | `?string` | Optional | - | getFrequency(): ?string | setFrequency(?string frequency): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "frequency": "Low",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

