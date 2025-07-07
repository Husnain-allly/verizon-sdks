
# Query Mec Performance Metrics Request

MEC performance metrics request.

*This model accepts additional fields of type array.*

## Structure

`QueryMecPerformanceMetricsRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `imei` | `string` | Required | The 15-digit International Mobile Equipment Identifier. | getImei(): string | setImei(string imei): void |
| `msisdn` | `string` | Required | The 12-digit Mobile Station International Subscriber Directory Number. | getMsisdn(): string | setMsisdn(string msisdn): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

