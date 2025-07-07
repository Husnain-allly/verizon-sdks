
# Fota V2 Result Exception

Response for error cases.

*This model accepts additional fields of type object.*

## Structure

`FotaV2ResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ErrorCode` | `string` | Required | Code of the error. |
| `ErrorMessage` | `string` | Required | Details of the error. |
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

