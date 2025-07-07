
# Asynchronous Request Result

A successful request returns the request ID and the current status.

*This model accepts additional fields of type Any.*

## Structure

`AsynchronousRequestResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `request_id` | `str` | Optional | The unique ID of the asynchronous request. |
| `status` | [`RequestStatus`](../../doc/models/request-status.md) | Optional | The current status of the callback response. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

