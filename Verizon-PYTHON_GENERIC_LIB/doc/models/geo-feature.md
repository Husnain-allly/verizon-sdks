
# Geo Feature

## Structure

`GeoFeature`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mtype` | [`FeatureType`](../../doc/models/feature-type.md) | Required | - |
| `geometry` | `Any` | Required | - |
| `properties` | `Any` | Required | - |

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

