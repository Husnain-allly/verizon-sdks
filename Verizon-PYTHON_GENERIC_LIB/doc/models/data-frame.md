
# Data Frame

The data frame allows sending various advisory and road sign types of information to equipped devices.

## Structure

`DataFrame`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `not_used` | `int` | Required | Always set to 0 and carries no meaning. Legacy field maintained for backward compatibility.<br><br>**Constraints**: `>= 0`, `<= 31` |
| `frame_type` | [`FrameType`](../../doc/models/frame-type.md) | Required | The frameType data element provides the type of message to follow in the rest of the message frame structure. The following frame types are supported:<br><br>- unknown<br>- advisory<br>- roadSignage<br>- commercialSignage |
| `msg_id` | `Any` | Required | - |
| `start_year` | `int` | Optional | The V2X year consists of integer values from zero to 4095 representing the year according to the Gregorian calendar date system. The value of zero shall represent an unknown value.<br><br>**Constraints**: `>= 0`, `<= 4095` |
| `start_time` | `int` | Required | Start time expresses the number of elapsed minutes of the current year in the time system being used (typically UTC time). The value 527040 shall be used for invalid.<br><br>**Constraints**: `>= 0`, `<= 527040` |
| `duration_time` | `int` | Required | The duration, in units of whole minutes, that a object persists for. A value of 32000 means that the object persists forever. The range 0..32000 provides for about 22.2 days of maximum duration.<br><br>**Constraints**: `>= 0`, `<= 32000` |
| `priority` | `int` | Required | The relative importance of the sign, on a scale from zero (least important) to seven (most important).<br><br>**Constraints**: `>= 0`, `<= 7` |
| `not_used_1` | `int` | Required | Always set to 0 and carries no meaning. Legacy field maintained for backward compatibility.<br><br>**Constraints**: `>= 0`, `<= 31` |
| `regions` | [`List[GeographicalPath]`](../../doc/models/geographical-path.md) | Required | The data frame is used to support the cross-cutting need in many V2X messages to describe arbitrary spatial areas (polygons, boundary lines, and other basic shapes) required by various message types in a small message size. This data frame can describe a complex path or region of arbitrary size using either one of the two supported node offset methods (XY offsets or LL offsets) or using simple geometric projections.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `16` |
| `not_used_2` | `int` | Required | Always set to 0 and carries no meaning. Legacy field maintained for backward compatibility.<br><br>**Constraints**: `>= 0`, `<= 31` |
| `not_used_3` | `int` | Required | Always set to 0 and carries no meaning. Legacy field maintained for backward compatibility.<br><br>**Constraints**: `>= 0`, `<= 31` |
| `content` | `Any` | Required | - |

## Example (as JSON)

```json
{
  "notUsed": 31,
  "frameType": "unknown",
  "msgId": {
    "key1": "val1",
    "key2": "val2"
  },
  "startTime": 66,
  "durationTime": 92,
  "priority": 7,
  "notUsed1": 31,
  "regions": [
    {
      "direction": "`1101000100011010`B",
      "description": {
        "path": {
          "offset": {
            "ll": {
              "nodes": [
                {
                  "delta": {
                    "nodeLatLon": {
                      "lon": 2,
                      "lat": 52
                    }
                  }
                },
                {
                  "delta": {
                    "nodeLatLon": {
                      "lon": 2,
                      "lat": 52
                    }
                  }
                }
              ]
            }
          }
        }
      }
    }
  ],
  "notUsed2": 31,
  "notUsed3": 31,
  "content": {
    "key1": "val1",
    "key2": "val2"
  },
  "startYear": 124
}
```

