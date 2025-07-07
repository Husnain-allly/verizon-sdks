
# Dto Query Metrics Response

## Structure

`DtoQueryMetricsResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Critical` | `Integer` | Optional | The number of critical alerts in the queried time period | Integer getCritical() | setCritical(Integer critical) |
| `Major` | `Integer` | Optional | The number of major alerts in the queried time period | Integer getMajor() | setMajor(Integer major) |
| `Minor` | `Integer` | Optional | The number of minor alerts in the queried time period | Integer getMinor() | setMinor(Integer minor) |
| `Noalert` | `Integer` | Optional | The number of sensor reports containing no  alerts in the queried time period | Integer getNoalert() | setNoalert(Integer noalert) |
| `Total` | `Integer` | Optional | The total number of alerts in the queried time period | Integer getTotal() | setTotal(Integer total) |
| `Deltacritical` | `Integer` | Optional | The change in the number of critical alerts in the queried time period | Integer getDeltacritical() | setDeltacritical(Integer deltacritical) |
| `Deltamajor` | `Integer` | Optional | The change in the number of major alerts in the queried time period | Integer getDeltamajor() | setDeltamajor(Integer deltamajor) |
| `Deltaminor` | `Integer` | Optional | The change in the number of minor alerts in the queried time period | Integer getDeltaminor() | setDeltaminor(Integer deltaminor) |
| `Deltanoalert` | `Integer` | Optional | The change in the number of sensor reports containing no alerts in the queried time period | Integer getDeltanoalert() | setDeltanoalert(Integer deltanoalert) |

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

