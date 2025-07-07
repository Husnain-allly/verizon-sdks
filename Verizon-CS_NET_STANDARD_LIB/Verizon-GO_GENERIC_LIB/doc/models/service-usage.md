
# Service Usage

*This model accepts additional fields of type interface{}.*

## Structure

`ServiceUsage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `*string` | Optional | Account identifier. |
| `TransactionsCount` | `*string` | Optional | Total requests for the account during the reporting period. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

