
# Allowance Threshold

*This model accepts additional fields of type Object.*

## Structure

`AllowanceThreshold`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Percentage50` | `Boolean` | Optional | - | Boolean getPercentage50() | setPercentage50(Boolean percentage50) |
| `Percentage75` | `Boolean` | Optional | - | Boolean getPercentage75() | setPercentage75(Boolean percentage75) |
| `Percentage90` | `Boolean` | Optional | - | Boolean getPercentage90() | setPercentage90(Boolean percentage90) |
| `Percentage100` | `Boolean` | Optional | - | Boolean getPercentage100() | setPercentage100(Boolean percentage100) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "percentage50": true,
  "percentage75": false,
  "percentage90": true,
  "percentage100": false,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

