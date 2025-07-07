
# Dto Notification Group Request Entity

## Structure

`DtoNotificationGroupRequestEntity`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `description` | `?string` | Optional | a short description | getDescription(): ?string | setDescription(?string description): void |
| `groupemail` | `?string` | Optional | Contact email for the group | getGroupemail(): ?string | setGroupemail(?string groupemail): void |
| `name` | `?string` | Optional | User defined name of the record | getName(): ?string | setName(?string name): void |

## Example (as JSON)

```json
{
  "description": "a short description",
  "groupemail": "email@domain.com",
  "name": "name of the record"
}
```

