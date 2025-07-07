
# Delete Service Profile Result

Response on successful deletion of service profile.

## Structure

`DeleteServiceProfileResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Status` | `String` | Optional | **Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getStatus() | setStatus(String status) |
| `Message` | `String` | Optional | **Constraints**: *Maximum Length*: `32` | String getMessage() | setMessage(String message) |

## Example (as JSON)

```json
{
  "status": "Success",
  "message": "Service Profile Deleted"
}
```

