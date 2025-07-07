
# Sms Options Send Request

## Structure

`SmsOptionsSendRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ServicePlan` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9 ]{3,32}$` | String getServicePlan() | setServicePlan(String servicePlan) |
| `SmsMessage` | `String` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `64`, *Pattern*: `^[A-Za-z0-9 ]{3,64}$` | String getSmsMessage() | setSmsMessage(String smsMessage) |

## Example (as JSON)

```json
{
  "servicePlan": "the name of a service plan",
  "smsMessage": "A text message"
}
```

