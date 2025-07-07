
# Dto Update User Request

## Structure

`DtoUpdateUserRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountname` | `?string` | Optional | The numeric account name, which must include leading zeros | getAccountname(): ?string | setAccountname(?string accountname): void |
| `id` | `?string` | Optional | UUID of the user record, assigned at creation | getId(): ?string | setId(?string id): void |
| `user` | [`?DtoUserDto`](../../doc/models/dto-user-dto.md) | Optional | - | getUser(): ?DtoUserDto | setUser(?DtoUserDto user): void |

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

