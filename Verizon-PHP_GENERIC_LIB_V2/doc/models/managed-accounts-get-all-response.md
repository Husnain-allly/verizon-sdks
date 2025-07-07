
# Managed Accounts Get All Response

*This model accepts additional fields of type array.*

## Structure

`ManagedAccountsGetAllResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `?string` | Optional | Account Name | getAccountName(): ?string | setAccountName(?string accountName): void |
| `managedAccAddedList` | [`?(ManagedAccAddedList[])`](../../doc/models/managed-acc-added-list.md) | Optional | - | getManagedAccAddedList(): ?array | setManagedAccAddedList(?array managedAccAddedList): void |
| `managedAccProvisionedList` | [`?(ManagedAccProvisionedList[])`](../../doc/models/managed-acc-provisioned-list.md) | Optional | - | getManagedAccProvisionedList(): ?array | setManagedAccProvisionedList(?array managedAccProvisionedList): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

