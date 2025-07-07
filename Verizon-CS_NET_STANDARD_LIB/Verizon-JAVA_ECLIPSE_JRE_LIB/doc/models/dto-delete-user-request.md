
# Dto Delete User Request

## Structure

`DtoDeleteUserRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Accountname` | `String` | Optional | The numeric account name, which must include leading zeros | String getAccountname() | setAccountname(String accountname) |
| `Id` | `String` | Optional | UUID of the user record, assigned at creation | String getId() | setId(String id) |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "id": "id2"
}
```

