
# M 5G Bi Request Response

*This model accepts additional fields of type array.*

## Structure

`M5GBiRequestResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `requestId` | `?string` | Optional | - | getRequestId(): ?string | setRequestId(?string requestId): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

