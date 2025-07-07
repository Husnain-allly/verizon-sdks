
# Geographical Path

The data frame is used to support the cross-cutting need in many V2X messages to describe arbitrary spatial areas (polygons, boundary lines, and other basic shapes) required by various message types in a small message size.

## Structure

`GeographicalPath`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `description` | [`GeographicalPathDescription \| undefined`](../../doc/models/geographical-path-description.md) | Optional | This data frame can describe a complex path of arbitrary size using node offset method (LL offsets). |
| `direction` | `string \| undefined` | Optional | **Constraints**: *Pattern*: ``^`[0-1]{16}`B$`` |

## Example (as JSON)

```json
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
```

