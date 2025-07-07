
# Location Report Status

Status of the report.

*This model accepts additional fields of type Object.*

## Structure

`LocationReportStatus`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `txid` | `String` | Optional | The transaction ID of the report. |
| `status` | [`ReportStatus`](../../doc/models/report-status.md) | Optional | Status of the report. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

