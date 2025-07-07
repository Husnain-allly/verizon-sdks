
# Sms Number

Notification SMS details.

*This model accepts additional fields of type array.*

## Structure

`SmsNumber`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `carrier` | `?string` | Optional | - | getCarrier(): ?string | setCarrier(?string carrier): void |
| `number` | `?string` | Optional | - | getNumber(): ?string | setNumber(?string number): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "carrier": "US Cellular",
  "number": "9299280711",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

