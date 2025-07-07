
# Fota V3 Result Exception

Error response.

*This model accepts additional fields of type Object.*

## Structure

`FotaV3ResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `error_code` | `String` | Required | Error code string. |
| `error_message` | `String` | Required | Error message string. |
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

