
# Geo Fence Configuration Update Request

Request for /api/v1/application/configurations/geofence PUT endpoint. It requires at least one of vendorId, name, description, geofence, messages and isActive fields to be populated.

## Structure

`GeoFenceConfigurationUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name of the configuration.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `256`, *Pattern*: ``^[\w\+\-!()\`\[\]{=};\"':,.\/<>?\|\s]+$`` |
| `Description` | `string` | Optional | Description of the configuration.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2048`, *Pattern*: ``^[\w\+\-!()\`\[\]{=};\"':,.\/<>?\|\s]+$`` |
| `GeoFence` | [`EtxGeofence`](../../doc/models/etx-geofence.md) | Optional | The GeoJSON representation of geofence. Geofence supports the following geometry types: LineString, Polygon, MultiLineString, and MultiPolygon. The system only supports a single Feature in the FeatureCollection, so only one Line, Polygon, MultiLine or MultiPolygon can be defined within one Geofencing configuration. |
| `Messages` | [`List<Message3>`](../../doc/models/containers/message-3.md) | Optional | List of predefined messages that belongs to the geofence. These are the messages that are sent out by the system when the Trigger Condition for the message is met.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10` |
| `IsActive` | `bool?` | Optional | - |

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
    ]
  },
  "messages": [
    {
      "isPrivate": false,
      "roadUserType": [
        "VulnerableRoadUser"
      ],
      "triggerConditions": [
        "crossing"
      ],
      "limits": [
        {
          "speed": {
            "min": 64.76,
            "max": 138.18
          },
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ],
      "distributionType": [
        "Broadcast",
        "Targeted"
      ],
      "distributionSchedule": {
        "repeatPeriod": 90,
        "duration": 88,
        "startTime": "2016-03-13T12:52:32.123Z"
      },
      "generic": {
        "messageType": "messageType4",
        "messageFormat": "messageFormat6",
        "payload": "payload0"
      },
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "isActive": false
}
```

