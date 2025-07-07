
# Synchronous Location Request Result

*This model accepts additional fields of type array.*

## Structure

`SynchronousLocationRequestResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `txid` | `string` | Required | The transaction ID of the report. | getTxid(): string | setTxid(string txid): void |
| `status` | [`string(ReportStatus)`](../../doc/models/report-status.md) | Required | Status of the report. | getStatus(): string | setStatus(string status): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

