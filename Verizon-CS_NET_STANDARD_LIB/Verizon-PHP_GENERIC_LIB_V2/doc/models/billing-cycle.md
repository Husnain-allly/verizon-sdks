
# Billing Cycle

*This model accepts additional fields of type array.*

## Structure

`BillingCycle`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `year` | `?string` | Optional | - | getYear(): ?string | setYear(?string year): void |
| `month` | `?string` | Optional | - | getMonth(): ?string | setMonth(?string month): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "year": "2020",
  "month": "3",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

