
# Geo Fence Configuration Response

Response for /api/v1/application/configurations/geofence endpoint. It provides a response if the configuration was created and saved in the system.

## Structure

`GeoFenceConfigurationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | The generated ID (UUID v4) for the configuration. It has to be used when asking for changing any of the configuration parameters.<br><br>**Constraints**: *Minimum Length*: `32`, *Maximum Length*: `36`, *Pattern*: `^[0-9a-fA-F]{8}-?[0-9a-fA-F]{4}-?4[0-9a-fA-F]{3}-?[89abAB][0-9a-fA-F]{3}-?[0-9a-fA-F]{12}$` |
| `VendorId` | `string` | Required | The vendor that the configuration belongs to. E.g. Verizon, GM, Ford, etc.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `Name` | `string` | Optional | Name of the configuration.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `256`, *Pattern*: ``^[\w\+\-!()\`\[\]{=};\"':,.\/<>?\|\s]+$`` |
| `Description` | `string` | Optional | Description of the configuration.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2048`, *Pattern*: ``^[\w\+\-!()\`\[\]{=};\"':,.\/<>?\|\s]+$`` |
| `GeoFence` | [`EtxGeofence`](../../doc/models/etx-geofence.md) | Required | The GeoJSON representation of geofence. Geofence supports the following geometry types: LineString, Polygon, MultiLineString, and MultiPolygon. The system only supports a single Feature in the FeatureCollection, so only one Line, Polygon, MultiLine or MultiPolygon can be defined within one Geofencing configuration. |
| `Messages` | [`List<Message3>`](../../doc/models/containers/message-3.md) | Required | List of predefined messages that belongs to the geofence. These are the messages that are sent out by the system when the Trigger Condition for the message is met.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10` |
| `IsActive` | `bool` | Required | - |

## Example (as JSON)

```json
{
  "id": "a4fcd16a-343d-4527-8203-2f46e3e4ff4b",
  "vendorId": "VerizonETX",
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
  "name": "name0",
  "description": "description0"
}
```

