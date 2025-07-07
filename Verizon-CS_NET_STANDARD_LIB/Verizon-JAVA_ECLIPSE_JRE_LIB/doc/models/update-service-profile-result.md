
# Update Service Profile Result

Response on successful update of service profile.

## Structure

`UpdateServiceProfileResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Status` | `String` | Optional | HTTP status code.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getStatus() | setStatus(String status) |
| `Message` | `String` | Optional | Service Profile that are updated or error details in case of an error.<br><br>**Constraints**: *Maximum Length*: `32` | String getMessage() | setMessage(String message) |

## Example (as JSON)

```json
{
  "status": "Success",
  "message": "Service Profile Updated"
}
```

