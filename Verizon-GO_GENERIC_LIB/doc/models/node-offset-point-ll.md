
# Node Offset Point Ll

The NodeOffsetPointLL data frame presents a structure to hold 64 bits sized data frames for a single node geometry path. Nodes are described in terms of latitude and longitude.

## Structure

`NodeOffsetPointLl`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `NodeLatLon` | [`models.NodeLLmD64B`](../../doc/models/node-l-lm-d64-b.md) | Required | A 64-bit node type with lat-long values expressed in standard SAE 1/10th of a microdegree. |

## Example (as JSON)

```json
{
  "nodeLatLon": {
    "lon": 2,
    "lat": 52
  }
}
```

