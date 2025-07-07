
# Geo Feature

## Structure

`GeoFeature`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`models.FeatureType`](../../doc/models/feature-type.md) | Required | - |
| `Geometry` | `interface{}` | Required | - |
| `Properties` | `interface{}` | Required | - |

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

