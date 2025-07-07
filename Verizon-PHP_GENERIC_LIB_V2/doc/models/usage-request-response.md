
# Usage Request Response

*This model accepts additional fields of type array.*

## Structure

`UsageRequestResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `requestId` | `?string` | Optional | - | getRequestId(): ?string | setRequestId(?string requestId): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

