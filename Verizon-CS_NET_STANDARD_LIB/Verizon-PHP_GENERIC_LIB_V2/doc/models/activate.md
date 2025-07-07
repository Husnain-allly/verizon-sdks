
# Activate

*This model accepts additional fields of type array.*

## Structure

`Activate`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `profile` | `string` | Required | - | getProfile(): string | setProfile(string profile): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "profile": "HSS EsmProfile Enterprise 5G",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

