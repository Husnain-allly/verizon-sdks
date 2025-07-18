
# Usage Trigger Add Request

*This model accepts additional fields of type unknown.*

## Structure

`UsageTriggerAddRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerName` | `string \| undefined` | Optional | Usage trigger name |
| `accountName` | `string` | Required | Account name |
| `serviceName` | [`ServiceName`](../../doc/models/service-name.md) | Required | Service name<br><br>**Default**: `ServiceName.Location` |
| `thresholdValue` | `string` | Required | The percent of subscribed usage required to activate the trigger, such as 90 or 100. |
| `allowExcess` | `boolean \| undefined` | Optional | Allow additional requests after thresholdValue is reached. (currently not functional) |
| `sendSmsNotification` | `boolean \| undefined` | Optional | Send SMS (text) alerts when the thresholdValue is reached. |
| `smsPhoneNumbers` | `string \| undefined` | Optional | Comma-separated list of phone numbers to send SMS alerts to. Digits only; no dashes or parentheses, etc. |
| `sendEmailNotification` | `boolean \| undefined` | Optional | Send email alerts when the thresholdValue is reached. |
| `emailAddresses` | `string \| undefined` | Optional | Comma-separated list of email addresses to send alerts to. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

