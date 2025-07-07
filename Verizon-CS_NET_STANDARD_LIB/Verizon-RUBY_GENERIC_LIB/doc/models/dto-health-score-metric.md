
# Dto Health Score Metric

## Structure

`DtoHealthScoreMetric`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `metrictype` | `String` | Optional | The type of measurement and can be overallscore, networkscore, gatewayscore, sensorscore, networkstatus, averagesignalstrength or networkavailabilitylast30 |
| `metricvalue` | `String` | Optional | the value of the `metrictype` as a percentage |

## Example (as JSON)

```json
{
  "metrictype": "overallscore",
  "metricvalue": "95"
}
```

