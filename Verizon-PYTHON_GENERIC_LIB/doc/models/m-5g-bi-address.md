
# M 5G Bi Address

*This model accepts additional fields of type Any.*

## Structure

`M5GBiAddress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `address_line_1` | `str` | Optional | - |
| `city` | `str` | Optional | - |
| `state` | `str` | Optional | - |
| `zip` | `str` | Optional | - |
| `zip_4` | `str` | Optional | - |
| `phone` | `str` | Optional | - |
| `phone_type` | `str` | Optional | - |
| `email_address` | `str` | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

