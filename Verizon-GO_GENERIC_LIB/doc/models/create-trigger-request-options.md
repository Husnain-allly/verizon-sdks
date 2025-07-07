
# Create Trigger Request Options

*This model accepts additional fields of type interface{}.*

## Structure

`CreateTriggerRequestOptions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `*string` | Optional | Trigger name. |
| `TriggerCategory` | `*string` | Optional | This is the value to use in the request body to detect anomalous behaivior. The values in this table will only be relevant when this parameter is set to this value. |
| `AccountName` | `*string` | Optional | Account name.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32` |
| `AnomalyTriggerRequest` | [`*models.AnomalyTriggerRequest`](../../doc/models/anomaly-trigger-request.md) | Optional | The details of the UsageAnomaly trigger. |
| `Notification` | [`*models.TriggerNotification`](../../doc/models/trigger-notification.md) | Optional | The notification details of the trigger. |
| `Active` | `*bool` | Optional | Indicates anomaly detection is active<br />True - Anomaly detection is active.<br />False - Anomaly detection is not active. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

