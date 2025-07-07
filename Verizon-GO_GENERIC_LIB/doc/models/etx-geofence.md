
# Etx Geofence

The GeoJSON representation of geofence. Geofence supports the following geometry types: LineString, Polygon, MultiLineString, and MultiPolygon. The system only supports a single Feature in the FeatureCollection, so only one Line, Polygon, MultiLine or MultiPolygon can be defined within one Geofencing configuration.

## Structure

`EtxGeofence`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`models.FeatureCollectionType`](../../doc/models/feature-collection-type.md) | Required | - |
| `Features` | [`[]models.GeoFeature`](../../doc/models/geo-feature.md) | Required | **Constraints**: *Minimum Items*: `1`, *Maximum Items*: `1` |

## Example (as JSON)

```json
{
  "type": "FeatureCollection",
  "features": [
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
  ]
}
```

