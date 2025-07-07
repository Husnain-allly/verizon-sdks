
# Anomaly Trigger Result

A result containing a list of anomaly triggers.

## Structure

`AnomalyTriggerResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Triggers` | [`List<TriggersListOptions>`](../../doc/models/triggers-list-options.md) | Optional | Trigger value chunk details. | List<TriggersListOptions> getTriggers() | setTriggers(List<TriggersListOptions> triggers) |

## Example (as JSON)

```json
{
  "triggers": [
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
      "createdAt": "2021-10-21T23:57:03.397.0000Z",
      "modifiedAt": "2021-10-21T23:57:03.397.0000Z",
      "notification": {
        "notificationType": "DailySummary",
        "callback": true,
        "emailNotification": true,
        "notificationGroupName": "Anomaly Test API",
        "notificationFrequencyFactor": -2147483648,
        "externalEmailRecipients": "placeholder@verizon.com",
        "smsNotification": true,
        "smsNumbers": [
          {
            "carrier": "US Cellular",
            "number": "9299280711"
          }
        ],
        "reminder": false,
        "severity": "Critical"
      },
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ]
}
```

