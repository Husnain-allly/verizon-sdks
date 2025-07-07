
# Usage Trigger Update Request

*This model accepts additional fields of type unknown.*

## Structure

`UsageTriggerUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerName` | `string \| undefined` | Optional | Usage trigger name |
| `accountName` | `string` | Required | Account name |
| `thresholdValue` | `string \| undefined` | Optional | The percent of subscribed usage required to activate the trigger, such as 90 or 100. |
| `smsPhoneNumbers` | `string \| undefined` | Optional | Comma-separated list of phone numbers to send SMS alerts to. Digits only; no dashes or parentheses, etc. |
| `emailAddresses` | `string \| undefined` | Optional | Comma-separated list of email addresses to send alerts to. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

