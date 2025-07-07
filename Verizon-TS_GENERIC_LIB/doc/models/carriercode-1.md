
# Carriercode 1

*This model accepts additional fields of type unknown.*

## Structure

`Carriercode1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `carrierCode` | `string \| undefined` | Optional | - |
| `percentage` | [`AllowanceThreshold \| undefined`](../../doc/models/allowance-threshold.md) | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "carrierCode": "Carrier identifier code 1",
  "percentage": {
    "percentage50": false,
    "percentage75": false,
    "percentage90": false,
    "percentage100": false,
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

