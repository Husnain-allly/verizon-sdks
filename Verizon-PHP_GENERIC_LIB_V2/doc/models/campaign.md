
# Campaign

Firmware upgrade information.

*This model accepts additional fields of type array.*

## Structure

`Campaign`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `id` | `string` | Required | Upgrade identifier. | getId(): string | setId(string id): void |
| `accountName` | `string` | Required | Account identifier. | getAccountName(): string | setAccountName(string accountName): void |
| `campaignName` | `?string` | Optional | Campaign name. | getCampaignName(): ?string | setCampaignName(?string campaignName): void |
| `firmwareName` | `?string` | Optional | Name of firmware. | getFirmwareName(): ?string | setFirmwareName(?string firmwareName): void |
| `firmwareFrom` | `?string` | Optional | Old firmware version. | getFirmwareFrom(): ?string | setFirmwareFrom(?string firmwareFrom): void |
| `firmwareTo` | `?string` | Optional | New firmware version. | getFirmwareTo(): ?string | setFirmwareTo(?string firmwareTo): void |
| `protocol` | `string` | Required | The protocol of the firmware distribution. Default: LWM2M.<br><br>**Default**: `'LWM2M'` | getProtocol(): string | setProtocol(string protocol): void |
| `make` | `string` | Required | Applicable make. | getMake(): string | setMake(string make): void |
| `model` | `string` | Required | Applicable model. | getModel(): string | setModel(string model): void |
| `startDate` | `DateTime` | Required | Campaign start date. | getStartDate(): \DateTime | setStartDate(\DateTime startDate): void |
| `endDate` | `DateTime` | Required | Campaign end date. | getEndDate(): \DateTime | setEndDate(\DateTime endDate): void |
| `campaignTimeWindowList` | [`?(V3TimeWindow[])`](../../doc/models/v3-time-window.md) | Optional | List of allowed campaign time windows. | getCampaignTimeWindowList(): ?array | setCampaignTimeWindowList(?array campaignTimeWindowList): void |
| `status` | `string` | Required | Firmware upgrade status. | getStatus(): string | setStatus(string status): void |
| `autoAssignLicenseFlag` | `bool` | Required | Any device included in the device list which does not have a license will automatically be assigned a FOTA license, assuming there are enough FOTA licenses available, when set to true. | getAutoAssignLicenseFlag(): bool | setAutoAssignLicenseFlag(bool autoAssignLicenseFlag): void |
| `autoAddDevicesFlag` | `bool` | Required | Beyond the devices included on the device list, any other device(s) which matches the eligibility criteria (same make, model, current firmware, protocol, billing account) will automatically be added to the campaign list during the life of the campaign when set to true. | getAutoAddDevicesFlag(): bool | setAutoAddDevicesFlag(bool autoAddDevicesFlag): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

