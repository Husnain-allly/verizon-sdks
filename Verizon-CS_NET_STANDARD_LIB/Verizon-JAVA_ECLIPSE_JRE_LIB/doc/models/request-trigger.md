
# Request Trigger

*This model accepts additional fields of type Object.*

## Structure

`RequestTrigger`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `TriggerId` | `String` | Optional | - | String getTriggerId() | setTriggerId(String triggerId) |
| `TriggerName` | `String` | Optional | - | String getTriggerName() | setTriggerName(String triggerName) |
| `AccountName` | `String` | Optional | - | String getAccountName() | setAccountName(String accountName) |
| `OrganizationName` | `String` | Optional | - | String getOrganizationName() | setOrganizationName(String organizationName) |
| `TriggerCategory` | `String` | Optional | - | String getTriggerCategory() | setTriggerCategory(String triggerCategory) |
| `PromoAlerts` | [`List<PromoAlert1>`](../../doc/models/promo-alert-1.md) | Optional | - | List<PromoAlert1> getPromoAlerts() | setPromoAlerts(List<PromoAlert1> promoAlerts) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

