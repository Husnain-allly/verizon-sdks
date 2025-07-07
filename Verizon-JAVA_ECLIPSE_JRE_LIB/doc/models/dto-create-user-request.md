
# Dto Create User Request

## Structure

`DtoCreateUserRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Accountname` | `String` | Optional | The numeric account name, which must include leading zeros | String getAccountname() | setAccountname(String accountname) |
| `User` | [`DtoUserDto`](../../doc/models/dto-user-dto.md) | Optional | - | DtoUserDto getUser() | setUser(DtoUserDto user) |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "user": {
    "email": "email6",
    "firstname": "firstname8",
    "lastname": "lastname6",
    "mdn": "mdn8",
    "customdata": {
      "key0": {
        "key1": "val1",
        "key2": "val2"
      },
      "key1": {
        "key1": "val1",
        "key2": "val2"
      },
      "key2": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  }
}
```

