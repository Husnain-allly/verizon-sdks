
# Query Mec Performance Metrics Request

MEC performance metrics request.

*This model accepts additional fields of type unknown.*

## Structure

`QueryMecPerformanceMetricsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `imei` | `string` | Required | The 15-digit International Mobile Equipment Identifier. |
| `msisdn` | `string` | Required | The 12-digit Mobile Station International Subscriber Directory Number. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "IMEI": "440246108109673",
  "MSISDN": "10691876598",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

