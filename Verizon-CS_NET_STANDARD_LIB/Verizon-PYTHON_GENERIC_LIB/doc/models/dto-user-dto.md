
# Dto User Dto

## Structure

`DtoUserDto`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `email` | `str` | Optional | Contact email for the group |
| `firstname` | `str` | Optional | The first name in the user record |
| `lastname` | `str` | Optional | The last name in the user record |
| `mdn` | `str` | Optional | The Mobile Directory Number |
| `customdata` | `Dict[str, Any]` | Optional | Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action. |

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

