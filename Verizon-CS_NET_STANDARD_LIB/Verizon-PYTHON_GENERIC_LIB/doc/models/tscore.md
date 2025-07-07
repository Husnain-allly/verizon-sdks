
# Tscore

*This model accepts additional fields of type Any.*

## Structure

`Tscore`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `profileid` | `str` | Optional | the UUID of the profile |
| `profileversionid` | `str` | Optional | the UUID of the profile version |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

