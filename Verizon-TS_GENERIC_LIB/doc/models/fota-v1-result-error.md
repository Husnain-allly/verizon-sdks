
# Fota V1 Result Error

Response in case of any errors.

*This model accepts additional fields of type unknown.*

## Structure

`FotaV1ResultError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `errorCode` | `string` | Required | Error response code. |
| `errorMessage` | `string` | Required | Description of the error. |
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

