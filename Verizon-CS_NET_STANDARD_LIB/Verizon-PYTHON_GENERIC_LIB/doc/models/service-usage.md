
# Service Usage

*This model accepts additional fields of type Any.*

## Structure

`ServiceUsage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Optional | Account identifier. |
| `transactions_count` | `str` | Optional | Total requests for the account during the reporting period. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

