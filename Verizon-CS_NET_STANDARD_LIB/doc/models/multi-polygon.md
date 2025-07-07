
# Multi Polygon

A MultiPolygon is a type of geometry that represents a collection of Polygon geometries.

*This model accepts additional fields of type object.*

## Structure

`MultiPolygon`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`MultiPolygonType`](../../doc/models/multi-polygon-type.md) | Required | - |
| `Coordinates` | `List<List<List<List<double>>>>` | Required | **Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10`, `>= -180`, `<= 180` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "type": "MultiPolygon",
  "coordinates": [
    [
      [
        [
          46.55
        ]
      ]
    ]
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

