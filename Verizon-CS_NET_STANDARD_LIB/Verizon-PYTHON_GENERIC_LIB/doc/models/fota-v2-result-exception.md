
# Fota V2 Result Exception

Response for error cases.

*This model accepts additional fields of type Any.*

## Structure

`FotaV2ResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `error_code` | `str` | Required | Code of the error. |
| `error_message` | `str` | Required | Details of the error. |
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

