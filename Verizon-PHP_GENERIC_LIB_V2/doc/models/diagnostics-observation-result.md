
# Diagnostics Observation Result

A success response containing the current status of the request.

*This model accepts additional fields of type array.*

## Structure

`DiagnosticsObservationResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `transactionId` | `string` | Required | Transaction identifier. | getTransactionId(): string | setTransactionId(string transactionId): void |
| `status` | `string` | Required | Status of the request. | getStatus(): string | setStatus(string status): void |
| `createdOn` | `DateTime` | Required | The date and time of when this request was created. | getCreatedOn(): \DateTime | setCreatedOn(\DateTime createdOn): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

