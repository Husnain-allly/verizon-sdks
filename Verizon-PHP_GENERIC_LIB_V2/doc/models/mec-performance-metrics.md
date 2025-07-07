
# Mec Performance Metrics

Response to query the most recent data for Key Performance Indicators (KPIs) like network availability, MEC hostnames and more.

*This model accepts additional fields of type array.*

## Structure

`MecPerformanceMetrics`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `queryStatus` | `?string` | Optional | Success or Failed. | getQueryStatus(): ?string | setQueryStatus(?string queryStatus): void |
| `start` | `?string` | Optional | Timestamp of the query's start, format:mm/dd/yyyy,hr:min:sec. | getStart(): ?string | setStart(?string start): void |
| `end` | `?string` | Optional | Timestamp of the query's end , format:mm/dd/yyyy, hr:min:sec. | getEnd(): ?string | setEnd(?string end): void |
| `queryResult` | [`?(MecPerformanceQueryResult[])`](../../doc/models/mec-performance-query-result.md) | Optional | MEC performance query result. | getQueryResult(): ?array | setQueryResult(?array queryResult): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "QueryStatus": "Success",
  "Start": "1/28/2021 12:00:00",
  "End": "1/28/2021 12:15:00",
  "QueryResult": [
    {
      "name": "NetworkAvailability",
      "data": [
        "100",
        "percent",
        "high"
      ],
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

