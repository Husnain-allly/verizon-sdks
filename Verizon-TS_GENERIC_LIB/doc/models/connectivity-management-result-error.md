
# Connectivity Management Result Error

Response to errors.

*This model accepts additional fields of type unknown.*

## Structure

`ConnectivityManagementResultError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `errorCode` | `string \| undefined` | Optional | Code of the error. |
| `errorMessage` | `string \| undefined` | Optional | Details of the error. |
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

