
# Mec Performance Query Result

Result of the query for obtaining MEC performance metrics.

*This model accepts additional fields of type array.*

## Structure

`MecPerformanceQueryResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `name` | `?string` | Optional | Name of the parameter. | getName(): ?string | setName(?string name): void |
| `data` | `?(array<?string>)` | Optional | Parameter values. | getData(): ?array | setData(?array data): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "name": "NetworkAvailability",
  "data": [
    "100",
    "percent",
    "high"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

