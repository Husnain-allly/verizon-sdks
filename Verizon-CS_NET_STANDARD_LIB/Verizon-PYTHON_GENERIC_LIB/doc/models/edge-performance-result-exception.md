
# Edge Performance Result Exception

Types of errors in response.

*This model accepts additional fields of type Any.*

## Structure

`EdgePerformanceResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `status` | `str` | Optional | HTTP status code. |
| `message` | `str` | Optional | Error details. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

