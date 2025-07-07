
# Diagnostics Observation Result

A success response containing the current status of the request.

*This model accepts additional fields of type Object.*

## Structure

`DiagnosticsObservationResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transaction_id` | `String` | Required | Transaction identifier. |
| `status` | `String` | Required | Status of the request. |
| `created_on` | `DateTime` | Required | The date and time of when this request was created. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "createdOn": "2019-09-10T19:05:33.33Z",
  "transactionID": "9c7bb124-11f5-4ff3-8a88-0eec1ba99205",
  "status": "CANCEL_OBSERVE_PENDING",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

