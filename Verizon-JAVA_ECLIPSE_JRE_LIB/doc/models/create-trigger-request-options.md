
# Create Trigger Request Options

*This model accepts additional fields of type Object.*

## Structure

`CreateTriggerRequestOptions`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Name` | `String` | Optional | Trigger name. | String getName() | setName(String name) |
| `TriggerCategory` | `String` | Optional | This is the value to use in the request body to detect anomalous behaivior. The values in this table will only be relevant when this parameter is set to this value. | String getTriggerCategory() | setTriggerCategory(String triggerCategory) |
| `AccountName` | `String` | Optional | Account name.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32` | String getAccountName() | setAccountName(String accountName) |
| `AnomalyTriggerRequest` | [`AnomalyTriggerRequest`](../../doc/models/anomaly-trigger-request.md) | Optional | The details of the UsageAnomaly trigger. | AnomalyTriggerRequest getAnomalyTriggerRequest() | setAnomalyTriggerRequest(AnomalyTriggerRequest anomalyTriggerRequest) |
| `Notification` | [`TriggerNotification`](../../doc/models/trigger-notification.md) | Optional | The notification details of the trigger. | TriggerNotification getNotification() | setNotification(TriggerNotification notification) |
| `Active` | `Boolean` | Optional | Indicates anomaly detection is active<br />True - Anomaly detection is active.<br />False - Anomaly detection is not active. | Boolean getActive() | setActive(Boolean active) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

