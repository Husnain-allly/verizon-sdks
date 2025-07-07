
# Giosms Send Request

## Structure

`GiosmsSendRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `?string` | Optional | - | getAccountName(): ?string | setAccountName(?string accountName): void |
| `customFields` | [`?(KvPair[])`](../../doc/models/kv-pair.md) | Optional | **Constraints**: *Maximum Items*: `5` | getCustomFields(): ?array | setCustomFields(?array customFields): void |
| `dataEncoding` | `?string` | Optional | - | getDataEncoding(): ?string | setDataEncoding(?string dataEncoding): void |
| `groupName` | `?string` | Optional | - | getGroupName(): ?string | setGroupName(?string groupName): void |
| `servicePlan` | `?string` | Optional | - | getServicePlan(): ?string | setServicePlan(?string servicePlan): void |
| `timeToLive` | `?string` | Optional | A period of time the message remains valid or an end date for the message. This value would be less than the 5 day default. | getTimeToLive(): ?string | setTimeToLive(?string timeToLive): void |
| `deviceIds` | [`?(GioDeviceId[])`](../../doc/models/gio-device-id.md) | Optional | **Constraints**: *Maximum Items*: `100` | getDeviceIds(): ?array | setDeviceIds(?array deviceIds): void |
| `smsMessage` | `string` | Required | - | getSmsMessage(): string | setSmsMessage(string smsMessage): void |

## Example (as JSON)

```json
{
  "smsMessage": "A text message",
  "accountName": "accountName2",
  "customFields": [
    {
      "key": "key0",
      "value": "value2"
    },
    {
      "key": "key0",
      "value": "value2"
    },
    {
      "key": "key0",
      "value": "value2"
    }
  ],
  "dataEncoding": "dataEncoding0",
  "groupName": "groupName2",
  "servicePlan": "servicePlan2"
}
```

