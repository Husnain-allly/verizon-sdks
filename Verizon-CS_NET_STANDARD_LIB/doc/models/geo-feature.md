
# Geo Feature

## Structure

`GeoFeature`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`FeatureType`](../../doc/models/feature-type.md) | Required | - |
| `Geometry` | `object` | Required | - |
| `Properties` | `object` | Required | - |

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

