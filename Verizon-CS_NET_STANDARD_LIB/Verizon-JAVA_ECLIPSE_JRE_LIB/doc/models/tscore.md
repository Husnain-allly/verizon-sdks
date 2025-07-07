
# Tscore

*This model accepts additional fields of type Object.*

## Structure

`Tscore`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Profileid` | `String` | Optional | the UUID of the profile | String getProfileid() | setProfileid(String profileid) |
| `Profileversionid` | `String` | Optional | the UUID of the profile version | String getProfileversionid() | setProfileversionid(String profileversionid) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

