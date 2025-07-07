
# Usage Trigger Add Request

*This model accepts additional fields of type Object.*

## Structure

`UsageTriggerAddRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `TriggerName` | `String` | Optional | Usage trigger name | String getTriggerName() | setTriggerName(String triggerName) |
| `AccountName` | `String` | Required | Account name | String getAccountName() | setAccountName(String accountName) |
| `ServiceName` | [`ServiceName`](../../doc/models/service-name.md) | Required | Service name<br><br>**Default**: `ServiceName.LOCATION` | ServiceName getServiceName() | setServiceName(ServiceName serviceName) |
| `ThresholdValue` | `String` | Required | The percent of subscribed usage required to activate the trigger, such as 90 or 100. | String getThresholdValue() | setThresholdValue(String thresholdValue) |
| `AllowExcess` | `Boolean` | Optional | Allow additional requests after thresholdValue is reached. (currently not functional) | Boolean getAllowExcess() | setAllowExcess(Boolean allowExcess) |
| `SendSmsNotification` | `Boolean` | Optional | Send SMS (text) alerts when the thresholdValue is reached. | Boolean getSendSmsNotification() | setSendSmsNotification(Boolean sendSmsNotification) |
| `SmsPhoneNumbers` | `String` | Optional | Comma-separated list of phone numbers to send SMS alerts to. Digits only; no dashes or parentheses, etc. | String getSmsPhoneNumbers() | setSmsPhoneNumbers(String smsPhoneNumbers) |
| `SendEmailNotification` | `Boolean` | Optional | Send email alerts when the thresholdValue is reached. | Boolean getSendEmailNotification() | setSendEmailNotification(Boolean sendEmailNotification) |
| `EmailAddresses` | `String` | Optional | Comma-separated list of email addresses to send alerts to. | String getEmailAddresses() | setEmailAddresses(String emailAddresses) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "triggerName": "95% usage alert",
  "accountName": "0212312345-00001",
  "serviceName": "Location",
  "thresholdValue": "95",
  "smsPhoneNumbers": "5551231234",
  "emailAddresses": "you@theinternet.com",
  "allowExcess": false,
  "sendSmsNotification": false,
  "sendEmailNotification": false,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

