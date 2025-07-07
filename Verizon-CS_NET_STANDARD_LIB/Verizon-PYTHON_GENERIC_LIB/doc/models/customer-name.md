
# Customer Name

The customer name to be used for line usage taxation.

*This model accepts additional fields of type Any.*

## Structure

`CustomerName`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `title` | `str` | Optional | An optional title for the customer, such as “Mr.” or “Dr.” |
| `first_name` | `str` | Required | The customer's first name. |
| `middle_name` | `str` | Optional | The customer's middle name. |
| `last_name` | `str` | Required | The customer's last name. |
| `suffix` | `str` | Optional | An optional suffix for the customer name, such as “Jr.” or “III.” |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

