
# Create Trigger Request Options

*This model accepts additional fields of type array.*

## Structure

`CreateTriggerRequestOptions`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `name` | `?string` | Optional | Trigger name. | getName(): ?string | setName(?string name): void |
| `triggerCategory` | `?string` | Optional | This is the value to use in the request body to detect anomalous behaivior. The values in this table will only be relevant when this parameter is set to this value. | getTriggerCategory(): ?string | setTriggerCategory(?string triggerCategory): void |
| `accountName` | `?string` | Optional | Account name.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32` | getAccountName(): ?string | setAccountName(?string accountName): void |
| `anomalyTriggerRequest` | [`?AnomalyTriggerRequest`](../../doc/models/anomaly-trigger-request.md) | Optional | The details of the UsageAnomaly trigger. | getAnomalyTriggerRequest(): ?AnomalyTriggerRequest | setAnomalyTriggerRequest(?AnomalyTriggerRequest anomalyTriggerRequest): void |
| `notification` | [`?TriggerNotification`](../../doc/models/trigger-notification.md) | Optional | The notification details of the trigger. | getNotification(): ?TriggerNotification | setNotification(?TriggerNotification notification): void |
| `active` | `?bool` | Optional | Indicates anomaly detection is active<br />True - Anomaly detection is active.<br />False - Anomaly detection is not active. | getActive(): ?bool | setActive(?bool active): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "name": "Anomaly Daily Usage REST Test-Patch 1",
  "triggerCategory": "UsageAnomaly",
  "accountName": "0000123456-00001",
  "anomalyTriggerRequest": {
    "accountNames": "0000123456-00001",
    "includeAbnormal": true,
    "includeVeryAbnormal": true,
    "includeUnderExpectedUsage": true,
    "includeOverExpectedUsage": true
  },
  "notification": {
    "notificationType": "DailySummary",
    "callback": true,
    "emailNotification": false,
    "notificationGroupName": "Anomaly Test API",
    "notificationFrequencyFactor": 3,
    "notificationFrequencyInterval": "Hourly",
    "externalEmailRecipients": "placeholder@verizon.com",
    "smsNotification": true,
    "smsNumbers": [
      {
        "carrier": "US Cellular",
        "number": "9299280711"
      }
    ],
    "reminder": true,
    "severity": "Critical"
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

