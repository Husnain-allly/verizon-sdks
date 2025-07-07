
# Pwn Profile

*This model accepts additional fields of type Object.*

## Structure

`PwnProfile`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ProfileId` | `String` | Optional | - | String getProfileId() | setProfileId(String profileId) |
| `ProfileName` | `String` | Optional | - | String getProfileName() | setProfileName(String profileName) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

