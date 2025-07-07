
# Dto Health Score Metric

## Structure

`DtoHealthScoreMetric`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Metrictype` | `String` | Optional | The type of measurement and can be overallscore, networkscore, gatewayscore, sensorscore, networkstatus, averagesignalstrength or networkavailabilitylast30 | String getMetrictype() | setMetrictype(String metrictype) |
| `Metricvalue` | `String` | Optional | the value of the `metrictype` as a percentage | String getMetricvalue() | setMetricvalue(String metricvalue) |

## Example (as JSON)

```json
{
  "metrictype": "overallscore",
  "metricvalue": "95"
}
```

