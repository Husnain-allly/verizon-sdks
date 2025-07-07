
# Tscore

*This model accepts additional fields of type object.*

## Structure

`Tscore`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Profileid` | `string` | Optional | the UUID of the profile |
| `Profileversionid` | `string` | Optional | the UUID of the profile version |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

