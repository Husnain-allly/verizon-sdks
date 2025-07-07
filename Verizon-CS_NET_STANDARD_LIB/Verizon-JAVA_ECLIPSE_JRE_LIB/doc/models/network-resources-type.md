
# Network Resources Type

Network resources of a service profile.

## Structure

`NetworkResourcesType`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `MinBandwidthKbits` | `Integer` | Optional | Minimum required connection bandwidth in Kbit/s for the application.<br><br>**Constraints**: `>= 1`, `<= 10000` | Integer getMinBandwidthKbits() | setMinBandwidthKbits(Integer minBandwidthKbits) |
| `ServiceContinuitySupport` | `Boolean` | Optional | Indicates if service continuity support is required or not for the application. | Boolean getServiceContinuitySupport() | setServiceContinuitySupport(Boolean serviceContinuitySupport) |
| `MaxRequestRate` | `Integer` | Optional | Maximum request rate that the application can handle.<br><br>**Constraints**: `>= 1`, `<= 100` | Integer getMaxRequestRate() | setMaxRequestRate(Integer maxRequestRate) |
| `MaxLatencyMs` | `int` | Required | Maximum response time or latency that the application can handle, in milliseconds. Note: this value must be in multiples of 5.<br><br>**Constraints**: `>= 5`, `<= 1000` | int getMaxLatencyMs() | setMaxLatencyMs(int maxLatencyMs) |
| `MinAvailability` | `Integer` | Optional | Minimum availability required for the server.<br><br>**Constraints**: `>= 1`, `<= 100` | Integer getMinAvailability() | setMinAvailability(Integer minAvailability) |

## Example (as JSON)

```json
{
  "minBandwidthKbits": 1,
  "serviceContinuitySupport": true,
  "maxRequestRate": 15,
  "maxLatencyMs": 20,
  "minAvailability": 1
}
```

