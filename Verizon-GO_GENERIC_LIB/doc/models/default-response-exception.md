
# Default Response Exception

*This model accepts additional fields of type interface{}.*

## Structure

`DefaultResponseException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ErrorCode` | `*string` | Optional | - |
| `ErrorMessage` | `*string` | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "errorCode": "3 or 4 digit error code",
  "errorMessage": "A short description of the error",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

