
# Edge Performance Result Exception

Types of errors in response.

*This model accepts additional fields of type object.*

## Structure

`EdgePerformanceResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Optional | HTTP status code. |
| `Message` | `string` | Optional | Error details. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

