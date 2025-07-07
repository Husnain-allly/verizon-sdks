
# M 5G Biattribute 1

*This model accepts additional fields of type array.*

## Structure

`M5GBiattribute1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `key` | `?string` | Optional | - | getKey(): ?string | setKey(?string key): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "key": "PrimaryPlaceOfUseTitle",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

