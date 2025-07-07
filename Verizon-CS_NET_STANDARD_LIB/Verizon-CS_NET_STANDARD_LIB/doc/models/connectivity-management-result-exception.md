
# Connectivity Management Result Exception

Response to errors.

*This model accepts additional fields of type object.*

## Structure

`ConnectivityManagementResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ErrorCode` | `string` | Optional | Code of the error. |
| `ErrorMessage` | `string` | Optional | Details of the error. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

