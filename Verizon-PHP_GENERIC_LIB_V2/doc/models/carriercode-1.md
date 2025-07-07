
# Carriercode 1

*This model accepts additional fields of type array.*

## Structure

`Carriercode1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `carrierCode` | `?string` | Optional | - | getCarrierCode(): ?string | setCarrierCode(?string carrierCode): void |
| `percentage` | [`?AllowanceThreshold`](../../doc/models/allowance-threshold.md) | Optional | - | getPercentage(): ?AllowanceThreshold | setPercentage(?AllowanceThreshold percentage): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "carrierCode": "Carrier identifier code 1",
  "percentage": {
    "percentage50": false,
    "percentage75": false,
    "percentage90": false,
    "percentage100": false,
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

