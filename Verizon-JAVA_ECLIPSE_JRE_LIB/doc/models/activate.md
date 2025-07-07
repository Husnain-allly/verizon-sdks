
# Activate

*This model accepts additional fields of type Object.*

## Structure

`Activate`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Profile` | `String` | Required | - | String getProfile() | setProfile(String profile) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "profile": "HSS EsmProfile Enterprise 5G",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

