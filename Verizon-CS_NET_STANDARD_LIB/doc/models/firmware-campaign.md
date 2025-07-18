
# Firmware Campaign

Firmware upgrade information.

*This model accepts additional fields of type object.*

## Structure

`FirmwareCampaign`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Upgrade identifier. |
| `AccountName` | `string` | Required | Account identifier. |
| `CampaignName` | `string` | Optional | Campaign name. |
| `FirmwareName` | `string` | Optional | Firmware name (for firmware upgrade only). |
| `FirmwareFrom` | `string` | Required | Old firmware version (for firmware upgrade only). |
| `FirmwareTo` | `string` | Required | New firmware version (for firmware upgrade only). |
| `Protocol` | `string` | Required | Available values: LWM2M.<br><br>**Default**: `"LWM2M"` |
| `Make` | `string` | Required | - |
| `Model` | `string` | Required | - |
| `StartDate` | `DateTime` | Required | Campaign start date. |
| `EndDate` | `DateTime` | Required | Campaign end date. |
| `CampaignTimeWindowList` | [`List<V3TimeWindow>`](../../doc/models/v3-time-window.md) | Optional | List of allowed campaign time windows. |
| `Status` | `string` | Required | Campaign status. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

