
# M 5G Bi Address

*This model accepts additional fields of type array.*

## Structure

`M5GBiAddress`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `addressLine1` | `?string` | Optional | - | getAddressLine1(): ?string | setAddressLine1(?string addressLine1): void |
| `city` | `?string` | Optional | - | getCity(): ?string | setCity(?string city): void |
| `state` | `?string` | Optional | - | getState(): ?string | setState(?string state): void |
| `zip` | `?string` | Optional | - | getZip(): ?string | setZip(?string zip): void |
| `zip4` | `?string` | Optional | - | getZip4(): ?string | setZip4(?string zip4): void |
| `phone` | `?string` | Optional | - | getPhone(): ?string | setPhone(?string phone): void |
| `phoneType` | `?string` | Optional | - | getPhoneType(): ?string | setPhoneType(?string phoneType): void |
| `emailAddress` | `?string` | Optional | - | getEmailAddress(): ?string | setEmailAddress(?string emailAddress): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "addressLine1": "number and street",
  "city": "city",
  "state": "2-letter state ID (conforms to ISO 3166-2)",
  "zip": "5-digit zip code",
  "zip+4": "the +4 digits used for zip codes",
  "phone": "a 10-digit phone number",
  "phoneType": "W",
  "emailAddress": "email@emailaddress.com",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

