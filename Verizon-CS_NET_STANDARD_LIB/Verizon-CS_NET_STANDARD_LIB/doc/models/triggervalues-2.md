
# Triggervalues 2

*This model accepts additional fields of type object.*

## Structure

`Triggervalues2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TriggerId` | `string` | Optional | - |
| `TriggerName` | `string` | Optional | - |
| `AccountName` | `string` | Optional | - |
| `OrganizationName` | `string` | Optional | - |
| `TriggerCategory` | `string` | Optional | - |
| `PromoAlerts` | [`List<PromoAlert>`](../../doc/models/promo-alert.md) | Optional | - |
| `Active` | `bool?` | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | - |
| `ModifiedAt` | `DateTime?` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

