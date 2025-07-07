
# Cellphonenumber

*This model accepts additional fields of type array.*

## Structure

`Cellphonenumber`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `number` | `?string` | Optional | - | getNumber(): ?string | setNumber(?string number): void |
| `carrier` | `?string` | Optional | - | getCarrier(): ?string | setCarrier(?string carrier): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "number": "10-digit mobile number",
  "carrier": "mobile service provider",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

