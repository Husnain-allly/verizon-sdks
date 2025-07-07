
# Consent Delete Request

*This model accepts additional fields of type Object.*

## Structure

`ConsentDeleteRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | Account identifier. | String getAccountName() | setAccountName(String accountName) |
| `DeviceList` | `List<String>` | Optional | Device ID list. | List<String> getDeviceList() | setDeviceList(List<String> deviceList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "MyAccount-1",
  "deviceList": [
    "deviceList2",
    "deviceList3"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

