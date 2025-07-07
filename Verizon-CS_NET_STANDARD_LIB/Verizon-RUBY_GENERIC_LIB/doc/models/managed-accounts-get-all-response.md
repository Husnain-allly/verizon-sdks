
# Managed Accounts Get All Response

*This model accepts additional fields of type Object.*

## Structure

`ManagedAccountsGetAllResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Optional | Account Name |
| `managed_acc_added_list` | [`Array<ManagedAccAddedList>`](../../doc/models/managed-acc-added-list.md) | Optional | - |
| `managed_acc_provisioned_list` | [`Array<ManagedAccProvisionedList>`](../../doc/models/managed-acc-provisioned-list.md) | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

