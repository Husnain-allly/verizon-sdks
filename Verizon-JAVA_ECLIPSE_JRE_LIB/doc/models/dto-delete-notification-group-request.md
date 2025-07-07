
# Dto Delete Notification Group Request

## Structure

`DtoDeleteNotificationGroupRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Accountname` | `String` | Optional | The numeric account name, which must include leading zeros | String getAccountname() | setAccountname(String accountname) |
| `Force` | `Boolean` | Optional | - | Boolean getForce() | setForce(Boolean force) |
| `Id` | `String` | Optional | UUID of the user record, assigned at creation | String getId() | setId(String id) |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "force": true,
  "id": "id0"
}
```

