
# Customer Name

The customer name to be used for line usage taxation.

*This model accepts additional fields of type array.*

## Structure

`CustomerName`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `title` | `?string` | Optional | An optional title for the customer, such as “Mr.” or “Dr.” | getTitle(): ?string | setTitle(?string title): void |
| `firstName` | `string` | Required | The customer's first name. | getFirstName(): string | setFirstName(string firstName): void |
| `middleName` | `?string` | Optional | The customer's middle name. | getMiddleName(): ?string | setMiddleName(?string middleName): void |
| `lastName` | `string` | Required | The customer's last name. | getLastName(): string | setLastName(string lastName): void |
| `suffix` | `?string` | Optional | An optional suffix for the customer name, such as “Jr.” or “III.” | getSuffix(): ?string | setSuffix(?string suffix): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

