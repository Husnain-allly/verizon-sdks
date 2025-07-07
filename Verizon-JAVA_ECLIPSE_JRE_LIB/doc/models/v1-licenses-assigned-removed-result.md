
# V1 Licenses Assigned Removed Result

License assignment or removal confirmation.

*This model accepts additional fields of type Object.*

## Structure

`V1LicensesAssignedRemovedResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | Account identifier in "##########-#####". | String getAccountName() | setAccountName(String accountName) |
| `LicCount` | `Integer` | Optional | Total number of monthly licenses in an MRC subscription. | Integer getLicCount() | setLicCount(Integer licCount) |
| `LicUsedCount` | `Integer` | Optional | Number of licenses assigned to devices after the request completed. | Integer getLicUsedCount() | setLicUsedCount(Integer licUsedCount) |
| `DeviceList` | [`List<V1DeviceListItem>`](../../doc/models/v1-device-list-item.md) | Optional | A JSON object for each device that was in the request. | List<V1DeviceListItem> getDeviceList() | setDeviceList(List<V1DeviceListItem> deviceList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "0242078689-00001",
  "licCount": 9000,
  "licUsedCount": 1000,
  "deviceList": [
    {
      "deviceId": "900000000000001",
      "status": "LicenseAssignSuccess",
      "Reason": "Success",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "deviceId": "900000000000999",
      "status": "LicenseAssignSuccess",
      "Reason": "Success",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

