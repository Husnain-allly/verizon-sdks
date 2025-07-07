
# Geo Feature

## Structure

`GeoFeature`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `type` | [`FeatureType`](../../doc/models/feature-type.md) | Required | - |
| `geometry` | [`Geometry`](../../doc/models/containers/geometry.md) | Required | - |
| `properties` | `unknown` | Required | - |

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

