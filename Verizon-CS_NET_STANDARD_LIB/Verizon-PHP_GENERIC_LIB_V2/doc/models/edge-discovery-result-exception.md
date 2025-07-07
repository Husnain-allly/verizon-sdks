
# Edge Discovery Result Exception

Base type for all errors.

*This model accepts additional fields of type array.*

## Structure

`EdgeDiscoveryResultException`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `status` | `string` | Required | HTTP status code or status of response.<br><br>**Constraints**: *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | getStatus(): string | setStatus(string status): void |
| `message` | `string` | Required | Error details.<br><br>**Constraints**: *Maximum Length*: `32` | getMessage(): string | setMessage(string message): void |
| `data` | [`?EdgeDiscoveryResultData`](../../doc/models/edge-discovery-result-data.md) | Optional | For cases where user input exceeds the boundary values an additional 'data' key will be returned with a relevant description. | getData(): ?EdgeDiscoveryResultData | setData(?EdgeDiscoveryResultData data): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "status": "status4",
  "message": "message2",
  "data": {
    "additionalMessage": "additionalMessage2",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

