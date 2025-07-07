
# Location Report Status

Status of the report.

*This model accepts additional fields of type interface{}.*

## Structure

`LocationReportStatus`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Txid` | `*string` | Optional | The transaction ID of the report. |
| `Status` | [`*models.ReportStatus`](../../doc/models/report-status.md) | Optional | Status of the report. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

