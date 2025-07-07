
# Service Usage

*This model accepts additional fields of type Object.*

## Structure

`ServiceUsage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Optional | Account identifier. |
| `transactions_count` | `String` | Optional | Total requests for the account during the reporting period. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

