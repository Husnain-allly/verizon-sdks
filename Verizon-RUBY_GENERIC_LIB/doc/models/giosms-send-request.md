
# Giosms Send Request

## Structure

`GiosmsSendRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Optional | - |
| `custom_fields` | [`Array<KvPair>`](../../doc/models/kv-pair.md) | Optional | **Constraints**: *Maximum Items*: `5` |
| `data_encoding` | `String` | Optional | - |
| `group_name` | `String` | Optional | - |
| `service_plan` | `String` | Optional | - |
| `time_to_live` | `String` | Optional | A period of time the message remains valid or an end date for the message. This value would be less than the 5 day default. |
| `device_ids` | [`Array<GioDeviceId>`](../../doc/models/gio-device-id.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `sms_message` | `String` | Required | - |

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

