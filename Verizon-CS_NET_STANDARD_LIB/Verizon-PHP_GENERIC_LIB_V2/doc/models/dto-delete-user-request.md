
# Dto Delete User Request

## Structure

`DtoDeleteUserRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountname` | `?string` | Optional | The numeric account name, which must include leading zeros | getAccountname(): ?string | setAccountname(?string accountname): void |
| `id` | `?string` | Optional | UUID of the user record, assigned at creation | getId(): ?string | setId(?string id): void |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "id": "id2"
}
```

