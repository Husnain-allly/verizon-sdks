
# Firmware Package

Available firmware.

*This model accepts additional fields of type Object.*

## Structure

`FirmwarePackage`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `FirmwareName` | `String` | Required | Firmware name. | String getFirmwareName() | setFirmwareName(String firmwareName) |
| `FirmwareFrom` | `String` | Required | Firmware from version. | String getFirmwareFrom() | setFirmwareFrom(String firmwareFrom) |
| `FirmwareTo` | `String` | Required | Firmware to version. | String getFirmwareTo() | setFirmwareTo(String firmwareTo) |
| `LaunchDate` | `LocalDateTime` | Required | Firmware launch date. | LocalDateTime getLaunchDate() | setLaunchDate(LocalDateTime launchDate) |
| `ReleaseNote` | `String` | Required | Firmware release note. | String getReleaseNote() | setReleaseNote(String releaseNote) |
| `Model` | `String` | Required | Firmware applicable device model. | String getModel() | setModel(String model) |
| `Make` | `String` | Required | Firmware applicable device make. | String getMake() | setMake(String make) |
| `Protocol` | [`CampaignMetaInfoProtocol`](../../doc/models/campaign-meta-info-protocol.md) | Required | Firmware protocol. Valid values include: LWM2M, OMD-DM.<br><br>**Default**: `CampaignMetaInfoProtocol.LW_M2M` | CampaignMetaInfoProtocol getProtocol() | setProtocol(CampaignMetaInfoProtocol protocol) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "firmwareName": "VerizonSmartCommunities_LCO-277C4N_BG96MAR04A04M1G_BG96MAR04A04M1G_BETA0130B",
  "firmwareFrom": "BG96MAR04A04M1G",
  "firmwareTo": "BG96MAR04A04M1G_BETA0130B",
  "launchDate": "2012-04-23T18:25:43.511Z",
  "releaseNote": "",
  "model": "LCO-277C4N",
  "make": "Verizon Smart Communities",
  "protocol": "LWM2M",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

