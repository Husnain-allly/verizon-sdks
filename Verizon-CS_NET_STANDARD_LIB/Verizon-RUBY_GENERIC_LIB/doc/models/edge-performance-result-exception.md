
# Edge Performance Result Exception

Types of errors in response.

*This model accepts additional fields of type Object.*

## Structure

`EdgePerformanceResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `status` | `String` | Optional | HTTP status code. |
| `message` | `String` | Optional | Error details. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

