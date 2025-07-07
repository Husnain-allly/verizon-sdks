
# Geo Fence Configuration Update Request

Request for /api/v1/application/configurations/geofence PUT endpoint. It requires at least one of vendorId, name, description, geofence, messages and isActive fields to be populated.

## Structure

`GeoFenceConfigurationUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `String` | Optional | Name of the configuration.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `256`, *Pattern*: ``^[\w\+\-!()\`\[\]{=};\"':,.\/<>?\|\s]+$`` |
| `description` | `String` | Optional | Description of the configuration.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2048`, *Pattern*: ``^[\w\+\-!()\`\[\]{=};\"':,.\/<>?\|\s]+$`` |
| `geo_fence` | [`EtxGeofence`](../../doc/models/etx-geofence.md) | Optional | The GeoJSON representation of geofence. Geofence supports the following geometry types: LineString, Polygon, MultiLineString, and MultiPolygon. The system only supports a single Feature in the FeatureCollection, so only one Line, Polygon, MultiLine or MultiPolygon can be defined within one Geofencing configuration. |
| `messages` | `Array<Object>` | Optional | List of predefined messages that belongs to the geofence. These are the messages that are sent out by the system when the Trigger Condition for the message is met.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10` |
| `is_active` | `TrueClass \| FalseClass` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name4",
  "description": "description4",
  "geoFence": {
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
  },
  "messages": [
    {
      "key1": "val1",
      "key2": "val2"
    }
  ],
  "isActive": false
}
```

