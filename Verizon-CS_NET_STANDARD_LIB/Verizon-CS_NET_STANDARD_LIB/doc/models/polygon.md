
# Polygon

A Polygon is a type of geometry that represents a collection of points that form a closed ring.

NOTE: This API only supports a single polygon in the Polygon geometry, so holes cannot be defines at this point. Support for hole will be added in future releases.

*This model accepts additional fields of type object.*

## Structure

`Polygon`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`PolygonType`](../../doc/models/polygon-type.md) | Required | - |
| `Coordinates` | `List<List<List<double>>>` | Required | **Constraints**: *Minimum Items*: `1`, *Maximum Items*: `1`, `>= -180`, `<= 180` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "type": "Polygon",
  "coordinates": [
    [
      [
        180.0
      ]
    ]
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

