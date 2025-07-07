
# Fota V1 Result Exception

Response in case of any errors.

*This model accepts additional fields of type object.*

## Structure

`FotaV1ResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ErrorCode` | `string` | Required | Error response code. |
| `ErrorMessage` | `string` | Required | Description of the error. |
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

