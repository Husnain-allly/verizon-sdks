
# Line String

A LineString is a type of geometry that represents a collection of points that are connected by line segments.

*This model accepts additional fields of type Object.*

## Structure

`LineString`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Type` | [`LineStringType`](../../doc/models/line-string-type.md) | Required | - | LineStringType getType() | setType(LineStringType type) |
| `Coordinates` | `List<List<Double>>` | Required | **Constraints**: *Minimum Items*: `2`, *Maximum Items*: `63`, `>= -180`, `<= 180` | List<List<Double>> getCoordinates() | setCoordinates(List<List<Double>> coordinates) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "type": "LineString",
  "coordinates": [
    [
      51.53,
      51.54
    ],
    [
      51.53,
      51.54
    ]
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

