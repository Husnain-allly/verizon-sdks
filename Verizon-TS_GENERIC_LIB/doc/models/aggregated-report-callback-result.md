
# Aggregated Report Callback Result

Aggregated usage report (Asynchronous).

*This model accepts additional fields of type unknown.*

## Structure

`AggregatedReportCallbackResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `txid` | `string` | Required | A unique string that associates the request with the location report information that is sent in asynchronous callback message.ThingSpace will send a separate callback message for each device that was in the request. All of the callback messages will have the same txid. |
| `status` | [`AggregatedReportCallbackStatus \| undefined`](../../doc/models/aggregated-report-callback-status.md) | Optional | QUEUED or COMPLETED. Requests for IoT devices with cacheMode=0 (cached) have status=COMPLETED; all other requests are QUEUED. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "txid": "60c07fff-470b-4d6d-afcc-75e6a7c238f6",
  "status": "QUEUED",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

