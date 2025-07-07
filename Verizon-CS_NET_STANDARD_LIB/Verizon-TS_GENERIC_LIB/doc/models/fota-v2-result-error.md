
# Fota V2 Result Error

Response for error cases.

*This model accepts additional fields of type unknown.*

## Structure

`FotaV2ResultError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `errorCode` | `string` | Required | Code of the error. |
| `errorMessage` | `string` | Required | Details of the error. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

