
# Synchronous Location Request Result

*This model accepts additional fields of type object.*

## Structure

`SynchronousLocationRequestResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Txid` | `string` | Required | The transaction ID of the report. |
| `Status` | [`ReportStatus`](../../doc/models/report-status.md) | Required | Status of the report. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

