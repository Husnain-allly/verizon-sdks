
# Transaction Id

The transaction ID of the request that you want to cancel, from the POST /devicelocations synchronus response.

*This model accepts additional fields of type interface{}.*

## Structure

`TransactionId`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Txid` | `*string` | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "txid": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

