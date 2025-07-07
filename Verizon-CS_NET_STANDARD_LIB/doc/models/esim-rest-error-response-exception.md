
# Esim Rest Error Response Exception

*This model accepts additional fields of type object.*

## Structure

`EsimRestErrorResponseException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ErrorCode` | `string` | Optional | - |
| `ErrorMessage` | `string` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "errorCode": "The 3-digit HTML error code",
  "errorMessage": "a description of the error",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

