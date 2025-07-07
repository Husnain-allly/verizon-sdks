
# Geo Feature

## Structure

`GeoFeature`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`FeatureType`](../../doc/models/feature-type.md) | Required | - |
| `Geometry` | [`Geometry`](../../doc/models/containers/geometry.md) | Required | - |
| `Properties` | `object` | Required | - |

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

