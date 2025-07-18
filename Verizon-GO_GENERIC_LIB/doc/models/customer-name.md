
# Customer Name

The customer name to be used for line usage taxation.

*This model accepts additional fields of type interface{}.*

## Structure

`CustomerName`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Title` | `*string` | Optional | An optional title for the customer, such as “Mr.” or “Dr.” |
| `FirstName` | `string` | Required | The customer's first name. |
| `MiddleName` | `*string` | Optional | The customer's middle name. |
| `LastName` | `string` | Required | The customer's last name. |
| `Suffix` | `*string` | Optional | An optional suffix for the customer name, such as “Jr.” or “III.” |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

