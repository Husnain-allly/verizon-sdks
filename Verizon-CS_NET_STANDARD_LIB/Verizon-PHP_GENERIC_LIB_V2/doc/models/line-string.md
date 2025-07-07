
# Line String

A LineString is a type of geometry that represents a collection of points that are connected by line segments.

*This model accepts additional fields of type array.*

## Structure

`LineString`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `type` | [`string(LineStringType)`](../../doc/models/line-string-type.md) | Required | - | getType(): string | setType(string type): void |
| `coordinates` | `float[][]` | Required | **Constraints**: *Minimum Items*: `2`, *Maximum Items*: `63`, `>= -180`, `<= 180` | getCoordinates(): array | setCoordinates(array coordinates): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

