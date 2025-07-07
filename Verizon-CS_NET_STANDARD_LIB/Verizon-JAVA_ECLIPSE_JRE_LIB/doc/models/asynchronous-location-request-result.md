
# Asynchronous Location Request Result

*This model accepts additional fields of type Object.*

## Structure

`AsynchronousLocationRequestResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Txid` | `String` | Optional | The transaction ID of the report. | String getTxid() | setTxid(String txid) |
| `Status` | [`ReportStatus`](../../doc/models/report-status.md) | Optional | Status of the report. | ReportStatus getStatus() | setStatus(ReportStatus status) |
| `EstimatedDuration` | `String` | Optional | Estimated number of minutes required to complete the report. | String getEstimatedDuration() | setEstimatedDuration(String estimatedDuration) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "txid": "2017-12-11Te8b47da2-eeee-ffff-gggg-61815e1e97e9",
  "status": "COMPLETED",
  "estimatedDuration": "estimatedDuration2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

