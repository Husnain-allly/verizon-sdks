
# Account License Info

Account license information.

*This model accepts additional fields of type Object.*

## Structure

`AccountLicenseInfo`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | Account identifier in "##########-#####". | String getAccountName() | setAccountName(String accountName) |
| `TotalLicenses` | `Integer` | Optional | Number of monthly licenses in an MRC subscription. | Integer getTotalLicenses() | setTotalLicenses(Integer totalLicenses) |
| `AssignedLicenses` | `Integer` | Optional | Number of licenses currently assigned to devices. | Integer getAssignedLicenses() | setAssignedLicenses(Integer assignedLicenses) |
| `HasMoreData` | `Boolean` | Optional | True if there are more devices to retrieve. | Boolean getHasMoreData() | setHasMoreData(Boolean hasMoreData) |
| `LastSeenDeviceId` | `Integer` | Optional | If hasMoreData=true, the startIndex to use for the next request. 0 if hasMoreData=false. | Integer getLastSeenDeviceId() | setLastSeenDeviceId(Integer lastSeenDeviceId) |
| `DeviceList` | [`List<AccountLicenseDeviceListItem>`](../../doc/models/account-license-device-list-item.md) | Optional | The list of devices that have licenses assigned, including the date and time of when each license was assigned. | List<AccountLicenseDeviceListItem> getDeviceList() | setDeviceList(List<AccountLicenseDeviceListItem> deviceList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "0402196254-00001",
  "totalLicenses": 5000,
  "assignedLicenses": 4319,
  "hasMoreData": true,
  "lastSeenDeviceId": 1000,
  "deviceList": [
    {
      "deviceId": "990003425730535",
      "assignmentTime": "2017-11-29T16:03:42.000Z"
    },
    {
      "deviceId": "990000473475989",
      "assignmentTime": "2017-11-29T16:03:42.000Z"
    },
    {
      "deviceId": "990000347475989",
      "assignmentTime": "2017-11-29T16:03:42.000Z"
    },
    {
      "deviceId": "990007303425535",
      "assignmentTime": "2016-11-29T16:03:42.000Z"
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

