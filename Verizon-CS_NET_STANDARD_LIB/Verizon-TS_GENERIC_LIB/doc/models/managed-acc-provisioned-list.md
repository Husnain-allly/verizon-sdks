
# Managed Acc Provisioned List

*This model accepts additional fields of type unknown.*

## Structure

`ManagedAccProvisionedList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string \| undefined` | Optional | Account name |
| `txid` | `string \| undefined` | Optional | Transaction identifier |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "id": "2334445555-00001",
  "txid": "d4fbff33-eeee-ffff-gggg-2c90bd287e3b",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

