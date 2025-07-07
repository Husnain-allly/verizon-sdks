
# M201 Success

*This model accepts additional fields of type array.*

## Structure

`M201Success`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `requestId` | `?string` | Optional | - | getRequestId(): ?string | setRequestId(?string requestId): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "requestId": "be36accb-0a9a-4367-93ab-0af6c4ed256a",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

