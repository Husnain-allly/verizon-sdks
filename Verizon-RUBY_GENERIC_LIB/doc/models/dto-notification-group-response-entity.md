
# Dto Notification Group Response Entity

## Structure

`DtoNotificationGroupResponseEntity`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `createdon` | `DateTime` | Optional | Timestamp of the record |
| `description` | `String` | Optional | a short description |
| `foreignid` | `String` | Optional | UUID of the ECPD account the user belongs to |
| `groupemail` | `String` | Optional | Contact email for the group |
| `id` | `String` | Optional | UUID of the user record, assigned at creation |
| `lastupdated` | `DateTime` | Optional | Timestamp of the record |
| `name` | `String` | Optional | User defined name of the record |
| `users` | [`Array<DtoUserDto>`](../../doc/models/dto-user-dto.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `version` | `String` | Optional | The resource version |
| `versionid` | `String` | Optional | The UUID of the resource version |

## Example (as JSON)

```json
{
  "createdon": "10/02/2023 15:46:34",
  "description": "a short description",
  "foreignid": "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
  "groupemail": "email@domain.com",
  "lastupdated": "10/02/2023 15:46:34",
  "name": "name of the record",
  "version": "1.0",
  "versionid": "337bd2e8-eeee-ffff-gggg-5207992fd395",
  "id": "id8"
}
```

