
# Asynchronous Location Request Result

*This model accepts additional fields of type object.*

## Structure

`AsynchronousLocationRequestResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Txid` | `string` | Optional | The transaction ID of the report. |
| `Status` | [`ReportStatus?`](../../doc/models/report-status.md) | Optional | Status of the report. |
| `EstimatedDuration` | `string` | Optional | Estimated number of minutes required to complete the report. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

