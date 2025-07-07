
# M 5G Bi Customer Name

*This model accepts additional fields of type array.*

## Structure

`M5GBiCustomerName`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `firstName` | `?string` | Optional | - | getFirstName(): ?string | setFirstName(?string firstName): void |
| `lastName` | `?string` | Optional | - | getLastName(): ?string | setLastName(?string lastName): void |
| `middleName` | `?string` | Optional | - | getMiddleName(): ?string | setMiddleName(?string middleName): void |
| `title` | `?string` | Optional | - | getTitle(): ?string | setTitle(?string title): void |
| `suffex` | `?string` | Optional | - | getSuffex(): ?string | setSuffex(?string suffex): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "firstName": "First name",
  "lastName": "Surname or Last Name",
  "middleName": "middle name or initial",
  "title": "Mr. or Ms.",
  "suffex": "Dr or Esq",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

