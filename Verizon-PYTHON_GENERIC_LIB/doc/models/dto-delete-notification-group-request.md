
# Dto Delete Notification Group Request

## Structure

`DtoDeleteNotificationGroupRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountname` | `str` | Optional | The numeric account name, which must include leading zeros |
| `force` | `bool` | Optional | - |
| `id` | `str` | Optional | UUID of the user record, assigned at creation |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "force": true,
  "id": "id0"
}
```

