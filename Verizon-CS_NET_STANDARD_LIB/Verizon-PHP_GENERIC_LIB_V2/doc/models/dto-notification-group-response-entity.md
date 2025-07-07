
# Dto Notification Group Response Entity

## Structure

`DtoNotificationGroupResponseEntity`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `createdon` | `?DateTime` | Optional | Timestamp of the record | getCreatedon(): ?\DateTime | setCreatedon(?\DateTime createdon): void |
| `description` | `?string` | Optional | a short description | getDescription(): ?string | setDescription(?string description): void |
| `foreignid` | `?string` | Optional | UUID of the ECPD account the user belongs to | getForeignid(): ?string | setForeignid(?string foreignid): void |
| `groupemail` | `?string` | Optional | Contact email for the group | getGroupemail(): ?string | setGroupemail(?string groupemail): void |
| `id` | `?string` | Optional | UUID of the user record, assigned at creation | getId(): ?string | setId(?string id): void |
| `lastupdated` | `?DateTime` | Optional | Timestamp of the record | getLastupdated(): ?\DateTime | setLastupdated(?\DateTime lastupdated): void |
| `name` | `?string` | Optional | User defined name of the record | getName(): ?string | setName(?string name): void |
| `users` | [`?(DtoUserDto[])`](../../doc/models/dto-user-dto.md) | Optional | **Constraints**: *Maximum Items*: `100` | getUsers(): ?array | setUsers(?array users): void |
| `version` | `?string` | Optional | The resource version | getVersion(): ?string | setVersion(?string version): void |
| `versionid` | `?string` | Optional | The UUID of the resource version | getVersionid(): ?string | setVersionid(?string versionid): void |

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

