
# Update Service Endpoint Result

Response to update registered Service Endpoint information.

## Structure

`UpdateServiceEndpointResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `*string` | Optional | HTTP status code.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `Message` | `*string` | Optional | EdgeAppServices are updated or error details in case of an error.<br><br>**Constraints**: *Maximum Length*: `64` |

## Example (as JSON)

```json
{
  "status": "Success",
  "message": "EdgeAppServices are updated"
}
```

