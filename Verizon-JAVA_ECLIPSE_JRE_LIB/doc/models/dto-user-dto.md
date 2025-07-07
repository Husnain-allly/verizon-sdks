
# Dto User Dto

## Structure

`DtoUserDto`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Email` | `String` | Optional | Contact email for the group | String getEmail() | setEmail(String email) |
| `Firstname` | `String` | Optional | The first name in the user record | String getFirstname() | setFirstname(String firstname) |
| `Lastname` | `String` | Optional | The last name in the user record | String getLastname() | setLastname(String lastname) |
| `Mdn` | `String` | Optional | The Mobile Directory Number | String getMdn() | setMdn(String mdn) |
| `Customdata` | `Map<String, Object>` | Optional | Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action. | Map<String, Object> getCustomdata() | setCustomdata(Map<String, Object> customdata) |

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

