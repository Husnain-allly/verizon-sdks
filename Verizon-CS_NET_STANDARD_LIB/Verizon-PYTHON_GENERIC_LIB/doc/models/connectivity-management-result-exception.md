
# Connectivity Management Result Exception

Response to errors.

*This model accepts additional fields of type Any.*

## Structure

`ConnectivityManagementResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `error_code` | `str` | Optional | Code of the error. |
| `error_message` | `str` | Optional | Details of the error. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "errorCode": "error code string",
  "errorMessage": "error message string",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

