
# Geographical Path Description

This data frame can describe a complex path of arbitrary size using node offset method (LL offsets).

## Structure

`GeographicalPathDescription`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Path` | [`OffsetSystem`](../../doc/models/offset-system.md) | Required | The OffsetSystem data frame selects a sequence of node offsets described in the Lat-Long offset method. | OffsetSystem getPath() | setPath(OffsetSystem path) |

## Example (as JSON)

```json
{
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
          }
        ]
      }
    }
  }
}
```

