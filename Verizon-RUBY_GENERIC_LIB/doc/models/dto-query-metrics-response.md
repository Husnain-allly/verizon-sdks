
# Dto Query Metrics Response

## Structure

`DtoQueryMetricsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `critical` | `Integer` | Optional | The number of critical alerts in the queried time period |
| `major` | `Integer` | Optional | The number of major alerts in the queried time period |
| `minor` | `Integer` | Optional | The number of minor alerts in the queried time period |
| `noalert` | `Integer` | Optional | The number of sensor reports containing no  alerts in the queried time period |
| `total` | `Integer` | Optional | The total number of alerts in the queried time period |
| `deltacritical` | `Integer` | Optional | The change in the number of critical alerts in the queried time period |
| `deltamajor` | `Integer` | Optional | The change in the number of major alerts in the queried time period |
| `deltaminor` | `Integer` | Optional | The change in the number of minor alerts in the queried time period |
| `deltanoalert` | `Integer` | Optional | The change in the number of sensor reports containing no alerts in the queried time period |

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

