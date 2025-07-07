
# Location Report Status

Status of the report.

*This model accepts additional fields of type Object.*

## Structure

`LocationReportStatus`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Txid` | `String` | Optional | The transaction ID of the report. | String getTxid() | setTxid(String txid) |
| `Status` | [`ReportStatus`](../../doc/models/report-status.md) | Optional | Status of the report. | ReportStatus getStatus() | setStatus(ReportStatus status) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "txid": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33",
  "status": "QUEUED",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

