
# Triggervalues

*This model accepts additional fields of type Object.*

## Structure

`Triggervalues`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `trigger_id` | `String` | Optional | - |
| `trigger_name` | `String` | Optional | - |
| `account_name` | `String` | Optional | - |
| `organization_name` | `String` | Optional | - |
| `trigger_category` | `String` | Optional | - |
| `trigger_attributes` | Array[[keyServicePlan](../../doc/models/key-service-plan.md) \| [keyDataPercentage50](../../doc/models/key-data-percentage-50.md) \| [keysmsPercentage50](../../doc/models/keysms-percentage-50.md) \| [NoOfDaysB4PromoExp](../../doc/models/no-of-days-b4-promo-exp.md) \| [EnablePromoExp](../../doc/models/enable-promo-exp.md)] \| nil | Optional | - |
| `created_at` | `DateTime` | Optional | - |
| `modified_at` | `DateTime` | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

