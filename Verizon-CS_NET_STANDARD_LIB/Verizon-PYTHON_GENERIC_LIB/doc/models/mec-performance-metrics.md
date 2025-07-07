
# Mec Performance Metrics

Response to query the most recent data for Key Performance Indicators (KPIs) like network availability, MEC hostnames and more.

*This model accepts additional fields of type Any.*

## Structure

`MecPerformanceMetrics`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `query_status` | `str` | Optional | Success or Failed. |
| `start` | `str` | Optional | Timestamp of the query's start, format:mm/dd/yyyy,hr:min:sec. |
| `end` | `str` | Optional | Timestamp of the query's end , format:mm/dd/yyyy, hr:min:sec. |
| `query_result` | [`List[MecPerformanceQueryResult]`](../../doc/models/mec-performance-query-result.md) | Optional | MEC performance query result. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

