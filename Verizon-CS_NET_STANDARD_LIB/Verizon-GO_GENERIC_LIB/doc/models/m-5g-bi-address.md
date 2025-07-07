
# M 5G Bi Address

*This model accepts additional fields of type interface{}.*

## Structure

`M5GBiAddress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AddressLine1` | `*string` | Optional | - |
| `City` | `*string` | Optional | - |
| `State` | `*string` | Optional | - |
| `Zip` | `*string` | Optional | - |
| `Zip4` | `*string` | Optional | - |
| `Phone` | `*string` | Optional | - |
| `PhoneType` | `*string` | Optional | - |
| `EmailAddress` | `*string` | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

