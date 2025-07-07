
# Geo Feature

## Structure

`GeoFeature`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `type` | [`string(FeatureType)`](../../doc/models/feature-type.md) | Required | - | getType(): string | setType(string type): void |
| `geometry` | [LineString](../../doc/models/line-string.md)\|[Polygon](../../doc/models/polygon.md)\|Multi[LineString](../../doc/models/line-string.md)\|Multi[Polygon](../../doc/models/polygon.md) | Required | - | getGeometry(): | setGeometry( geometry): void |
| `properties` | `array` | Required | - | getProperties(): array | setProperties(array properties): void |

## Example (as JSON)

```json
{
  "type": "Feature",
  "geometry": {
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
  },
  "properties": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

