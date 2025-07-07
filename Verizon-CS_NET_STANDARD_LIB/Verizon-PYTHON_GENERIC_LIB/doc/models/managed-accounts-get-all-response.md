
# Managed Accounts Get All Response

*This model accepts additional fields of type Any.*

## Structure

`ManagedAccountsGetAllResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Optional | Account Name |
| `managed_acc_added_list` | [`List[ManagedAccAddedList]`](../../doc/models/managed-acc-added-list.md) | Optional | - |
| `managed_acc_provisioned_list` | [`List[ManagedAccProvisionedList]`](../../doc/models/managed-acc-provisioned-list.md) | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

