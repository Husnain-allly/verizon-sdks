
# Firmware Upgrade

Array of upgrade objects with the specified status.

*This model accepts additional fields of type Object.*

## Structure

`FirmwareUpgrade`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Id` | `String` | Optional | The unique identifier for this upgrade. | String getId() | setId(String id) |
| `AccountName` | `String` | Optional | Account identifier in "##########-#####". | String getAccountName() | setAccountName(String accountName) |
| `FirmwareName` | `String` | Optional | The name of the firmware image that will be used for the upgrade. | String getFirmwareName() | setFirmwareName(String firmwareName) |
| `FirmwareTo` | `String` | Optional | The name of the firmware version that will be on the devices after a successful upgrade. | String getFirmwareTo() | setFirmwareTo(String firmwareTo) |
| `StartDate` | `String` | Optional | The intended start date for the upgrade. | String getStartDate() | setStartDate(String startDate) |
| `Status` | `String` | Optional | The current status of the upgrade. | String getStatus() | setStatus(String status) |
| `DeviceList` | [`List<FirmwareUpgradeDeviceListItem>`](../../doc/models/firmware-upgrade-device-list-item.md) | Optional | A JSON object for each device that was included in the upgrade, showing the device IMEI, the status of the upgrade, and additional information about the status. | List<FirmwareUpgradeDeviceListItem> getDeviceList() | setDeviceList(List<FirmwareUpgradeDeviceListItem> deviceList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

