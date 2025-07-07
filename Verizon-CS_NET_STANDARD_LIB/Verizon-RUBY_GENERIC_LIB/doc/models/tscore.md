
# Tscore

*This model accepts additional fields of type Object.*

## Structure

`Tscore`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `profileid` | `String` | Optional | the UUID of the profile |
| `profileversionid` | `String` | Optional | the UUID of the profile version |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

