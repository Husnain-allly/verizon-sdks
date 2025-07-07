
# Firmware Package

Available firmware.

*This model accepts additional fields of type unknown.*

## Structure

`FirmwarePackage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `firmwareName` | `string` | Required | Firmware name. |
| `firmwareFrom` | `string` | Required | Firmware from version. |
| `firmwareTo` | `string` | Required | Firmware to version. |
| `launchDate` | `string` | Required | Firmware launch date. |
| `releaseNote` | `string` | Required | Firmware release note. |
| `model` | `string` | Required | Firmware applicable device model. |
| `make` | `string` | Required | Firmware applicable device make. |
| `protocol` | [`CampaignMetaInfoProtocol`](../../doc/models/campaign-meta-info-protocol.md) | Required | Firmware protocol. Valid values include: LWM2M, OMD-DM.<br><br>**Default**: `CampaignMetaInfoProtocol.LwM2M` |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

