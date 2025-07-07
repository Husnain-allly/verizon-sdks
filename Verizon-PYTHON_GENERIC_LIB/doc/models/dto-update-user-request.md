
# Dto Update User Request

## Structure

`DtoUpdateUserRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountname` | `str` | Optional | The numeric account name, which must include leading zeros |
| `id` | `str` | Optional | UUID of the user record, assigned at creation |
| `user` | [`DtoUserDto`](../../doc/models/dto-user-dto.md) | Optional | - |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "id": "id4",
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

