
# Allowance Threshold

*This model accepts additional fields of type unknown.*

## Structure

`AllowanceThreshold`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `percentage50` | `boolean \| undefined` | Optional | - |
| `percentage75` | `boolean \| undefined` | Optional | - |
| `percentage90` | `boolean \| undefined` | Optional | - |
| `percentage100` | `boolean \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

