
# Update Service Endpoint Result

Response to update registered Service Endpoint information.

## Structure

`UpdateServiceEndpointResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Status` | `String` | Optional | HTTP status code.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getStatus() | setStatus(String status) |
| `Message` | `String` | Optional | EdgeAppServices are updated or error details in case of an error.<br><br>**Constraints**: *Maximum Length*: `64` | String getMessage() | setMessage(String message) |

## Example (as JSON)

```json
{
  "status": "Success",
  "message": "EdgeAppServices are updated"
}
```

