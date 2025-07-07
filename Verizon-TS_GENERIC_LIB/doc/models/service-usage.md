
# Service Usage

*This model accepts additional fields of type unknown.*

## Structure

`ServiceUsage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string \| undefined` | Optional | Account identifier. |
| `transactionsCount` | `string \| undefined` | Optional | Total requests for the account during the reporting period. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

