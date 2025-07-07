
# Dto Health Score Summary

The values measured are for sensors and gateways

## Structure

`DtoHealthScoreSummary`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `overallsummary` | [`?(DtoHealthScoreMetric[])`](../../doc/models/dto-health-score-metric.md) | Optional | **Constraints**: *Maximum Items*: `100` | getOverallsummary(): ?array | setOverallsummary(?array overallsummary): void |

## Example (as JSON)

```json
{
  "overallsummary": [
    {
      "metrictype": "metrictype0",
      "metricvalue": "metricvalue6"
    }
  ]
}
```

