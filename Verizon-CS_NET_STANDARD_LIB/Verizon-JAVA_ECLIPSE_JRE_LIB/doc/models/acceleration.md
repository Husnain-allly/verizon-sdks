
# Acceleration

*This model accepts additional fields of type Object.*

## Structure

`Acceleration`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `X` | `String` | Optional | - | String getX() | setX(String x) |
| `Y` | `String` | Optional | - | String getY() | setY(String y) |
| `Z` | `String` | Optional | - | String getZ() | setZ(String z) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "x": "0.0277",
  "y": "-1.0334",
  "z": "-0.0134",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

