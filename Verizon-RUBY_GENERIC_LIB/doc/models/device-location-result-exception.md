
# Device Location Result Exception

Will be empty if there was no error.

*This model accepts additional fields of type Object.*

## Structure

`DeviceLocationResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `error_code` | `String` | Required | - |
| `error_message` | `String` | Required | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "errorCode": "The type of error, such as INVALID_REQUEST.",
  "errorMessage": "Additional error information.",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

