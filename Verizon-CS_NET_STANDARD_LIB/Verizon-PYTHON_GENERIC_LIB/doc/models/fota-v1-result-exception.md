
# Fota V1 Result Exception

Response in case of any errors.

*This model accepts additional fields of type Any.*

## Structure

`FotaV1ResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `error_code` | `str` | Required | Error response code. |
| `error_message` | `str` | Required | Description of the error. |
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

