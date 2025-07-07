
# Usage Trigger Response

*This model accepts additional fields of type unknown.*

## Structure

`UsageTriggerResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerId` | `string` | Required | Unique usage triggerId |
| `triggerName` | `string` | Required | Usage trigger name |
| `accountName` | `string` | Required | Account name |
| `serviceName` | [`ServiceName`](../../doc/models/service-name.md) | Required | Service name<br><br>**Default**: `ServiceName.Location` |
| `thresholdValue` | `string` | Required | Percent of subscription at which trigger will send an alert |
| `allowExcess` | `boolean` | Required | allowExcess determines whether to restrict usage after exceeds limits |
| `sendSmsNotification` | `boolean` | Required | Send SMS (text) alerts when the thresholdValue is reached. |
| `smsPhoneNumbers` | `string` | Required | comma seperated value of list of Phone numbers for SMS notifications |
| `sendEmailNotification` | `boolean` | Required | Send email alerts when the thresholdValue is reached. |
| `emailAddresses` | `string` | Required | comma seperated value of list of Email addresses for Email notifications |
| `createDate` | `string` | Required | UTC Date when the usage trigger was created |
| `updateDate` | `string` | Required | UTC Date when the usage trigger was last updated |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

