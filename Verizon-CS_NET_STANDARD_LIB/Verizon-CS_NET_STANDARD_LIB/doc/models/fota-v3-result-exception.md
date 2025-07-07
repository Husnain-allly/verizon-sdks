
# Fota V3 Result Exception

Error response.

*This model accepts additional fields of type object.*

## Structure

`FotaV3ResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ErrorCode` | `string` | Required | Error code string. |
| `ErrorMessage` | `string` | Required | Error message string. |
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

