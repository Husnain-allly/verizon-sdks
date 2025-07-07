
# Allowance Threshold

*This model accepts additional fields of type array.*

## Structure

`AllowanceThreshold`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `percentage50` | `?bool` | Optional | - | getPercentage50(): ?bool | setPercentage50(?bool percentage50): void |
| `percentage75` | `?bool` | Optional | - | getPercentage75(): ?bool | setPercentage75(?bool percentage75): void |
| `percentage90` | `?bool` | Optional | - | getPercentage90(): ?bool | setPercentage90(?bool percentage90): void |
| `percentage100` | `?bool` | Optional | - | getPercentage100(): ?bool | setPercentage100(?bool percentage100): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "percentage50": true,
  "percentage75": false,
  "percentage90": true,
  "percentage100": false,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

