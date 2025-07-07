
# Account Group Share Filter

*This model accepts additional fields of type array.*

## Structure

`AccountGroupShareFilter`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ratePlanGroupId` | `?int` | Optional | - | getRatePlanGroupId(): ?int | setRatePlanGroupId(?int ratePlanGroupId): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "ratePlanGroupId": 73,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

