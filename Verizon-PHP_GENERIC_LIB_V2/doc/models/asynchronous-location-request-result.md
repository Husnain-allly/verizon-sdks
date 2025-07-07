
# Asynchronous Location Request Result

*This model accepts additional fields of type array.*

## Structure

`AsynchronousLocationRequestResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `txid` | `?string` | Optional | The transaction ID of the report. | getTxid(): ?string | setTxid(?string txid): void |
| `status` | [`?string(ReportStatus)`](../../doc/models/report-status.md) | Optional | Status of the report. | getStatus(): ?string | setStatus(?string status): void |
| `estimatedDuration` | `?string` | Optional | Estimated number of minutes required to complete the report. | getEstimatedDuration(): ?string | setEstimatedDuration(?string estimatedDuration): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

