
# Offset System

The OffsetSystem data frame selects a sequence of node offsets described in the Lat-Long offset method.

## Structure

`OffsetSystem`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `offset` | [`Offset`](../../doc/models/offset.md) | Required | The sequence of node offsets then describes a path or polygon in the Lat-Long system. | getOffset(): Offset | setOffset(Offset offset): void |

## Example (as JSON)

```json
{
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
```

