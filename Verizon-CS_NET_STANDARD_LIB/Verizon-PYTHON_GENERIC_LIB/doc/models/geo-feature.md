
# Geo Feature

## Structure

`GeoFeature`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mtype` | [`FeatureType`](../../doc/models/feature-type.md) | Required | - |
| `geometry` | [LineString](../../doc/models/line-string.md) \| [Polygon](../../doc/models/polygon.md) \| [MultiLineString](../../doc/models/multi-line-string.md) \| [MultiPolygon](../../doc/models/multi-polygon.md) | Required | - |
| `properties` | `Any` | Required | - |

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

