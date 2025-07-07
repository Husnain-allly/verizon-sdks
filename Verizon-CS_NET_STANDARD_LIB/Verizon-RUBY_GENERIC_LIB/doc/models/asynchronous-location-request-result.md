
# Asynchronous Location Request Result

*This model accepts additional fields of type Object.*

## Structure

`AsynchronousLocationRequestResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `txid` | `String` | Optional | The transaction ID of the report. |
| `status` | [`ReportStatus`](../../doc/models/report-status.md) | Optional | Status of the report. |
| `estimated_duration` | `String` | Optional | Estimated number of minutes required to complete the report. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

