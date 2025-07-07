
# Billable Usage Report

Bill usage report.

*This model accepts additional fields of type Object.*

## Structure

`BillableUsageReport`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | Account identifier. | String getAccountName() | setAccountName(String accountName) |
| `UsageForAllAccounts` | `Boolean` | Optional | The usage is for a single or multiple accounts. | Boolean getUsageForAllAccounts() | setUsageForAllAccounts(Boolean usageForAllAccounts) |
| `SkuName` | `String` | Optional | SKU Name of the service subscription. | String getSkuName() | setSkuName(String skuName) |
| `TransactionsAllowed` | `String` | Optional | The number of location requests included with the subscription type. | String getTransactionsAllowed() | setTransactionsAllowed(String transactionsAllowed) |
| `TotalTransactionCount` | `String` | Optional | The total number of billable device location requests during the reporting period from all included accounts. | String getTotalTransactionCount() | setTotalTransactionCount(String totalTransactionCount) |
| `PrimaryAccount` | [`ServiceUsage`](../../doc/models/service-usage.md) | Optional | - | ServiceUsage getPrimaryAccount() | setPrimaryAccount(ServiceUsage primaryAccount) |
| `ManagedAccounts` | [`List<ServiceUsage>`](../../doc/models/service-usage.md) | Optional | Zero or more managed accounts. | List<ServiceUsage> getManagedAccounts() | setManagedAccounts(List<ServiceUsage> managedAccounts) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "1223334444-00001",
  "usageForAllAccounts": false,
  "skuName": "TS-LOC-COARSE-CellID-Aggr",
  "transactionsAllowed": "5000",
  "totalTransactionCount": "350",
  "PrimaryAccount": {
    "accountName": "1223334444-00001",
    "transactionsCount": "125"
  },
  "ManagedAccounts": [],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

