
# Multi Line String

A MultiLineString is a type of geometry that represents a collection of LineString geometries.

*This model accepts additional fields of type Any.*

## Structure

`MultiLineString`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mtype` | [`MultiLineStringType`](../../doc/models/multi-line-string-type.md) | Required | - |
| `coordinates` | `List[float]` | Required | **Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10`, `>= -180`, `<= 180` |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

