
# Usage Request Response

*This model accepts additional fields of type Object.*

## Structure

`UsageRequestResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `RequestId` | `String` | Optional | - | String getRequestId() | setRequestId(String requestId) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "requestId": "be1b5958-3e11-41db-9abd-b1b7618c0035",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

