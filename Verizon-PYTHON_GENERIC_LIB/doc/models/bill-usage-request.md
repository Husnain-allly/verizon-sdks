
# Bill Usage Request

Bill usage request.

*This model accepts additional fields of type Any.*

## Structure

`BillUsageRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Required | Account identifier. |
| `start_date` | `str` | Required | Start date to search for billable usage, mm-dd-yyyy. |
| `end_date` | `str` | Required | End date to search for billable usage, mm-dd-yyyy. |
| `usage_for_all_accounts` | `bool` | Optional | Request usage for single or multiple accounts. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

