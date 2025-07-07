
# Usage Trigger Response

*This model accepts additional fields of type Object.*

## Structure

`UsageTriggerResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `TriggerId` | `String` | Required | Unique usage triggerId | String getTriggerId() | setTriggerId(String triggerId) |
| `TriggerName` | `String` | Required | Usage trigger name | String getTriggerName() | setTriggerName(String triggerName) |
| `AccountName` | `String` | Required | Account name | String getAccountName() | setAccountName(String accountName) |
| `ServiceName` | [`ServiceName`](../../doc/models/service-name.md) | Required | Service name<br><br>**Default**: `ServiceName.LOCATION` | ServiceName getServiceName() | setServiceName(ServiceName serviceName) |
| `ThresholdValue` | `String` | Required | Percent of subscription at which trigger will send an alert | String getThresholdValue() | setThresholdValue(String thresholdValue) |
| `AllowExcess` | `boolean` | Required | allowExcess determines whether to restrict usage after exceeds limits | boolean getAllowExcess() | setAllowExcess(boolean allowExcess) |
| `SendSmsNotification` | `boolean` | Required | Send SMS (text) alerts when the thresholdValue is reached. | boolean getSendSmsNotification() | setSendSmsNotification(boolean sendSmsNotification) |
| `SmsPhoneNumbers` | `String` | Required | comma seperated value of list of Phone numbers for SMS notifications | String getSmsPhoneNumbers() | setSmsPhoneNumbers(String smsPhoneNumbers) |
| `SendEmailNotification` | `boolean` | Required | Send email alerts when the thresholdValue is reached. | boolean getSendEmailNotification() | setSendEmailNotification(boolean sendEmailNotification) |
| `EmailAddresses` | `String` | Required | comma seperated value of list of Email addresses for Email notifications | String getEmailAddresses() | setEmailAddresses(String emailAddresses) |
| `CreateDate` | `String` | Required | UTC Date when the usage trigger was created | String getCreateDate() | setCreateDate(String createDate) |
| `UpdateDate` | `String` | Required | UTC Date when the usage trigger was last updated | String getUpdateDate() | setUpdateDate(String updateDate) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "triggerId": "3bb4777e-5292-4de7-97df-f578df4a2dbe",
  "triggerName": "95% usage alert",
  "accountName": "0212312345-00001",
  "serviceName": "Location",
  "thresholdValue": "95",
  "allowExcess": false,
  "sendSmsNotification": false,
  "smsPhoneNumbers": "5551231234",
  "sendEmailNotification": false,
  "emailAddresses": "me@theinternet.com, you@theinternet.com",
  "createDate": "2018-08-31",
  "updateDate": "2018-09-03",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

