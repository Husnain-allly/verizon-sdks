
# Allowance Threshold

*This model accepts additional fields of type interface{}.*

## Structure

`AllowanceThreshold`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Percentage50` | `*bool` | Optional | - |
| `Percentage75` | `*bool` | Optional | - |
| `Percentage90` | `*bool` | Optional | - |
| `Percentage100` | `*bool` | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

