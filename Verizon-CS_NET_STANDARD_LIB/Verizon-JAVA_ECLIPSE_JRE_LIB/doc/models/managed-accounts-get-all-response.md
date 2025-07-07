
# Managed Accounts Get All Response

*This model accepts additional fields of type Object.*

## Structure

`ManagedAccountsGetAllResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | Account Name | String getAccountName() | setAccountName(String accountName) |
| `ManagedAccAddedList` | [`List<ManagedAccAddedList>`](../../doc/models/managed-acc-added-list.md) | Optional | - | List<ManagedAccAddedList> getManagedAccAddedList() | setManagedAccAddedList(List<ManagedAccAddedList> managedAccAddedList) |
| `ManagedAccProvisionedList` | [`List<ManagedAccProvisionedList>`](../../doc/models/managed-acc-provisioned-list.md) | Optional | - | List<ManagedAccProvisionedList> getManagedAccProvisionedList() | setManagedAccProvisionedList(List<ManagedAccProvisionedList> managedAccProvisionedList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

