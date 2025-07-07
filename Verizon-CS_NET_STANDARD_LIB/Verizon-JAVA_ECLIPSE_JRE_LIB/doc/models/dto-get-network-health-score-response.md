
# Dto Get Network Health Score Response

The values measured are for the network

## Structure

`DtoGetNetworkHealthScoreResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Networksummary` | [`List<DtoHealthScoreMetric>`](../../doc/models/dto-health-score-metric.md) | Optional | **Constraints**: *Maximum Items*: `100` | List<DtoHealthScoreMetric> getNetworksummary() | setNetworksummary(List<DtoHealthScoreMetric> networksummary) |
| `Overallsummary` | [`List<DtoHealthScoreMetric>`](../../doc/models/dto-health-score-metric.md) | Optional | **Constraints**: *Maximum Items*: `100` | List<DtoHealthScoreMetric> getOverallsummary() | setOverallsummary(List<DtoHealthScoreMetric> overallsummary) |

## Example (as JSON)

```json
{
  "networksummary": [
    {
      "metrictype": "networkscore",
      "metricvalue": "95"
    }
  ],
  "overallsummary": [
    {
      "metrictype": "metrictype0",
      "metricvalue": "metricvalue6"
    }
  ]
}
```

