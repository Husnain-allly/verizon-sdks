
# Device Upload Request

*This model accepts additional fields of type Object.*

## Structure

`DeviceUploadRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | - | String getAccountName() | setAccountName(String accountName) |
| `Devices` | [`List<DeviceList>`](../../doc/models/device-list.md) | Required | - | List<DeviceList> getDevices() | setDevices(List<DeviceList> devices) |
| `EmailAddress` | `String` | Required | - | String getEmailAddress() | setEmailAddress(String emailAddress) |
| `DeviceSku` | `String` | Required | - | String getDeviceSku() | setDeviceSku(String deviceSku) |
| `UploadType` | `String` | Required | - | String getUploadType() | setUploadType(String uploadType) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "1223334444-00001",
  "devices": [
    {
      "deviceIds": [
        {
          "id": "id0",
          "kind": "kind8",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ]
    }
  ],
  "emailAddress": "bob@mycompany.com",
  "deviceSku": "VZW123456",
  "uploadType": "IMEI",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

