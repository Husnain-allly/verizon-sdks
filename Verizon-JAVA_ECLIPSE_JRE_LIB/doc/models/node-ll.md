
# Node Ll

The NodeLL data frame presents a structure to hold data for a signal node point in a lane. Each selected node has a complete lat-long representation.

## Structure

`NodeLl`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Delta` | [`NodeOffsetPointLl`](../../doc/models/node-offset-point-ll.md) | Required | The NodeOffsetPointLL data frame presents a structure to hold 64 bits sized data frames for a single node geometry path. Nodes are described in terms of latitude and longitude. | NodeOffsetPointLl getDelta() | setDelta(NodeOffsetPointLl delta) |

## Example (as JSON)

```json
{
  "delta": {
    "nodeLatLon": {
      "lon": 2,
      "lat": 52
    }
  }
}
```

