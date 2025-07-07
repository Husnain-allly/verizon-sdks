
# Device Software Upgrade

Array of software upgrade objects with the specified status.

*This model accepts additional fields of type Object.*

## Structure

`DeviceSoftwareUpgrade`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceId` | `String` | Required | Device identifier. | String getDeviceId() | setDeviceId(String deviceId) |
| `Id` | `String` | Required | Upgrade identifier. | String getId() | setId(String id) |
| `AccountName` | `String` | Required | Account identifier. | String getAccountName() | setAccountName(String accountName) |
| `SoftwareName` | `String` | Optional | Software name. | String getSoftwareName() | setSoftwareName(String softwareName) |
| `StartDate` | `LocalDate` | Required | Software upgrade start date. | LocalDate getStartDate() | setStartDate(LocalDate startDate) |
| `Status` | `String` | Required | Software upgrade status. | String getStatus() | setStatus(String status) |
| `Reason` | `String` | Required | Software upgrade result reason. | String getReason() | setReason(String reason) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceId": "990013907835573",
  "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "accountName": "0402196254-00001",
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "startDate": "2018-03-05",
  "status": "UpgradeSuccess",
  "reason": "success",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

