
# Bill Usage Request

Bill usage request.

*This model accepts additional fields of type interface{}.*

## Structure

`BillUsageRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | Account identifier. |
| `StartDate` | `string` | Required | Start date to search for billable usage, mm-dd-yyyy. |
| `EndDate` | `string` | Required | End date to search for billable usage, mm-dd-yyyy. |
| `UsageForAllAccounts` | `*bool` | Optional | Request usage for single or multiple accounts. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "1234567890-00001",
  "startDate": "04-01-2018",
  "endDate": "04-30-2018",
  "usageForAllAccounts": true,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

