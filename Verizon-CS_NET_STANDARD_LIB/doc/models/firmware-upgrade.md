
# Firmware Upgrade

Array of upgrade objects with the specified status.

*This model accepts additional fields of type object.*

## Structure

`FirmwareUpgrade`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | The unique identifier for this upgrade. |
| `AccountName` | `string` | Optional | Account identifier in "##########-#####". |
| `FirmwareName` | `string` | Optional | The name of the firmware image that will be used for the upgrade. |
| `FirmwareTo` | `string` | Optional | The name of the firmware version that will be on the devices after a successful upgrade. |
| `StartDate` | `string` | Optional | The intended start date for the upgrade. |
| `Status` | `string` | Optional | The current status of the upgrade. |
| `DeviceList` | [`List<FirmwareUpgradeDeviceListItem>`](../../doc/models/firmware-upgrade-device-list-item.md) | Optional | A JSON object for each device that was included in the upgrade, showing the device IMEI, the status of the upgrade, and additional information about the status. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "accountName": "0402196254-00001",
  "firmwareName": "FOTA_Verizon_Model-A_01To02_HF",
  "firmwareTo": "VerizonFirmwareVersion-02",
  "startDate": "2018-04-01",
  "status": "Queued",
  "deviceList": [
    {
      "deviceId": "900000000000002",
      "status": "Device Accepted",
      "resultReason": "success"
    },
    {
      "deviceId": "900000000000003",
      "status": "Device Accepted",
      "resultReason": "success"
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

