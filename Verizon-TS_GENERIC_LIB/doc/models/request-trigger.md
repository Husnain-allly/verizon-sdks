
# Request Trigger

*This model accepts additional fields of type unknown.*

## Structure

`RequestTrigger`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerId` | `string \| undefined` | Optional | - |
| `triggerName` | `string \| undefined` | Optional | - |
| `accountName` | `string \| undefined` | Optional | - |
| `organizationName` | `string \| undefined` | Optional | - |
| `triggerCategory` | `string \| undefined` | Optional | - |
| `promoAlerts` | [`PromoAlert1[] \| undefined`](../../doc/models/promo-alert-1.md) | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

