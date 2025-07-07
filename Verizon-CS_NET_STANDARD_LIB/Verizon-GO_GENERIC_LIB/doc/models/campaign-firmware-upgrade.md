
# Campaign Firmware Upgrade

Firmware upgrade for devices.

*This model accepts additional fields of type interface{}.*

## Structure

`CampaignFirmwareUpgrade`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CampaignName` | `*string` | Optional | Campaign name. |
| `FirmwareName` | `string` | Required | Firmware name to upgrade to. |
| `FirmwareFrom` | `string` | Required | Old firmware version. |
| `FirmwareTo` | `string` | Required | New firmware version. |
| `Protocol` | `string` | Required | Valid values include: LWM2M, OMA and HTTP.<br><br>**Default**: `"LWM2M"` |
| `StartDate` | `time.Time` | Required | Campaign start date. |
| `EndDate` | `time.Time` | Required | Campaign end date. |
| `CampaignTimeWindowList` | [`[]models.V3TimeWindow`](../../doc/models/v3-time-window.md) | Optional | List of allowed campaign time windows. |
| `DeviceList` | `[]string` | Required | Device IMEI list. |
| `AutoAssignLicenseFlag` | `bool` | Required | This flag, when set to true, will assign a FOTA license automatically if the device does not have one already. |
| `AutoAddDevicesFlag` | `bool` | Required | this flag, when set to true, will automatically add a device of the same make and model to a campaign. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

