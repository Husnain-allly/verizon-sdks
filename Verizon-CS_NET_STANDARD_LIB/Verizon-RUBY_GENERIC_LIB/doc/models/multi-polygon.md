
# Multi Polygon

A MultiPolygon is a type of geometry that represents a collection of Polygon geometries.

*This model accepts additional fields of type Object.*

## Structure

`MultiPolygon`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `type` | [`MultiPolygonType`](../../doc/models/multi-polygon-type.md) | Required | - |
| `coordinates` | `Array<Float>` | Required | **Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10`, `>= -180`, `<= 180` |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

