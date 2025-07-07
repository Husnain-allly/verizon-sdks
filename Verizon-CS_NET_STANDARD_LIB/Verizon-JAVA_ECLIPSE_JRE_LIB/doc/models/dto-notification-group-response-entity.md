
# Dto Notification Group Response Entity

## Structure

`DtoNotificationGroupResponseEntity`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Createdon` | `LocalDateTime` | Optional | Timestamp of the record | LocalDateTime getCreatedon() | setCreatedon(LocalDateTime createdon) |
| `Description` | `String` | Optional | a short description | String getDescription() | setDescription(String description) |
| `Foreignid` | `String` | Optional | UUID of the ECPD account the user belongs to | String getForeignid() | setForeignid(String foreignid) |
| `Groupemail` | `String` | Optional | Contact email for the group | String getGroupemail() | setGroupemail(String groupemail) |
| `Id` | `String` | Optional | UUID of the user record, assigned at creation | String getId() | setId(String id) |
| `Lastupdated` | `LocalDateTime` | Optional | Timestamp of the record | LocalDateTime getLastupdated() | setLastupdated(LocalDateTime lastupdated) |
| `Name` | `String` | Optional | User defined name of the record | String getName() | setName(String name) |
| `Users` | [`List<DtoUserDto>`](../../doc/models/dto-user-dto.md) | Optional | **Constraints**: *Maximum Items*: `100` | List<DtoUserDto> getUsers() | setUsers(List<DtoUserDto> users) |
| `Version` | `String` | Optional | The resource version | String getVersion() | setVersion(String version) |
| `Versionid` | `String` | Optional | The UUID of the resource version | String getVersionid() | setVersionid(String versionid) |

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

