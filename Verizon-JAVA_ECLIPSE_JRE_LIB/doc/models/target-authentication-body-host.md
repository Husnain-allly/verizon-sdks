
# Target Authentication Body Host

Host information.

*This model accepts additional fields of type Object.*

## Structure

`TargetAuthenticationBodyHost`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Hostandpath` | `String` | Optional | - | String getHostandpath() | setHostandpath(String hostandpath) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "hostandpath": "https:// myhost.com:1825",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

