
# Multi Line String

A MultiLineString is a type of geometry that represents a collection of LineString geometries.

*This model accepts additional fields of type unknown.*

## Structure

`MultiLineString`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `type` | [`MultiLineStringType`](../../doc/models/multi-line-string-type.md) | Required | - |
| `coordinates` | `number[]` | Required | **Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10`, `>= -180`, `<= 180` |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

