
# Customer Name

The customer name to be used for line usage taxation.

*This model accepts additional fields of type Object.*

## Structure

`CustomerName`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `title` | `String` | Optional | An optional title for the customer, such as “Mr.” or “Dr.” |
| `first_name` | `String` | Required | The customer's first name. |
| `middle_name` | `String` | Optional | The customer's middle name. |
| `last_name` | `String` | Required | The customer's last name. |
| `suffix` | `String` | Optional | An optional suffix for the customer name, such as “Jr.” or “III.” |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "title": "President",
  "firstName": "Zaffod",
  "lastName": "Beeblebrox",
  "middleName": "middleName4",
  "suffix": "suffix4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

