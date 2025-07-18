
# Firmware Package

Available firmware.

*This model accepts additional fields of type array.*

## Structure

`FirmwarePackage`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `firmwareName` | `string` | Required | Firmware name. | getFirmwareName(): string | setFirmwareName(string firmwareName): void |
| `firmwareFrom` | `string` | Required | Firmware from version. | getFirmwareFrom(): string | setFirmwareFrom(string firmwareFrom): void |
| `firmwareTo` | `string` | Required | Firmware to version. | getFirmwareTo(): string | setFirmwareTo(string firmwareTo): void |
| `launchDate` | `DateTime` | Required | Firmware launch date. | getLaunchDate(): \DateTime | setLaunchDate(\DateTime launchDate): void |
| `releaseNote` | `string` | Required | Firmware release note. | getReleaseNote(): string | setReleaseNote(string releaseNote): void |
| `model` | `string` | Required | Firmware applicable device model. | getModel(): string | setModel(string model): void |
| `make` | `string` | Required | Firmware applicable device make. | getMake(): string | setMake(string make): void |
| `protocol` | [`string(CampaignMetaInfoProtocol)`](../../doc/models/campaign-meta-info-protocol.md) | Required | Firmware protocol. Valid values include: LWM2M, OMD-DM.<br><br>**Default**: `CampaignMetaInfoProtocol::LW_M2M` | getProtocol(): string | setProtocol(string protocol): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

