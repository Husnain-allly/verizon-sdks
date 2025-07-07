
# V2 License Imei

IMEIs of the devices to assign or remove licenses.

*This model accepts additional fields of type Object.*

## Structure

`V2LicenseImei`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | Account name. | String getAccountName() | setAccountName(String accountName) |
| `DeviceList` | `List<String>` | Required | Device IMEI list. | List<String> getDeviceList() | setDeviceList(List<String> deviceList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceList": [
    "990003425730524",
    "990000473475967"
  ],
  "accountName": "accountName8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

