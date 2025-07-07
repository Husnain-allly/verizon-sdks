
# Consent Transaction Id

The transaction ID of the request that you want to cancel, from the POST /devicelocations synchronus response.

*This model accepts additional fields of type unknown.*

## Structure

`ConsentTransactionId`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transactionId` | `string \| undefined` | Optional | - |
| `status` | `string \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

