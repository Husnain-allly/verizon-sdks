
# Tscore

*This model accepts additional fields of type array.*

## Structure

`Tscore`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `profileid` | `?string` | Optional | the UUID of the profile | getProfileid(): ?string | setProfileid(?string profileid): void |
| `profileversionid` | `?string` | Optional | the UUID of the profile version | getProfileversionid(): ?string | setProfileversionid(?string profileversionid): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "profileid": "the UUID of the profile",
  "profileversionid": "the UUID of the profile version",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

