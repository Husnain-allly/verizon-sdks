
# Multi Polygon

A MultiPolygon is a type of geometry that represents a collection of Polygon geometries.

*This model accepts additional fields of type Object.*

## Structure

`MultiPolygon`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Type` | [`MultiPolygonType`](../../doc/models/multi-polygon-type.md) | Required | - | MultiPolygonType getType() | setType(MultiPolygonType type) |
| `Coordinates` | `List<List<List<List<Double>>>>` | Required | **Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10`, `>= -180`, `<= 180` | List<List<List<List<Double>>>> getCoordinates() | setCoordinates(List<List<List<List<Double>>>> coordinates) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

