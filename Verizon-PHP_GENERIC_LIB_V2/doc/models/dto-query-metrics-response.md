
# Dto Query Metrics Response

## Structure

`DtoQueryMetricsResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `critical` | `?int` | Optional | The number of critical alerts in the queried time period | getCritical(): ?int | setCritical(?int critical): void |
| `major` | `?int` | Optional | The number of major alerts in the queried time period | getMajor(): ?int | setMajor(?int major): void |
| `minor` | `?int` | Optional | The number of minor alerts in the queried time period | getMinor(): ?int | setMinor(?int minor): void |
| `noalert` | `?int` | Optional | The number of sensor reports containing no  alerts in the queried time period | getNoalert(): ?int | setNoalert(?int noalert): void |
| `total` | `?int` | Optional | The total number of alerts in the queried time period | getTotal(): ?int | setTotal(?int total): void |
| `deltacritical` | `?int` | Optional | The change in the number of critical alerts in the queried time period | getDeltacritical(): ?int | setDeltacritical(?int deltacritical): void |
| `deltamajor` | `?int` | Optional | The change in the number of major alerts in the queried time period | getDeltamajor(): ?int | setDeltamajor(?int deltamajor): void |
| `deltaminor` | `?int` | Optional | The change in the number of minor alerts in the queried time period | getDeltaminor(): ?int | setDeltaminor(?int deltaminor): void |
| `deltanoalert` | `?int` | Optional | The change in the number of sensor reports containing no alerts in the queried time period | getDeltanoalert(): ?int | setDeltanoalert(?int deltanoalert): void |

## Example (as JSON)

```json
{
  "critical": 0,
  "major": 0,
  "minor": 0,
  "noalert": 1,
  "total": 1,
  "deltacritical": -3,
  "deltamajor": -1,
  "deltaminor": 0,
  "deltanoalert": -15
}
```

