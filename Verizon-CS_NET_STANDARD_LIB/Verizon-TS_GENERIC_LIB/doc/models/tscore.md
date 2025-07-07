
# Tscore

*This model accepts additional fields of type unknown.*

## Structure

`Tscore`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `profileid` | `string \| undefined` | Optional | the UUID of the profile |
| `profileversionid` | `string \| undefined` | Optional | the UUID of the profile version |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

