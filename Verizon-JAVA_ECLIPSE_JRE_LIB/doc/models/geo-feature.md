
# Geo Feature

## Structure

`GeoFeature`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Type` | [`FeatureType`](../../doc/models/feature-type.md) | Required | - | FeatureType getType() | setType(FeatureType type) |
| `Geometry` | `Object` | Required | - | Object getGeometry() | setGeometry(Object geometry) |
| `Properties` | `Object` | Required | - | Object getProperties() | setProperties(Object properties) |

## Example (as JSON)

```json
{
  "type": "Feature",
  "geometry": {
    "key1": "val1",
    "key2": "val2"
  },
  "properties": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

