
# Firmware Upgrade

Array of upgrade objects with the specified status.

*This model accepts additional fields of type unknown.*

## Structure

`FirmwareUpgrade`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string \| undefined` | Optional | The unique identifier for this upgrade. |
| `accountName` | `string \| undefined` | Optional | Account identifier in "##########-#####". |
| `firmwareName` | `string \| undefined` | Optional | The name of the firmware image that will be used for the upgrade. |
| `firmwareTo` | `string \| undefined` | Optional | The name of the firmware version that will be on the devices after a successful upgrade. |
| `startDate` | `string \| undefined` | Optional | The intended start date for the upgrade. |
| `status` | `string \| undefined` | Optional | The current status of the upgrade. |
| `deviceList` | [`FirmwareUpgradeDeviceListItem[] \| undefined`](../../doc/models/firmware-upgrade-device-list-item.md) | Optional | A JSON object for each device that was included in the upgrade, showing the device IMEI, the status of the upgrade, and additional information about the status. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

