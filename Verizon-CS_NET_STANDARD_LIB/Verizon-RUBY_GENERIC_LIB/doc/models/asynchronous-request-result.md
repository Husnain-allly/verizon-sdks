
# Asynchronous Request Result

A successful request returns the request ID and the current status.

*This model accepts additional fields of type Object.*

## Structure

`AsynchronousRequestResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `request_id` | `String` | Optional | The unique ID of the asynchronous request. |
| `status` | [`RequestStatus`](../../doc/models/request-status.md) | Optional | The current status of the callback response. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

