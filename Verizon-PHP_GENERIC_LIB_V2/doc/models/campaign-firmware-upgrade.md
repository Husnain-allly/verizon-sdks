
# Campaign Firmware Upgrade

Firmware upgrade for devices.

*This model accepts additional fields of type array.*

## Structure

`CampaignFirmwareUpgrade`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `campaignName` | `?string` | Optional | Campaign name. | getCampaignName(): ?string | setCampaignName(?string campaignName): void |
| `firmwareName` | `string` | Required | Firmware name to upgrade to. | getFirmwareName(): string | setFirmwareName(string firmwareName): void |
| `firmwareFrom` | `string` | Required | Old firmware version. | getFirmwareFrom(): string | setFirmwareFrom(string firmwareFrom): void |
| `firmwareTo` | `string` | Required | New firmware version. | getFirmwareTo(): string | setFirmwareTo(string firmwareTo): void |
| `protocol` | `string` | Required | Valid values include: LWM2M, OMA and HTTP.<br><br>**Default**: `'LWM2M'` | getProtocol(): string | setProtocol(string protocol): void |
| `startDate` | `DateTime` | Required | Campaign start date. | getStartDate(): \DateTime | setStartDate(\DateTime startDate): void |
| `endDate` | `DateTime` | Required | Campaign end date. | getEndDate(): \DateTime | setEndDate(\DateTime endDate): void |
| `campaignTimeWindowList` | [`?(V3TimeWindow[])`](../../doc/models/v3-time-window.md) | Optional | List of allowed campaign time windows. | getCampaignTimeWindowList(): ?array | setCampaignTimeWindowList(?array campaignTimeWindowList): void |
| `deviceList` | `string[]` | Required | Device IMEI list. | getDeviceList(): array | setDeviceList(array deviceList): void |
| `autoAssignLicenseFlag` | `bool` | Required | This flag, when set to true, will assign a FOTA license automatically if the device does not have one already. | getAutoAssignLicenseFlag(): bool | setAutoAssignLicenseFlag(bool autoAssignLicenseFlag): void |
| `autoAddDevicesFlag` | `bool` | Required | this flag, when set to true, will automatically add a device of the same make and model to a campaign. | getAutoAddDevicesFlag(): bool | setAutoAddDevicesFlag(bool autoAddDevicesFlag): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

