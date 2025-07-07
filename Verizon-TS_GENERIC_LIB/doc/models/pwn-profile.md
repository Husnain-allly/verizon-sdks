
# Pwn Profile

*This model accepts additional fields of type unknown.*

## Structure

`PwnProfile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `profileId` | `string \| undefined` | Optional | - |
| `profileName` | `string \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

