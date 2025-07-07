
# Device Upgrade History

Firmware upgrade information.

*This model accepts additional fields of type Object.*

## Structure

`DeviceUpgradeHistory`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceId` | `String` | Optional | Device IMEI. | String getDeviceId() | setDeviceId(String deviceId) |
| `Id` | `String` | Optional | The unique identifier for the upgrade. | String getId() | setId(String id) |
| `AccountName` | `String` | Optional | The name (number) of the billing account that the device belongs to. | String getAccountName() | setAccountName(String accountName) |
| `FirmwareFrom` | `String` | Optional | The firmware version that was on the device before the upgrade. | String getFirmwareFrom() | setFirmwareFrom(String firmwareFrom) |
| `FirmwareTo` | `String` | Optional | The name of the firmware version that was on the device after the upgrade. | String getFirmwareTo() | setFirmwareTo(String firmwareTo) |
| `StartDate` | `String` | Optional | The date of the upgrade. | String getStartDate() | setStartDate(String startDate) |
| `UpgradeStartTime` | `String` | Optional | The date and time that the upgrade actually started for this device. | String getUpgradeStartTime() | setUpgradeStartTime(String upgradeStartTime) |
| `Status` | `String` | Optional | The status of the upgrade for this device. | String getStatus() | setStatus(String status) |
| `Reason` | `String` | Optional | More information about the status. | String getReason() | setReason(String reason) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceId": "900000000000001",
  "id": "f574fbb8-b291-4cc7-bf22-4e3f27977558",
  "accountName": "0242078689-00001",
  "firmwareFrom": "VerizonFirmwareVersion-02",
  "firmwareTo": "VerizonFirmwareVersion-03",
  "startDate": "2018-03-05",
  "upgradeStartTime": "2018-03-05T19:07:21Z",
  "status": "UpgradeSuccess",
  "reason": "success",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

