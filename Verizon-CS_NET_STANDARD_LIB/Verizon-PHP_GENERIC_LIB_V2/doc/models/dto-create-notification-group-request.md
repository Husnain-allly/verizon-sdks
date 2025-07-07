
# Dto Create Notification Group Request

## Structure

`DtoCreateNotificationGroupRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountname` | `?string` | Optional | The numeric account name, which must include leading zeros | getAccountname(): ?string | setAccountname(?string accountname): void |
| `group` | [`DtoNotificationGroupRequestEntity`](../../doc/models/dto-notification-group-request-entity.md) | Required | - | getGroup(): DtoNotificationGroupRequestEntity | setGroup(DtoNotificationGroupRequestEntity group): void |
| `userids` | `?(string[])` | Optional | - | getUserids(): ?array | setUserids(?array userids): void |

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

