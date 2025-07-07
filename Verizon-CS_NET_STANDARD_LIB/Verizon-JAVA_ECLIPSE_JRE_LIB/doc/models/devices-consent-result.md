
# Devices Consent Result

*This model accepts additional fields of type Object.*

## Structure

`DevicesConsentResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | Account identifier in "##########-#####". | String getAccountName() | setAccountName(String accountName) |
| `AllDevice` | `Boolean` | Optional | Exclude all devices or not? | Boolean getAllDevice() | setAllDevice(Boolean allDevice) |
| `HasMoreData` | `Boolean` | Optional | Are there more devices to retrieve or not? | Boolean getHasMoreData() | setHasMoreData(Boolean hasMoreData) |
| `TotalCount` | `Integer` | Optional | Total number of excluded devices in the account. | Integer getTotalCount() | setTotalCount(Integer totalCount) |
| `UpdateTime` | `String` | Optional | Last update time. | String getUpdateTime() | setUpdateTime(String updateTime) |
| `Exclusion` | `List<String>` | Optional | Device ID list. | List<String> getExclusion() | setExclusion(List<String> exclusion) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "2024009649-00001",
  "allDevice": false,
  "hasMoreData": false,
  "totalCount": 4,
  "updateTime": "2018-05-18 19:20:50.076 +0000 UTC",
  "exclusion": [
    "990003420535375",
    "420535399000375",
    "A100003861E585",
    "205353759900034"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

