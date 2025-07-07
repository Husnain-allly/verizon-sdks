
# Pwn Profile List

*This model accepts additional fields of type Object.*

## Structure

`PwnProfileList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Profiles` | [`List<PwnProfile>`](../../doc/models/pwn-profile.md) | Optional | - | List<PwnProfile> getProfiles() | setProfiles(List<PwnProfile> profiles) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "profiles": [
    {
      "profileId": "HSS-EsmProfile_Enterprise",
      "profileName": "HSS EsmProfile Enterprise",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

