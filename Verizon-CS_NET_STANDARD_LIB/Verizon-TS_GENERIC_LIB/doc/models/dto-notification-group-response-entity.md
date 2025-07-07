
# Dto Notification Group Response Entity

## Structure

`DtoNotificationGroupResponseEntity`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `createdon` | `string \| undefined` | Optional | Timestamp of the record |
| `description` | `string \| undefined` | Optional | a short description |
| `foreignid` | `string \| undefined` | Optional | UUID of the ECPD account the user belongs to |
| `groupemail` | `string \| undefined` | Optional | Contact email for the group |
| `id` | `string \| undefined` | Optional | UUID of the user record, assigned at creation |
| `lastupdated` | `string \| undefined` | Optional | Timestamp of the record |
| `name` | `string \| undefined` | Optional | User defined name of the record |
| `users` | [`DtoUserDto[] \| undefined`](../../doc/models/dto-user-dto.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `version` | `string \| undefined` | Optional | The resource version |
| `versionid` | `string \| undefined` | Optional | The UUID of the resource version |

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

