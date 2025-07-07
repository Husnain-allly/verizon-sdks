
# Dto Get Network Health Score Response

The values measured are for the network

## Structure

`DtoGetNetworkHealthScoreResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `networksummary` | [`?(DtoHealthScoreMetric[])`](../../doc/models/dto-health-score-metric.md) | Optional | **Constraints**: *Maximum Items*: `100` | getNetworksummary(): ?array | setNetworksummary(?array networksummary): void |
| `overallsummary` | [`?(DtoHealthScoreMetric[])`](../../doc/models/dto-health-score-metric.md) | Optional | **Constraints**: *Maximum Items*: `100` | getOverallsummary(): ?array | setOverallsummary(?array overallsummary): void |

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

