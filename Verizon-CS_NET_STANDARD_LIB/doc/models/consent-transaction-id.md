
# Consent Transaction Id

The transaction ID of the request that you want to cancel, from the POST /devicelocations synchronus response.

*This model accepts additional fields of type object.*

## Structure

`ConsentTransactionId`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TransactionId` | `string` | Optional | - |
| `Status` | `string` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

