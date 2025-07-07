
# Edge Performance Result Error

Types of errors in response.

*This model accepts additional fields of type unknown.*

## Structure

`EdgePerformanceResultError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `status` | `string \| undefined` | Optional | HTTP status code. |
| `message` | `string \| undefined` | Optional | Error details. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "status": "HTTP status code",
  "message": "Error details",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

