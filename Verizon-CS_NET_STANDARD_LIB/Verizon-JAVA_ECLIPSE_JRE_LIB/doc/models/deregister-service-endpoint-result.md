
# Deregister Service Endpoint Result

Response to deregister an application's Service Endpoint from one or more Multi-access Edge Compute (MEC) Platforms.

## Structure

`DeregisterServiceEndpointResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Status` | `String` | Optional | HTTP status code.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getStatus() | setStatus(String status) |
| `Message` | `String` | Optional | EdgeAppServicesID that are deleted or error details in case of an error.<br><br>**Constraints**: *Maximum Length*: `32` | String getMessage() | setMessage(String message) |

## Example (as JSON)

```json
{
  "status": "Success",
  "message": "EdgeAppServicesID Deleted"
}
```

