
# Trigger Type 3

Trigger details.

## Structure

`TriggerType3`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `triggerId` | `?string` | Optional | Trigger ID. | getTriggerId(): ?string | setTriggerId(?string triggerId): void |
| `triggerName` | `?string` | Optional | Trigger name. | getTriggerName(): ?string | setTriggerName(?string triggerName): void |
| `triggerCategory` | `?string` | Optional | This is the value to use in the request body to detect anomalous behaivior. The values in this table will only be relevant when this parameter is set to this value. | getTriggerCategory(): ?string | setTriggerCategory(?string triggerCategory): void |
| `accountName` | `?string` | Optional | Account name.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32` | getAccountName(): ?string | setAccountName(?string accountName): void |
| `anomalyTriggerRequest` | [`?AnomalyTriggerRequest`](../../doc/models/anomaly-trigger-request.md) | Optional | The details of the UsageAnomaly trigger. | getAnomalyTriggerRequest(): ?AnomalyTriggerRequest | setAnomalyTriggerRequest(?AnomalyTriggerRequest anomalyTriggerRequest): void |
| `notification` | [`?TriggerNotification`](../../doc/models/trigger-notification.md) | Optional | The notification details of the trigger. | getNotification(): ?TriggerNotification | setNotification(?TriggerNotification notification): void |

## Example (as JSON)

```json
{
  "triggerId": "595f5c44-c31c-4552-8670-020a1545a84d",
  "triggerName": "Anomaly Daily Usage REST Test-Patch Update 4",
  "accountName": "0000123456-00001",
  "triggerCategory": "UsageAnomaly",
  "anomalyTriggerRequest": {
    "accountNames": "0000123456-00001",
    "includeAbnormal": true,
    "includeVeryAbnormal": true,
    "includeUnderExpectedUsage": false,
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
  }
}
```

