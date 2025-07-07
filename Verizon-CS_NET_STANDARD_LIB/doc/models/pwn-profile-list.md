
# Pwn Profile List

*This model accepts additional fields of type object.*

## Structure

`PwnProfileList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Profiles` | [`List<PwnProfile>`](../../doc/models/pwn-profile.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

