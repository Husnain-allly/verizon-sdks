
# Geo Feature

## Structure

`GeoFeature`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Type` | [`FeatureType`](../../doc/models/feature-type.md) | Required | - | FeatureType getType() | setType(FeatureType type) |
| `Geometry` | [`Geometry`](../../doc/models/containers/geometry.md) | Required | - | Geometry getGeometry() | setGeometry(Geometry geometry) |
| `Properties` | `Object` | Required | - | Object getProperties() | setProperties(Object properties) |

## Example (as JSON)

```json
{
  "type": "Feature",
  "geometry": {
    "type": "LineString",
    "coordinates": [
      [
        51.53,
        51.54
      ],
      [
        51.53,
        51.54
      ]
    ],
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "properties": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

