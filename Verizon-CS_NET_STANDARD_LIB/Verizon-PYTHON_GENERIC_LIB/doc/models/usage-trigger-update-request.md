
# Usage Trigger Update Request

*This model accepts additional fields of type Any.*

## Structure

`UsageTriggerUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `trigger_name` | `str` | Optional | Usage trigger name |
| `account_name` | `str` | Required | Account name |
| `threshold_value` | `str` | Optional | The percent of subscribed usage required to activate the trigger, such as 90 or 100. |
| `sms_phone_numbers` | `str` | Optional | Comma-separated list of phone numbers to send SMS alerts to. Digits only; no dashes or parentheses, etc. |
| `email_addresses` | `str` | Optional | Comma-separated list of email addresses to send alerts to. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

