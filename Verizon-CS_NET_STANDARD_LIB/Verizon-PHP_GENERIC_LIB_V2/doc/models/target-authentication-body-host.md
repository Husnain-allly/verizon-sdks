
# Target Authentication Body Host

Host information.

*This model accepts additional fields of type array.*

## Structure

`TargetAuthenticationBodyHost`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `hostandpath` | `?string` | Optional | - | getHostandpath(): ?string | setHostandpath(?string hostandpath): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "hostandpath": "https:// myhost.com:1825",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

