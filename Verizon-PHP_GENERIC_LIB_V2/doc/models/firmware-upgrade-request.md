
# Firmware Upgrade Request

Details of the firmware upgrade request.

*This model accepts additional fields of type array.*

## Structure

`FirmwareUpgradeRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `string` | Required | Account identifier in "##########-#####". | getAccountName(): string | setAccountName(string accountName): void |
| `firmwareName` | `string` | Required | The name of the firmware image that will be used for the upgrade, from a GET /firmware response. | getFirmwareName(): string | setFirmwareName(string firmwareName): void |
| `firmwareTo` | `string` | Required | The name of the firmware version that will be on the devices after a successful upgrade. | getFirmwareTo(): string | setFirmwareTo(string firmwareTo): void |
| `startDate` | `DateTime` | Required | The date that the upgrade begins. | getStartDate(): \DateTime | setStartDate(\DateTime startDate): void |
| `endDate` | `DateTime` | Required | The date that the upgrade ends. | getEndDate(): \DateTime | setEndDate(\DateTime endDate): void |
| `deviceList` | `string[]` | Required | The IMEIs of the devices. | getDeviceList(): array | setDeviceList(array deviceList): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "0402196254-00001",
  "firmwareName": "FOTA_Verizon_Model-A_01To02_HF",
  "firmwareTo": "VerizonFirmwareVersion-02",
  "startDate": "2018-04-01",
  "endDate": "2018-04-05",
  "deviceList": [
    "990003425730535",
    "990000473475989",
    "990005733420535",
    "990000347475989",
    "990007303425535",
    "990007590473489"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

