
# Request Trigger

*This model accepts additional fields of type Any.*

## Structure

`RequestTrigger`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `trigger_id` | `str` | Optional | - |
| `trigger_name` | `str` | Optional | - |
| `account_name` | `str` | Optional | - |
| `organization_name` | `str` | Optional | - |
| `trigger_category` | `str` | Optional | - |
| `promo_alerts` | [`List[PromoAlert1]`](../../doc/models/promo-alert-1.md) | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "triggerId": "2874DEC7-26CF-4797-9C6A-B5A2AC72D526",
  "triggerName": "PromoAlerts_0000000000-00001_23456789",
  "accountName": "0000123456-000001",
  "organizationName": "Optional group name",
  "triggerCategory": "PromoAlerts",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

