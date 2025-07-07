
# Billable Usage Report

Bill usage report.

*This model accepts additional fields of type unknown.*

## Structure

`BillableUsageReport`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string \| undefined` | Optional | Account identifier. |
| `usageForAllAccounts` | `boolean \| undefined` | Optional | The usage is for a single or multiple accounts. |
| `skuName` | `string \| undefined` | Optional | SKU Name of the service subscription. |
| `transactionsAllowed` | `string \| undefined` | Optional | The number of location requests included with the subscription type. |
| `totalTransactionCount` | `string \| undefined` | Optional | The total number of billable device location requests during the reporting period from all included accounts. |
| `primaryAccount` | [`ServiceUsage \| undefined`](../../doc/models/service-usage.md) | Optional | - |
| `managedAccounts` | [`ServiceUsage[] \| undefined`](../../doc/models/service-usage.md) | Optional | Zero or more managed accounts. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

