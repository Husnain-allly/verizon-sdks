
# Allowance Threshold

*This model accepts additional fields of type Any.*

## Structure

`AllowanceThreshold`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `percentage_50` | `bool` | Optional | - |
| `percentage_75` | `bool` | Optional | - |
| `percentage_90` | `bool` | Optional | - |
| `percentage_100` | `bool` | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

