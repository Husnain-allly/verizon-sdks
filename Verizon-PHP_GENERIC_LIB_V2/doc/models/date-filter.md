
# Date Filter

Filter out the dates.

*This model accepts additional fields of type array.*

## Structure

`DateFilter`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `earliest` | `string` | Required | Only include devices that were added after this date and time. | getEarliest(): string | setEarliest(string earliest): void |
| `latest` | `string` | Required | Only include devices that were added before this date and time. | getLatest(): string | setLatest(string latest): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "earliest": "2020-05-01T15:00:00-08:00Z",
  "latest": "2020-07-30T15:00:00-08:00Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

