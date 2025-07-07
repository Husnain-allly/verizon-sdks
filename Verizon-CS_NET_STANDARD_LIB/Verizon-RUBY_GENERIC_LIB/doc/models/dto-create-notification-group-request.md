
# Dto Create Notification Group Request

## Structure

`DtoCreateNotificationGroupRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountname` | `String` | Optional | The numeric account name, which must include leading zeros |
| `group` | [`DtoNotificationGroupRequestEntity`](../../doc/models/dto-notification-group-request-entity.md) | Required | - |
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
  "userids": [
    "userids0",
    "userids1",
    "userids2"
  ]
}
```

