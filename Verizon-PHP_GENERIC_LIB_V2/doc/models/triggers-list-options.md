
# Triggers List Options

*This model accepts additional fields of type array.*

## Structure

`TriggersListOptions`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `triggerId` | `?string` | Optional | The system assigned name of the trigger being updated. | getTriggerId(): ?string | setTriggerId(?string triggerId): void |
| `triggerName` | `?string` | Optional | The user defined name of the trigger. | getTriggerName(): ?string | setTriggerName(?string triggerName): void |
| `organizationName` | `?string` | Optional | The user assigned name of the organization associated with the trigger. | getOrganizationName(): ?string | setOrganizationName(?string organizationName): void |
| `triggerCategory` | `?string` | Optional | This is the value to use in the request body to detect anomalous behaivior. The values in this table will only be relevant when this parameter is set to this value. | getTriggerCategory(): ?string | setTriggerCategory(?string triggerCategory): void |
| `triggerAttributes` | [`?(TriggerAttributesOptions[])`](../../doc/models/trigger-attributes-options.md) | Optional | Additional details and keys for the trigger. | getTriggerAttributes(): ?array | setTriggerAttributes(?array triggerAttributes): void |
| `createdAt` | `?string` | Optional | Timestamp for whe the trigger was created. | getCreatedAt(): ?string | setCreatedAt(?string createdAt): void |
| `modifiedAt` | `?string` | Optional | Timestamp for the most recent time the trigger was modified. | getModifiedAt(): ?string | setModifiedAt(?string modifiedAt): void |
| `anomalyattributes` | [`?UsageAnomalyAttributes`](../../doc/models/usage-anomaly-attributes.md) | Optional | The details of the UsageAnomaly trigger. | getAnomalyattributes(): ?UsageAnomalyAttributes | setAnomalyattributes(?UsageAnomalyAttributes anomalyattributes): void |
| `notification` | [`?TriggerNotification`](../../doc/models/trigger-notification.md) | Optional | The notification details of the trigger. | getNotification(): ?TriggerNotification | setNotification(?TriggerNotification notification): void |
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
      "value": false,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "createdAt": "2021-10-21T23:57:03.397Z",
  "modifiedAt": "2021-10-21T23:57:03.397Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

