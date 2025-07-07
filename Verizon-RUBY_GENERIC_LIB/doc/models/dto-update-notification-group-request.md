
# Dto Update Notification Group Request

## Structure

`DtoUpdateNotificationGroupRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountname` | `String` | Optional | The numeric account name, which must include leading zeros |
| `group` | [`DtoNotificationGroupRequestEntity`](../../doc/models/dto-notification-group-request-entity.md) | Required | - |
| `id` | `String` | Optional | UUID of the user record, assigned at creation |
| `userids` | `Array<String>` | Optional | - |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "group": {
    "description": "a short description",
    "groupemail": "email@domain.com",
    "name": "name of the record"
  },
  "id": "id8",
  "userids": [
    "userids6",
    "userids5"
  ]
}
```

