
# Query Mec Performance Metrics Request

MEC performance metrics request.

*This model accepts additional fields of type Object.*

## Structure

`QueryMecPerformanceMetricsRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Imei` | `String` | Required | The 15-digit International Mobile Equipment Identifier. | String getImei() | setImei(String imei) |
| `Msisdn` | `String` | Required | The 12-digit Mobile Station International Subscriber Directory Number. | String getMsisdn() | setMsisdn(String msisdn) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

