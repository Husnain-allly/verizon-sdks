
# Fota V1 Result Exception

Response in case of any errors.

*This model accepts additional fields of type Object.*

## Structure

`FotaV1ResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `error_code` | `String` | Required | Error response code. |
| `error_message` | `String` | Required | Description of the error. |
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

