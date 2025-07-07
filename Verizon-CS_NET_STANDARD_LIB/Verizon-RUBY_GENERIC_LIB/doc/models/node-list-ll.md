
# Node List Ll

The NodeListLL data structure provides the sequence of signed offset node point values for determining the latitude and longitude. Each LL point is referred to as a node point.

## Structure

`NodeListLl`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `nodes` | [`Array<NodeLl>`](../../doc/models/node-ll.md) | Required | The NodeSetLL data frame consists of a list of NodeLL entries using LL offsets.<br><br>**Constraints**: *Minimum Items*: `2`, *Maximum Items*: `63` |

## Example (as JSON)

```json
{
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
```

