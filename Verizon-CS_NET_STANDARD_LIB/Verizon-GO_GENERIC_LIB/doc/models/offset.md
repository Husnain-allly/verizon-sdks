
# Offset

The sequence of node offsets then describes a path or polygon in the Lat-Long system.

## Structure

`Offset`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Ll` | [`models.NodeListLl`](../../doc/models/node-list-ll.md) | Required | The NodeListLL data structure provides the sequence of signed offset node point values for determining the latitude and longitude. Each LL point is referred to as a node point. |

## Example (as JSON)

```json
{
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
```

