
# Stop Monitor Request

*This model accepts additional fields of type array.*

## Structure

`StopMonitorRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `string` | Required | - | getAccountName(): string | setAccountName(string accountName): void |
| `monitorIds` | `string[]` | Required | - | getMonitorIds(): array | setMonitorIds(array monitorIds): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "0242123520-00001",
  "monitorIds": [
    "35596ca6-bab4-4333-a914-42b4fc2da54c",
    "35596ca6-bab4-4333-a914-42b4fc2da54b"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

