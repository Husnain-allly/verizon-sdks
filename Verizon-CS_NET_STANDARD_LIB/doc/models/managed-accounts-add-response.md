
# Managed Accounts Add Response

*This model accepts additional fields of type object.*

## Structure

`ManagedAccountsAddResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TxId` | `string` | Optional | Transaction identifier |
| `StatusList` | [`List<StatusList>`](../../doc/models/status-list.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "TxId": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33",
  "statusList": [
    {
      "id": "id6",
      "status": "status8",
      "reason": "reason8",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

