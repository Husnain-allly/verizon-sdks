
# Asynchronous Location Request Result

*This model accepts additional fields of type unknown.*

## Structure

`AsynchronousLocationRequestResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `txid` | `string \| undefined` | Optional | The transaction ID of the report. |
| `status` | [`ReportStatus \| undefined`](../../doc/models/report-status.md) | Optional | Status of the report. |
| `estimatedDuration` | `string \| undefined` | Optional | Estimated number of minutes required to complete the report. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

