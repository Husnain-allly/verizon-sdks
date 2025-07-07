
# Campaign Firmware Upgrade

Firmware upgrade for devices.

*This model accepts additional fields of type Object.*

## Structure

`CampaignFirmwareUpgrade`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `campaign_name` | `String` | Optional | Campaign name. |
| `firmware_name` | `String` | Required | Firmware name to upgrade to. |
| `firmware_from` | `String` | Required | Old firmware version. |
| `firmware_to` | `String` | Required | New firmware version. |
| `protocol` | `String` | Required | Valid values include: LWM2M, OMA and HTTP.<br><br>**Default**: `'LWM2M'` |
| `start_date` | `Date` | Required | Campaign start date. |
| `end_date` | `Date` | Required | Campaign end date. |
| `campaign_time_window_list` | [`Array<V3TimeWindow>`](../../doc/models/v3-time-window.md) | Optional | List of allowed campaign time windows. |
| `device_list` | `Array<String>` | Required | Device IMEI list. |
| `auto_assign_license_flag` | `TrueClass \| FalseClass` | Required | This flag, when set to true, will assign a FOTA license automatically if the device does not have one already. |
| `auto_add_devices_flag` | `TrueClass \| FalseClass` | Required | this flag, when set to true, will automatically add a device of the same make and model to a campaign. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "campaignName": "Smart FOTA - test 4",
  "firmwareName": "SEQUANSCommunications_GM01Q_SR1.2.0.0-10512_SR1.2.0.0-10657",
  "firmwareFrom": "SR1.2.0.0-10512",
  "firmwareTo": "SR1.2.0.0-10657",
  "protocol": "LWM2M",
  "startDate": "2021-09-29",
  "endDate": "2021-10-01",
  "campaignTimeWindowList": [
    {
      "startTime": 18,
      "endTime": 22,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "deviceList": [
    "15-digit IMEI"
  ],
  "autoAssignLicenseFlag": false,
  "autoAddDevicesFlag": false,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

