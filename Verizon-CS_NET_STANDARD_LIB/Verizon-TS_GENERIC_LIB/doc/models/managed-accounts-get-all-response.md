
# Managed Accounts Get All Response

*This model accepts additional fields of type unknown.*

## Structure

`ManagedAccountsGetAllResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string \| undefined` | Optional | Account Name |
| `managedAccAddedList` | [`ManagedAccAddedList[] \| undefined`](../../doc/models/managed-acc-added-list.md) | Optional | - |
| `managedAccProvisionedList` | [`ManagedAccProvisionedList[] \| undefined`](../../doc/models/managed-acc-provisioned-list.md) | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0212312345-00001",
  "ManagedAccAddedList": [
    {
      "id": "id6",
      "txid": "txid6",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "managedAccProvisionedList": [
    {
      "id": "id2",
      "txid": "txid0",
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

