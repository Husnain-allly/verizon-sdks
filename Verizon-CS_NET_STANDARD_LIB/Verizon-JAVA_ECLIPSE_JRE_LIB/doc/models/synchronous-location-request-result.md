
# Synchronous Location Request Result

*This model accepts additional fields of type Object.*

## Structure

`SynchronousLocationRequestResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Txid` | `String` | Required | The transaction ID of the report. | String getTxid() | setTxid(String txid) |
| `Status` | [`ReportStatus`](../../doc/models/report-status.md) | Required | Status of the report. | ReportStatus getStatus() | setStatus(ReportStatus status) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "txid": "4be7c858-eeee-ffff-gggg-95061456d835",
  "status": "QUEUED",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

