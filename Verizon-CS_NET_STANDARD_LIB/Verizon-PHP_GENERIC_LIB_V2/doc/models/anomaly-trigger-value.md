
# Anomaly Trigger Value

Trigger details.

*This model accepts additional fields of type array.*

## Structure

`AnomalyTriggerValue`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `triggerId` | `?string` | Optional | The system assigned name of the trigger being updated. | getTriggerId(): ?string | setTriggerId(?string triggerId): void |
| `triggerName` | `?string` | Optional | The user defined name of the trigger. | getTriggerName(): ?string | setTriggerName(?string triggerName): void |
| `organizationName` | `?string` | Optional | The user assigned name of the organization associated with the trigger. | getOrganizationName(): ?string | setOrganizationName(?string organizationName): void |
| `triggerCategory` | `?string` | Optional | This is the value to use in the request body to detect anomalous behaivior. The values in this table will only be relevant when this parameter is set to this value. | getTriggerCategory(): ?string | setTriggerCategory(?string triggerCategory): void |
| `triggerAttributes` | array<[NotificationGroupNameTriggerAttribute](../../doc/models/notification-group-name-trigger-attribute.md)\|[ServicePlanTriggerAttribute](../../doc/models/service-plan-trigger-attribute.md)\|[DataPercentage50TriggerAttribute](../../doc/models/data-percentage-50-trigger-attribute.md)\|[DataPercentage75TriggerAttribute](../../doc/models/data-percentage-75-trigger-attribute.md)\|[DataPercentage90TriggerAttribute](../../doc/models/data-percentage-90-trigger-attribute.md)\|[DataPercentage100TriggerAttribute](../../doc/models/data-percentage-100-trigger-attribute.md)>\|null | Optional | Additional details and keys for the trigger. | getTriggerAttributes(): ?array | setTriggerAttributes(?array triggerAttributes): void |
| `createdAt` | `?string` | Optional | Timestamp for whe the trigger was created. | getCreatedAt(): ?string | setCreatedAt(?string createdAt): void |
| `modifiedAt` | `?string` | Optional | Timestamp for the most recent time the trigger was modified. | getModifiedAt(): ?string | setModifiedAt(?string modifiedAt): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "triggerId": "BE1B5958-3E11-41DB-9ABD-B1B7618C0035",
  "triggerName": "Anomaly Daily Usage REST Test-1",
  "organizationName": "AnamolyDetectionRTRTest",
  "triggerCategory": "UsageAnomaly",
  "triggerAttributes": [
    {
      "key": "DataPercentage50",
      "value": false
    }
  ],
  "createdAt": "2021-10-21T23:57:03.397.0000Z",
  "modifiedAt": "2021-10-21T23:57:03.397.0000Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

