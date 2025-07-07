
# Firmware Campaign

Firmware upgrade information.

*This model accepts additional fields of type Object.*

## Structure

`FirmwareCampaign`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Id` | `String` | Required | Upgrade identifier. | String getId() | setId(String id) |
| `AccountName` | `String` | Required | Account identifier. | String getAccountName() | setAccountName(String accountName) |
| `CampaignName` | `String` | Optional | Campaign name. | String getCampaignName() | setCampaignName(String campaignName) |
| `FirmwareName` | `String` | Optional | Firmware name (for firmware upgrade only). | String getFirmwareName() | setFirmwareName(String firmwareName) |
| `FirmwareFrom` | `String` | Required | Old firmware version (for firmware upgrade only). | String getFirmwareFrom() | setFirmwareFrom(String firmwareFrom) |
| `FirmwareTo` | `String` | Required | New firmware version (for firmware upgrade only). | String getFirmwareTo() | setFirmwareTo(String firmwareTo) |
| `Protocol` | `String` | Required | Available values: LWM2M.<br><br>**Default**: `"LWM2M"` | String getProtocol() | setProtocol(String protocol) |
| `Make` | `String` | Required | - | String getMake() | setMake(String make) |
| `Model` | `String` | Required | - | String getModel() | setModel(String model) |
| `StartDate` | `LocalDate` | Required | Campaign start date. | LocalDate getStartDate() | setStartDate(LocalDate startDate) |
| `EndDate` | `LocalDate` | Required | Campaign end date. | LocalDate getEndDate() | setEndDate(LocalDate endDate) |
| `CampaignTimeWindowList` | [`List<V3TimeWindow>`](../../doc/models/v3-time-window.md) | Optional | List of allowed campaign time windows. | List<V3TimeWindow> getCampaignTimeWindowList() | setCampaignTimeWindowList(List<V3TimeWindow> campaignTimeWindowList) |
| `Status` | `String` | Required | Campaign status. | String getStatus() | setStatus(String status) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "id": "f858b8c4-2153-11ec-8c44-aeb16d1aa652",
  "accountName": "0000123456-00001",
  "campaignName": "Smart FOTA - test 4",
  "firmwareName": "SEQUANSCommunications_GM01Q_SR1.2.0.0-10512_SR1.2.0.0-10657",
  "protocol": "LWM2M",
  "firmwareFrom": "SR1.2.0.0-10512",
  "firmwareTo": "SR1.2.0.0-10657",
  "make": "SEQUANS Communications",
  "model": "GM01Q",
  "status": "CampaignRequestPending",
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
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

