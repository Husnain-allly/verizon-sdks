
# M 5G Biattribute 2

*This model accepts additional fields of type array.*

## Structure

`M5GBiattribute2`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `key` | `?string` | Optional | - | getKey(): ?string | setKey(?string key): void |
| `value` | `?string` | Optional | - | getValue(): ?string | setValue(?string value): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "key": "PrimaryPlaceOfUseFirstName",
  "value": "string",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

