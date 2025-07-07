
# Connectivity Management Result Exception

Response to errors.

*This model accepts additional fields of type Object.*

## Structure

`ConnectivityManagementResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `error_code` | `String` | Optional | Code of the error. |
| `error_message` | `String` | Optional | Details of the error. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

