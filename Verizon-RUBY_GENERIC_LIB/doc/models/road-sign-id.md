
# Road Sign Id

It provide a precise location of one or more roadside signs.

## Structure

`RoadSignId`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `position` | [`Position`](../../doc/models/position.md) | Required | It provides a precise location in the WGS-84 coordinate system, from which short offsets may be used to create additional data using a flat earth projection centered on this location. |
| `view_angle` | `String` | Required | **Constraints**: *Pattern*: ``^`[0-1]{16}`B$`` |

## Example (as JSON)

```json
{
  "position": {
    "lat": 14,
    "long": 172
  },
  "viewAngle": "`1101000100011010`B"
}
```

