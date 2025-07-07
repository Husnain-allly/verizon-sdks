
# Campaign

Firmware upgrade information.

*This model accepts additional fields of type Object.*

## Structure

`Campaign`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Id` | `String` | Required | Upgrade identifier. | String getId() | setId(String id) |
| `AccountName` | `String` | Required | Account identifier. | String getAccountName() | setAccountName(String accountName) |
| `CampaignName` | `String` | Optional | Campaign name. | String getCampaignName() | setCampaignName(String campaignName) |
| `FirmwareName` | `String` | Optional | Name of firmware. | String getFirmwareName() | setFirmwareName(String firmwareName) |
| `FirmwareFrom` | `String` | Optional | Old firmware version. | String getFirmwareFrom() | setFirmwareFrom(String firmwareFrom) |
| `FirmwareTo` | `String` | Optional | New firmware version. | String getFirmwareTo() | setFirmwareTo(String firmwareTo) |
| `Protocol` | `String` | Required | The protocol of the firmware distribution. Default: LWM2M.<br><br>**Default**: `"LWM2M"` | String getProtocol() | setProtocol(String protocol) |
| `Make` | `String` | Required | Applicable make. | String getMake() | setMake(String make) |
| `Model` | `String` | Required | Applicable model. | String getModel() | setModel(String model) |
| `StartDate` | `LocalDate` | Required | Campaign start date. | LocalDate getStartDate() | setStartDate(LocalDate startDate) |
| `EndDate` | `LocalDate` | Required | Campaign end date. | LocalDate getEndDate() | setEndDate(LocalDate endDate) |
| `CampaignTimeWindowList` | [`List<V3TimeWindow>`](../../doc/models/v3-time-window.md) | Optional | List of allowed campaign time windows. | List<V3TimeWindow> getCampaignTimeWindowList() | setCampaignTimeWindowList(List<V3TimeWindow> campaignTimeWindowList) |
| `Status` | `String` | Required | Firmware upgrade status. | String getStatus() | setStatus(String status) |
| `AutoAssignLicenseFlag` | `boolean` | Required | Any device included in the device list which does not have a license will automatically be assigned a FOTA license, assuming there are enough FOTA licenses available, when set to true. | boolean getAutoAssignLicenseFlag() | setAutoAssignLicenseFlag(boolean autoAssignLicenseFlag) |
| `AutoAddDevicesFlag` | `boolean` | Required | Beyond the devices included on the device list, any other device(s) which matches the eligibility criteria (same make, model, current firmware, protocol, billing account) will automatically be added to the campaign list during the life of the campaign when set to true. | boolean getAutoAddDevicesFlag() | setAutoAddDevicesFlag(boolean autoAddDevicesFlag) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "id": "f858b8c4-2153-11ec-8c44-aeb16d1aa652",
  "accountName": "0642233522-00001",
  "campaignName": "Smart FOTA - test 4",
  "protocol": "LWM2M",
  "make": "SEQUANS Communications",
  "model": "GM01Q",
  "status": "CampaignPreScheduled",
  "startDate": "2021-09-29",
  "endDate": "2021-10-01",
  "firmwareName": "SEQUANSCommunications_GM01Q_SR1.2.0.0-10512_SR1.2.0.0-10657",
  "firmwareFrom": "SR1.2.0.0-10512",
  "firmwareTo": "SR1.2.0.0-10657",
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
  "autoAssignLicenseFlag": false,
  "autoAddDevicesFlag": false,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

