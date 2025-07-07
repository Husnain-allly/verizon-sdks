
# Dto Health Score Metric

## Structure

`DtoHealthScoreMetric`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `metrictype` | `?string` | Optional | The type of measurement and can be overallscore, networkscore, gatewayscore, sensorscore, networkstatus, averagesignalstrength or networkavailabilitylast30 | getMetrictype(): ?string | setMetrictype(?string metrictype): void |
| `metricvalue` | `?string` | Optional | the value of the `metrictype` as a percentage | getMetricvalue(): ?string | setMetricvalue(?string metricvalue): void |

## Example (as JSON)

```json
{
  "metrictype": "overallscore",
  "metricvalue": "95"
}
```

