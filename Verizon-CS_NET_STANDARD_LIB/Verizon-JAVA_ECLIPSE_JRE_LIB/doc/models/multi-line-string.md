
# Multi Line String

A MultiLineString is a type of geometry that represents a collection of LineString geometries.

*This model accepts additional fields of type Object.*

## Structure

`MultiLineString`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Type` | [`MultiLineStringType`](../../doc/models/multi-line-string-type.md) | Required | - | MultiLineStringType getType() | setType(MultiLineStringType type) |
| `Coordinates` | `List<List<List<Double>>>` | Required | **Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10`, `>= -180`, `<= 180` | List<List<List<Double>>> getCoordinates() | setCoordinates(List<List<List<Double>>> coordinates) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "type": "MultiLineString",
  "coordinates": [
    [
      [
        180.0,
        180.0
      ],
      [
        180.0,
        180.0
      ]
    ],
    [
      [
        180.0,
        180.0
      ],
      [
        180.0,
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

