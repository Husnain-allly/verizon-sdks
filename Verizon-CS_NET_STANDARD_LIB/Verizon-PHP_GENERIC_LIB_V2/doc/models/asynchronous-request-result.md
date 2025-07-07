
# Asynchronous Request Result

A successful request returns the request ID and the current status.

*This model accepts additional fields of type array.*

## Structure

`AsynchronousRequestResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `requestId` | `?string` | Optional | The unique ID of the asynchronous request. | getRequestId(): ?string | setRequestId(?string requestId): void |
| `status` | [`?string(RequestStatus)`](../../doc/models/request-status.md) | Optional | The current status of the callback response. | getStatus(): ?string | setStatus(?string status): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

