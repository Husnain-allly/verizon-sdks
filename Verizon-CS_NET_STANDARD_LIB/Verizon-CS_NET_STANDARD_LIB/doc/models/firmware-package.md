
# Firmware Package

Available firmware.

*This model accepts additional fields of type object.*

## Structure

`FirmwarePackage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FirmwareName` | `string` | Required | Firmware name. |
| `FirmwareFrom` | `string` | Required | Firmware from version. |
| `FirmwareTo` | `string` | Required | Firmware to version. |
| `LaunchDate` | `DateTime` | Required | Firmware launch date. |
| `ReleaseNote` | `string` | Required | Firmware release note. |
| `Model` | `string` | Required | Firmware applicable device model. |
| `Make` | `string` | Required | Firmware applicable device make. |
| `Protocol` | [`CampaignMetaInfoProtocol`](../../doc/models/campaign-meta-info-protocol.md) | Required | Firmware protocol. Valid values include: LWM2M, OMD-DM.<br><br>**Default**: `CampaignMetaInfoProtocol.LWM2M` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

