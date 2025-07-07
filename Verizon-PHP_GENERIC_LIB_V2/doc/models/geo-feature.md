
# Geo Feature

## Structure

`GeoFeature`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `type` | [`string(FeatureType)`](../../doc/models/feature-type.md) | Required | - | getType(): string | setType(string type): void |
| `geometry` | `array` | Required | - | getGeometry(): array | setGeometry(array geometry): void |
| `properties` | `array` | Required | - | getProperties(): array | setProperties(array properties): void |

## Example (as JSON)

```json
{
  "type": "Feature",
  "geometry": {
    "key1": "val1",
    "key2": "val2"
  },
  "properties": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

