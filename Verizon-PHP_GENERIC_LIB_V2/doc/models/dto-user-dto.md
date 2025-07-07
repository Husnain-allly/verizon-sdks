
# Dto User Dto

## Structure

`DtoUserDto`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `email` | `?string` | Optional | Contact email for the group | getEmail(): ?string | setEmail(?string email): void |
| `firstname` | `?string` | Optional | The first name in the user record | getFirstname(): ?string | setFirstname(?string firstname): void |
| `lastname` | `?string` | Optional | The last name in the user record | getLastname(): ?string | setLastname(?string lastname): void |
| `mdn` | `?string` | Optional | The Mobile Directory Number | getMdn(): ?string | setMdn(?string mdn): void |
| `customdata` | `?array` | Optional | Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action. | getCustomdata(): ?array | setCustomdata(?array customdata): void |

## Example (as JSON)

```json
{
  "email": "email@domain.com",
  "firstname": "First name",
  "lastname": "Last name or Surname",
  "mdn": "908-555-1234",
  "customdata": {
    "key0": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```

