
# Fota V2 Result Exception

Response for error cases.

*This model accepts additional fields of type Object.*

## Structure

`FotaV2ResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `error_code` | `String` | Required | Code of the error. |
| `error_message` | `String` | Required | Details of the error. |
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

