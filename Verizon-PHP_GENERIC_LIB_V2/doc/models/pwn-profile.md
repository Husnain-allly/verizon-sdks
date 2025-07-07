
# Pwn Profile

*This model accepts additional fields of type array.*

## Structure

`PwnProfile`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `profileId` | `?string` | Optional | - | getProfileId(): ?string | setProfileId(?string profileId): void |
| `profileName` | `?string` | Optional | - | getProfileName(): ?string | setProfileName(?string profileName): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "profileId": "HSS-EsmProfile_Enterprise",
  "profileName": "HSS EsmProfile Enterprise",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

