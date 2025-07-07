
# Pwn Profile List

*This model accepts additional fields of type unknown.*

## Structure

`PwnProfileList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `profiles` | [`PwnProfile[] \| undefined`](../../doc/models/pwn-profile.md) | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

