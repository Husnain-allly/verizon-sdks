
# Consent Transaction Id

The transaction ID of the request that you want to cancel, from the POST /devicelocations synchronus response.

*This model accepts additional fields of type Object.*

## Structure

`ConsentTransactionId`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `TransactionId` | `String` | Optional | - | String getTransactionId() | setTransactionId(String transactionId) |
| `Status` | `String` | Optional | - | String getStatus() | setStatus(String status) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "transactionId": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33",
  "status": "QUEUED",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

