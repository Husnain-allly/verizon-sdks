
# Location Report Status

Status of the report.

*This model accepts additional fields of type unknown.*

## Structure

`LocationReportStatus`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `txid` | `string \| undefined` | Optional | The transaction ID of the report. |
| `status` | [`ReportStatus \| undefined`](../../doc/models/report-status.md) | Optional | Status of the report. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

