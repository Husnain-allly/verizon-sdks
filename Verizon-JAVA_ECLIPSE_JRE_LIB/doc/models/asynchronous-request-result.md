
# Asynchronous Request Result

A successful request returns the request ID and the current status.

*This model accepts additional fields of type Object.*

## Structure

`AsynchronousRequestResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `RequestId` | `String` | Optional | The unique ID of the asynchronous request. | String getRequestId() | setRequestId(String requestId) |
| `Status` | [`RequestStatus`](../../doc/models/request-status.md) | Optional | The current status of the callback response. | RequestStatus getStatus() | setStatus(RequestStatus status) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "requestId": "86c83330-4bf5-4235-9c4e-a83f93aeae4c",
  "status": "Success",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

