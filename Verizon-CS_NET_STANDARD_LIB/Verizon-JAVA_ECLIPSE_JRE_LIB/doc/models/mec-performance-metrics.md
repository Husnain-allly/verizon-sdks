
# Mec Performance Metrics

Response to query the most recent data for Key Performance Indicators (KPIs) like network availability, MEC hostnames and more.

*This model accepts additional fields of type Object.*

## Structure

`MecPerformanceMetrics`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `QueryStatus` | `String` | Optional | Success or Failed. | String getQueryStatus() | setQueryStatus(String queryStatus) |
| `Start` | `String` | Optional | Timestamp of the query's start, format:mm/dd/yyyy,hr:min:sec. | String getStart() | setStart(String start) |
| `End` | `String` | Optional | Timestamp of the query's end , format:mm/dd/yyyy, hr:min:sec. | String getEnd() | setEnd(String end) |
| `QueryResult` | [`List<MecPerformanceQueryResult>`](../../doc/models/mec-performance-query-result.md) | Optional | MEC performance query result. | List<MecPerformanceQueryResult> getQueryResult() | setQueryResult(List<MecPerformanceQueryResult> queryResult) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

