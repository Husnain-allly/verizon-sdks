
# Pwn Profile List

*This model accepts additional fields of type interface{}.*

## Structure

`PwnProfileList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Profiles` | [`[]models.PwnProfile`](../../doc/models/pwn-profile.md) | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

