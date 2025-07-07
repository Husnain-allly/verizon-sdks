
# Edge Performance Result Exception

Types of errors in response.

*This model accepts additional fields of type Object.*

## Structure

`EdgePerformanceResultException`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Status` | `String` | Optional | HTTP status code. | String getStatus() | setStatus(String status) |
| `Message` | `String` | Optional | Error details. | String getMessageField() | setMessageField(String messageField) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

