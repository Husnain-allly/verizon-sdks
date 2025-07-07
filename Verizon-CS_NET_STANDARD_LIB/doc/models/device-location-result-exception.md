
# Device Location Result Exception

Will be empty if there was no error.

*This model accepts additional fields of type object.*

## Structure

`DeviceLocationResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ErrorCode` | `string` | Required | - |
| `ErrorMessage` | `string` | Required | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

