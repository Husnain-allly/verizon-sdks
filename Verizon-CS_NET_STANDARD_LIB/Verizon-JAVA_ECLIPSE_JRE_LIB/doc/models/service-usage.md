
# Service Usage

*This model accepts additional fields of type Object.*

## Structure

`ServiceUsage`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | Account identifier. | String getAccountName() | setAccountName(String accountName) |
| `TransactionsCount` | `String` | Optional | Total requests for the account during the reporting period. | String getTransactionsCount() | setTransactionsCount(String transactionsCount) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "3333355555-00001",
  "transactionsCount": "200",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

