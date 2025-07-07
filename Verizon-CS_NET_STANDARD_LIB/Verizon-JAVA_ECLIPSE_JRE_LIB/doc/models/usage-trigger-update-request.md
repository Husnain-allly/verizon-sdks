
# Usage Trigger Update Request

*This model accepts additional fields of type Object.*

## Structure

`UsageTriggerUpdateRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `TriggerName` | `String` | Optional | Usage trigger name | String getTriggerName() | setTriggerName(String triggerName) |
| `AccountName` | `String` | Required | Account name | String getAccountName() | setAccountName(String accountName) |
| `ThresholdValue` | `String` | Optional | The percent of subscribed usage required to activate the trigger, such as 90 or 100. | String getThresholdValue() | setThresholdValue(String thresholdValue) |
| `SmsPhoneNumbers` | `String` | Optional | Comma-separated list of phone numbers to send SMS alerts to. Digits only; no dashes or parentheses, etc. | String getSmsPhoneNumbers() | setSmsPhoneNumbers(String smsPhoneNumbers) |
| `EmailAddresses` | `String` | Optional | Comma-separated list of email addresses to send alerts to. | String getEmailAddresses() | setEmailAddresses(String emailAddresses) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "triggerName": "95% usage alert",
  "accountName": "0212312345-00001",
  "thresholdValue": "95",
  "smsPhoneNumbers": "5551231234",
  "emailAddresses": "me@theinternet.com, you@theinternet.com",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

