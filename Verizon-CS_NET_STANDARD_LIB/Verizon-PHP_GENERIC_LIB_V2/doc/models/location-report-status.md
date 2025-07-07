
# Location Report Status

Status of the report.

*This model accepts additional fields of type array.*

## Structure

`LocationReportStatus`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `txid` | `?string` | Optional | The transaction ID of the report. | getTxid(): ?string | setTxid(?string txid): void |
| `status` | [`?string(ReportStatus)`](../../doc/models/report-status.md) | Optional | Status of the report. | getStatus(): ?string | setStatus(?string status): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

