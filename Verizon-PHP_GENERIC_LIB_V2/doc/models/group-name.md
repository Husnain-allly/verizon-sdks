
# Group Name

*This model accepts additional fields of type array.*

## Structure

`GroupName`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `default` | `?string` | Optional | - | getDefault(): ?string | setDefault(?string default): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "Default": "0000123456-00001",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

