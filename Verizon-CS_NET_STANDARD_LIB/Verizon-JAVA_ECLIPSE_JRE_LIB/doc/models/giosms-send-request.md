
# Giosms Send Request

## Structure

`GiosmsSendRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | - | String getAccountName() | setAccountName(String accountName) |
| `CustomFields` | [`List<KvPair>`](../../doc/models/kv-pair.md) | Optional | **Constraints**: *Maximum Items*: `5` | List<KvPair> getCustomFields() | setCustomFields(List<KvPair> customFields) |
| `DataEncoding` | `String` | Optional | - | String getDataEncoding() | setDataEncoding(String dataEncoding) |
| `GroupName` | `String` | Optional | - | String getGroupName() | setGroupName(String groupName) |
| `ServicePlan` | `String` | Optional | - | String getServicePlan() | setServicePlan(String servicePlan) |
| `TimeToLive` | `String` | Optional | A period of time the message remains valid or an end date for the message. This value would be less than the 5 day default. | String getTimeToLive() | setTimeToLive(String timeToLive) |
| `DeviceIds` | [`List<GioDeviceId>`](../../doc/models/gio-device-id.md) | Optional | **Constraints**: *Maximum Items*: `100` | List<GioDeviceId> getDeviceIds() | setDeviceIds(List<GioDeviceId> deviceIds) |
| `SmsMessage` | `String` | Required | - | String getSmsMessage() | setSmsMessage(String smsMessage) |

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

