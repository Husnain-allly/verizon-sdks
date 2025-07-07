
# Triggervalues

*This model accepts additional fields of type array.*

## Structure

`Triggervalues`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `triggerId` | `?string` | Optional | - | getTriggerId(): ?string | setTriggerId(?string triggerId): void |
| `triggerName` | `?string` | Optional | - | getTriggerName(): ?string | setTriggerName(?string triggerName): void |
| `accountName` | `?string` | Optional | - | getAccountName(): ?string | setAccountName(?string accountName): void |
| `organizationName` | `?string` | Optional | - | getOrganizationName(): ?string | setOrganizationName(?string organizationName): void |
| `triggerCategory` | `?string` | Optional | - | getTriggerCategory(): ?string | setTriggerCategory(?string triggerCategory): void |
| `triggerAttributes` | array<[KeyServicePlan](../../doc/models/key-service-plan.md)\|[KeyDataPercentage50](../../doc/models/key-data-percentage-50.md)\|[KeysmsPercentage50](../../doc/models/keysms-percentage-50.md)\|[NoOfDaysB4PromoExp](../../doc/models/no-of-days-b4-promo-exp.md)\|[EnablePromoExp](../../doc/models/enable-promo-exp.md)>\|null | Optional | - | getTriggerAttributes(): ?array | setTriggerAttributes(?array triggerAttributes): void |
| `createdAt` | `?DateTime` | Optional | - | getCreatedAt(): ?\DateTime | setCreatedAt(?\DateTime createdAt): void |
| `modifiedAt` | `?DateTime` | Optional | - | getModifiedAt(): ?\DateTime | setModifiedAt(?\DateTime modifiedAt): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

