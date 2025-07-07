
# Geo Fence Configuration Request

Request for /api/v1/application/configurations/geofence POST endpoint. It requires the vendorId, geofence, messages and isActive fields to be populated.

## Structure

`GeoFenceConfigurationRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `str` | Optional | Name of the configuration.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `256`, *Pattern*: ``^[\w\+\-!()\`\[\]{=};\"':,.\/<>?\|\s]+$`` |
| `description` | `str` | Optional | Description of the configuration.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2048`, *Pattern*: ``^[\w\+\-!()\`\[\]{=};\"':,.\/<>?\|\s]+$`` |
| `geo_fence` | [`EtxGeofence`](../../doc/models/etx-geofence.md) | Required | The GeoJSON representation of geofence. Geofence supports the following geometry types: LineString, Polygon, MultiLineString, and MultiPolygon. The system only supports a single Feature in the FeatureCollection, so only one Line, Polygon, MultiLine or MultiPolygon can be defined within one Geofencing configuration. |
| `messages` | List[[Message](../../doc/models/message.md) \| [Message1](../../doc/models/message-1.md) \| [Message2](../../doc/models/message-2.md)] | Required | List of predefined messages that belongs to the geofence. These are the messages that are sent out by the system when the Trigger Condition for the message is met.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10` |
| `is_active` | `bool` | Required | - |

## Example (as JSON)

```json
{
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
    },
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
  "isActive": false,
  "name": "name6",
  "description": "description4"
}
```

