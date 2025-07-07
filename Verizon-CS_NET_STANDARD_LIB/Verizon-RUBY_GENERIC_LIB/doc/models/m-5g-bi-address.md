
# M 5G Bi Address

*This model accepts additional fields of type Object.*

## Structure

`M5GBiAddress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `address_line_1` | `String` | Optional | - |
| `city` | `String` | Optional | - |
| `state` | `String` | Optional | - |
| `zip` | `String` | Optional | - |
| `zip_4` | `String` | Optional | - |
| `phone` | `String` | Optional | - |
| `phone_type` | `String` | Optional | - |
| `email_address` | `String` | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

