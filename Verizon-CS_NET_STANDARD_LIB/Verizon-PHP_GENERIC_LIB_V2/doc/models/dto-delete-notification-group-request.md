
# Dto Delete Notification Group Request

## Structure

`DtoDeleteNotificationGroupRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountname` | `?string` | Optional | The numeric account name, which must include leading zeros | getAccountname(): ?string | setAccountname(?string accountname): void |
| `force` | `?bool` | Optional | - | getForce(): ?bool | setForce(?bool force): void |
| `id` | `?string` | Optional | UUID of the user record, assigned at creation | getId(): ?string | setId(?string id): void |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "force": true,
  "id": "id0"
}
```

