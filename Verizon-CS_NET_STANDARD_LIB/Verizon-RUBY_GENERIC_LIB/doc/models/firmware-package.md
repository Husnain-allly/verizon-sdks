
# Firmware Package

Available firmware.

*This model accepts additional fields of type Object.*

## Structure

`FirmwarePackage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `firmware_name` | `String` | Required | Firmware name. |
| `firmware_from` | `String` | Required | Firmware from version. |
| `firmware_to` | `String` | Required | Firmware to version. |
| `launch_date` | `DateTime` | Required | Firmware launch date. |
| `release_note` | `String` | Required | Firmware release note. |
| `model` | `String` | Required | Firmware applicable device model. |
| `make` | `String` | Required | Firmware applicable device make. |
| `protocol` | [`CampaignMetaInfoProtocol`](../../doc/models/campaign-meta-info-protocol.md) | Required | Firmware protocol. Valid values include: LWM2M, OMD-DM.<br><br>**Default**: `CampaignMetaInfoProtocol::LW_M2M` |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

