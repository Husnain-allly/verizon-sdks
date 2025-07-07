
# Line String

A LineString is a type of geometry that represents a collection of points that are connected by line segments.

*This model accepts additional fields of type unknown.*

## Structure

`LineString`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `type` | [`LineStringType`](../../doc/models/line-string-type.md) | Required | - |
| `coordinates` | `number[]` | Required | **Constraints**: *Minimum Items*: `2`, *Maximum Items*: `63`, `>= -180`, `<= 180` |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

