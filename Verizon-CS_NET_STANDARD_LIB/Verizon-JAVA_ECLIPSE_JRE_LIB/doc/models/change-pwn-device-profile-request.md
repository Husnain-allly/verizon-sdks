
# Change Pwn Device Profile Request

*This model accepts additional fields of type Object.*

## Structure

`ChangePwnDeviceProfileRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | - | String getAccountName() | setAccountName(String accountName) |
| `DeviceList` | [`List<PwnDeviceList>`](../../doc/models/pwn-device-list.md) | Required | - | List<PwnDeviceList> getDeviceList() | setDeviceList(List<PwnDeviceList> deviceList) |
| `NewProfile` | `String` | Required | - | String getNewProfile() | setNewProfile(String newProfile) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "0342351414-00001",
  "deviceList": [
    {
      "deviceIds": [
        {
          "id": "99948099913024600000",
          "kind": "iccid",
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
  ],
  "newProfile": "HSS EsmProfile Enterprise 5G internet",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

