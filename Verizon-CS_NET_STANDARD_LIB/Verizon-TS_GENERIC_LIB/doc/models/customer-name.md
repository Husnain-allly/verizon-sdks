
# Customer Name

The customer name to be used for line usage taxation.

*This model accepts additional fields of type unknown.*

## Structure

`CustomerName`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `title` | `string \| undefined` | Optional | An optional title for the customer, such as “Mr.” or “Dr.” |
| `firstName` | `string` | Required | The customer's first name. |
| `middleName` | `string \| undefined` | Optional | The customer's middle name. |
| `lastName` | `string` | Required | The customer's last name. |
| `suffix` | `string \| undefined` | Optional | An optional suffix for the customer name, such as “Jr.” or “III.” |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

