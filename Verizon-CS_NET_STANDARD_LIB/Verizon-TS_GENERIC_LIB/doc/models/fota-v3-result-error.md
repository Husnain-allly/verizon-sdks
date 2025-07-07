
# Fota V3 Result Error

Error response.

*This model accepts additional fields of type unknown.*

## Structure

`FotaV3ResultError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `errorCode` | `string` | Required | Error code string. |
| `errorMessage` | `string` | Required | Error message string. |
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

